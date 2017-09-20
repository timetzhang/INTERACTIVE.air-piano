using System;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Media;
using System.IO;

namespace AirPiano
{
    public partial class Main : Form
    {
        public MediaPlayer[] sound = new MediaPlayer[10];
        public int mediaFilesCount = 0;
        public Main()
        {
            InitializeSoundPlayer();
            InitializeComponent();
            LoadSound("drum");
            this.listBoxPresents.SelectedIndex = 0;
            InitializePort();
        }

        public void InitializeSoundPlayer()
        {
            for (int i = 0; i < 10; i++)
            {
                sound[i] = new MediaPlayer();
            }
        }
        public void InitializePort()
        {
            this.comboBoxPort.Items.Clear();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            for (int i = 1; i < ports.Length; i++)
            {
                try
                {
                    this.comboBoxPort.Items.Add(ports[i].ToString());
                }
                catch (Exception e)
                {
                    this.resultText.Text += e.ToString() + "\n\r";
                }
            }
            try
            {
                this.comboBoxPort.SelectedIndex = this.comboBoxPort.Items.Count - 1;
                this.serialPort.Close();
                this.serialPort.PortName = ports[ports.Length - 1];
                this.serialPort.Open();
            }
            catch (Exception e)
            {
                this.resultText.Text += e.ToString() + "\n\r";
            }
        }

        public void SoundPlay(int i, bool multiPlay = true)
        {
            if (multiPlay)
            {
                this.sound[i].Play();
                this.sound[i].Position = new TimeSpan(0);
            }
            else
            {
                for (int j = 0; j < 10; j++)
                {
                    this.sound[j].Stop();
                }
                this.sound[i].Play();
                this.sound[i].Position = new TimeSpan(0);
            }
        }

        public void LoadSound(string lib)
        {
            try
            {
                DirectoryInfo TheFolder = new DirectoryInfo(Environment.CurrentDirectory + @"\sound\" + lib + @"\");
                //遍历文件
                mediaFilesCount = 0;
                foreach (FileInfo NextFile in TheFolder.GetFiles())
                {
                    sound[mediaFilesCount].Open(new Uri(Environment.CurrentDirectory + @"\sound\" + lib + @"\" + NextFile.Name));
                    mediaFilesCount++;
                }
                this.resultText.Text += lib + " loaded. \n\r";
            }
            catch (Exception e)
            {
                this.resultText.Text += e.ToString() + "\n\r";
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            workDelegate player = new workDelegate(Play);

            try
            {
                if (serialPort.IsOpen)
                {
                    byte[] readBuffer = new byte[serialPort.ReadBufferSize];
                    serialPort.Read(readBuffer, 0, readBuffer.Length);
                    string readstr = Encoding.UTF8.GetString(readBuffer);

                    Invoke(player, readstr);
                }
            }
            catch (Exception ee)
            {
                this.resultText.Text += ee.ToString() + "\n\r\n\r";
            }
        }

        //数据接收使用的代理
        private delegate void workDelegate(string s);

        //显示接收的数据
        private void Play(string value)
        {
            try
            {
                int val = Convert.ToInt32(value);
                resultText.Text += "Original Signal: " + val + "\r\n";
                if (val < 100)
                {
                    resultText.Text += "Height： " + val + "cm \r\n";

                    for (int i = 0; i < mediaFilesCount; i++)
                    {
                        if (val >= 1+(60 / mediaFilesCount * i) && val <= 60 / mediaFilesCount + (60 / mediaFilesCount * i))
                        {
                            if (listBoxPresents.Text.ToLower() == "fx" || listBoxPresents.Text.ToLower() == "loop")
                            {
                                SoundPlay(i, false);
                            }
                            else
                            {
                                SoundPlay(i);
                            }
                        }
                    }
                }
                if (val == 101)
                {
                    if (this.listBoxPresents.SelectedIndex <= 0)
                    {
                        this.listBoxPresents.SelectedIndex = this.listBoxPresents.Items.Count - 1;
                    }
                    else
                    {
                        this.listBoxPresents.SelectedIndex--;
                    }
                }
                if (val == 102)
                {
                    if (this.listBoxPresents.SelectedIndex >= this.listBoxPresents.Items.Count - 1)
                    {
                        this.listBoxPresents.SelectedIndex = 0;
                    }
                    else
                    {
                        this.listBoxPresents.SelectedIndex++;
                    }
                }

                resultText.Select(resultText.Text.Length, 0);
                resultText.ScrollToCaret();
            }
            catch (Exception e)
            {
                resultText.Text += e.ToString() + "\n\r";
            }
        }

        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                this.serialPort.PortName = comboBoxPort.Items[comboBoxPort.SelectedIndex].ToString();
                serialPort.Open();
            }
            catch (Exception ee)
            {
                this.resultText.Text += ee.ToString() + "\n\r";
            }
        }

        #region button

        private void soundBtn_Click(object sender, EventArgs e)
        {
            int btnId = Convert.ToInt32(((Button)sender).Name.Remove(0, 5)) - 1;
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.sound[btnId].Open(new Uri(this.openFileDialog.FileName));
                ((Button)sender).Text = this.openFileDialog.SafeFileName;
            }
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            int btnId = Convert.ToInt32(((PictureBox)sender).Name.Remove(0, 7)) - 1;
            this.SoundPlay(btnId);
        }

        #endregion

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxPresents_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSound(this.listBoxPresents.Text);
        }
    }
}
