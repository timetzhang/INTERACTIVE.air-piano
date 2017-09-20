namespace AirPiano
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.resultText = new System.Windows.Forms.TextBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.sound01 = new System.Windows.Forms.Button();
            this.sound02 = new System.Windows.Forms.Button();
            this.sound03 = new System.Windows.Forms.Button();
            this.sound04 = new System.Windows.Forms.Button();
            this.sound05 = new System.Windows.Forms.Button();
            this.sound06 = new System.Windows.Forms.Button();
            this.sound08 = new System.Windows.Forms.Button();
            this.sound07 = new System.Windows.Forms.Button();
            this.sound09 = new System.Windows.Forms.Button();
            this.sound10 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.preview02 = new System.Windows.Forms.PictureBox();
            this.preview03 = new System.Windows.Forms.PictureBox();
            this.preview04 = new System.Windows.Forms.PictureBox();
            this.preview05 = new System.Windows.Forms.PictureBox();
            this.preview06 = new System.Windows.Forms.PictureBox();
            this.preview08 = new System.Windows.Forms.PictureBox();
            this.preview07 = new System.Windows.Forms.PictureBox();
            this.preview09 = new System.Windows.Forms.PictureBox();
            this.preview10 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.preview01 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.listBoxPresents = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.preview02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview10)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview01)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.resultText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultText.Font = new System.Drawing.Font("Consolas", 9F);
            this.resultText.ForeColor = System.Drawing.Color.White;
            this.resultText.Location = new System.Drawing.Point(3, 3);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(764, 128);
            this.resultText.TabIndex = 0;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.comboBoxPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPort.Font = new System.Drawing.Font("Tahoma", 14F);
            this.comboBoxPort.ForeColor = System.Drawing.Color.White;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(3, 45);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(181, 31);
            this.comboBoxPort.TabIndex = 1;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // sound01
            // 
            this.sound01.BackColor = System.Drawing.Color.Transparent;
            this.sound01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sound01.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sound01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound01.Font = new System.Drawing.Font("Consolas", 9F);
            this.sound01.ForeColor = System.Drawing.Color.White;
            this.sound01.Location = new System.Drawing.Point(13, 13);
            this.sound01.Name = "sound01";
            this.sound01.Size = new System.Drawing.Size(77, 108);
            this.sound01.TabIndex = 2;
            this.sound01.Text = "Sound 01";
            this.sound01.UseVisualStyleBackColor = false;
            this.sound01.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // sound02
            // 
            this.sound02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sound02.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sound02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound02.Font = new System.Drawing.Font("Consolas", 9F);
            this.sound02.ForeColor = System.Drawing.Color.White;
            this.sound02.Location = new System.Drawing.Point(13, 13);
            this.sound02.Name = "sound02";
            this.sound02.Size = new System.Drawing.Size(77, 107);
            this.sound02.TabIndex = 2;
            this.sound02.Text = "Sound 02";
            this.sound02.UseVisualStyleBackColor = true;
            this.sound02.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // sound03
            // 
            this.sound03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sound03.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sound03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound03.Font = new System.Drawing.Font("Consolas", 9F);
            this.sound03.ForeColor = System.Drawing.Color.White;
            this.sound03.Location = new System.Drawing.Point(13, 13);
            this.sound03.Name = "sound03";
            this.sound03.Size = new System.Drawing.Size(77, 107);
            this.sound03.TabIndex = 2;
            this.sound03.Text = "Sound 03";
            this.sound03.UseVisualStyleBackColor = true;
            this.sound03.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // sound04
            // 
            this.sound04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sound04.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sound04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound04.Font = new System.Drawing.Font("Consolas", 9F);
            this.sound04.ForeColor = System.Drawing.Color.White;
            this.sound04.Location = new System.Drawing.Point(13, 13);
            this.sound04.Name = "sound04";
            this.sound04.Size = new System.Drawing.Size(77, 107);
            this.sound04.TabIndex = 2;
            this.sound04.Text = "Sound 04";
            this.sound04.UseVisualStyleBackColor = true;
            this.sound04.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // sound05
            // 
            this.sound05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sound05.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound05.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sound05.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound05.Font = new System.Drawing.Font("Consolas", 9F);
            this.sound05.ForeColor = System.Drawing.Color.White;
            this.sound05.Location = new System.Drawing.Point(13, 13);
            this.sound05.Name = "sound05";
            this.sound05.Size = new System.Drawing.Size(79, 107);
            this.sound05.TabIndex = 2;
            this.sound05.Text = "Sound 05";
            this.sound05.UseVisualStyleBackColor = true;
            this.sound05.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // sound06
            // 
            this.sound06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sound06.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound06.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sound06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound06.Font = new System.Drawing.Font("Consolas", 9F);
            this.sound06.ForeColor = System.Drawing.Color.White;
            this.sound06.Location = new System.Drawing.Point(13, 13);
            this.sound06.Name = "sound06";
            this.sound06.Size = new System.Drawing.Size(77, 107);
            this.sound06.TabIndex = 2;
            this.sound06.Text = "Sound 06";
            this.sound06.UseVisualStyleBackColor = true;
            this.sound06.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // sound08
            // 
            this.sound08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sound08.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound08.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sound08.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound08.Font = new System.Drawing.Font("Consolas", 9F);
            this.sound08.ForeColor = System.Drawing.Color.White;
            this.sound08.Location = new System.Drawing.Point(13, 13);
            this.sound08.Name = "sound08";
            this.sound08.Size = new System.Drawing.Size(77, 107);
            this.sound08.TabIndex = 2;
            this.sound08.Text = "Sound 08";
            this.sound08.UseVisualStyleBackColor = true;
            this.sound08.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // sound07
            // 
            this.sound07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sound07.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound07.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sound07.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound07.Font = new System.Drawing.Font("Consolas", 9F);
            this.sound07.ForeColor = System.Drawing.Color.White;
            this.sound07.Location = new System.Drawing.Point(13, 13);
            this.sound07.Name = "sound07";
            this.sound07.Size = new System.Drawing.Size(77, 107);
            this.sound07.TabIndex = 2;
            this.sound07.Text = "Sound 07";
            this.sound07.UseVisualStyleBackColor = true;
            this.sound07.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // sound09
            // 
            this.sound09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sound09.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound09.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sound09.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound09.Font = new System.Drawing.Font("Consolas", 9F);
            this.sound09.ForeColor = System.Drawing.Color.White;
            this.sound09.Location = new System.Drawing.Point(13, 13);
            this.sound09.Name = "sound09";
            this.sound09.Size = new System.Drawing.Size(77, 107);
            this.sound09.TabIndex = 2;
            this.sound09.Text = "Sound 09";
            this.sound09.UseVisualStyleBackColor = true;
            this.sound09.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // sound10
            // 
            this.sound10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sound10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sound10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sound10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound10.Font = new System.Drawing.Font("Consolas", 9F);
            this.sound10.ForeColor = System.Drawing.Color.White;
            this.sound10.Location = new System.Drawing.Point(13, 13);
            this.sound10.Name = "sound10";
            this.sound10.Size = new System.Drawing.Size(79, 107);
            this.sound10.TabIndex = 2;
            this.sound10.Text = "Sound 10";
            this.sound10.UseVisualStyleBackColor = true;
            this.sound10.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Consolas", 9F);
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(3, 87);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(181, 38);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "音频文件|*.wav;*.mp3;*.flav;*.aac";
            this.openFileDialog.Title = "请选择音频文件";
            // 
            // preview02
            // 
            this.preview02.BackColor = System.Drawing.Color.Transparent;
            this.preview02.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview02.BackgroundImage")));
            this.preview02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview02.Location = new System.Drawing.Point(96, 13);
            this.preview02.Name = "preview02";
            this.preview02.Size = new System.Drawing.Size(78, 107);
            this.preview02.TabIndex = 6;
            this.preview02.TabStop = false;
            this.preview02.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // preview03
            // 
            this.preview03.BackColor = System.Drawing.Color.Transparent;
            this.preview03.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview03.BackgroundImage")));
            this.preview03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview03.Location = new System.Drawing.Point(96, 13);
            this.preview03.Name = "preview03";
            this.preview03.Size = new System.Drawing.Size(78, 107);
            this.preview03.TabIndex = 6;
            this.preview03.TabStop = false;
            this.preview03.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // preview04
            // 
            this.preview04.BackColor = System.Drawing.Color.Transparent;
            this.preview04.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview04.BackgroundImage")));
            this.preview04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview04.Location = new System.Drawing.Point(96, 13);
            this.preview04.Name = "preview04";
            this.preview04.Size = new System.Drawing.Size(78, 107);
            this.preview04.TabIndex = 6;
            this.preview04.TabStop = false;
            this.preview04.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // preview05
            // 
            this.preview05.BackColor = System.Drawing.Color.Transparent;
            this.preview05.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview05.BackgroundImage")));
            this.preview05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview05.Location = new System.Drawing.Point(98, 13);
            this.preview05.Name = "preview05";
            this.preview05.Size = new System.Drawing.Size(80, 107);
            this.preview05.TabIndex = 6;
            this.preview05.TabStop = false;
            this.preview05.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // preview06
            // 
            this.preview06.BackColor = System.Drawing.Color.Transparent;
            this.preview06.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview06.BackgroundImage")));
            this.preview06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview06.Location = new System.Drawing.Point(96, 13);
            this.preview06.Name = "preview06";
            this.preview06.Size = new System.Drawing.Size(78, 107);
            this.preview06.TabIndex = 6;
            this.preview06.TabStop = false;
            this.preview06.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // preview08
            // 
            this.preview08.BackColor = System.Drawing.Color.Transparent;
            this.preview08.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview08.BackgroundImage")));
            this.preview08.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview08.Location = new System.Drawing.Point(96, 13);
            this.preview08.Name = "preview08";
            this.preview08.Size = new System.Drawing.Size(78, 107);
            this.preview08.TabIndex = 6;
            this.preview08.TabStop = false;
            this.preview08.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // preview07
            // 
            this.preview07.BackColor = System.Drawing.Color.Transparent;
            this.preview07.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview07.BackgroundImage")));
            this.preview07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview07.Location = new System.Drawing.Point(96, 13);
            this.preview07.Name = "preview07";
            this.preview07.Size = new System.Drawing.Size(78, 107);
            this.preview07.TabIndex = 6;
            this.preview07.TabStop = false;
            this.preview07.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // preview09
            // 
            this.preview09.BackColor = System.Drawing.Color.Transparent;
            this.preview09.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview09.BackgroundImage")));
            this.preview09.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview09.Location = new System.Drawing.Point(96, 13);
            this.preview09.Name = "preview09";
            this.preview09.Size = new System.Drawing.Size(78, 107);
            this.preview09.TabIndex = 6;
            this.preview09.TabStop = false;
            this.preview09.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // preview10
            // 
            this.preview10.BackColor = System.Drawing.Color.Transparent;
            this.preview10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview10.BackgroundImage")));
            this.preview10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview10.Location = new System.Drawing.Point(98, 13);
            this.preview10.Name = "preview10";
            this.preview10.Size = new System.Drawing.Size(80, 107);
            this.preview10.TabIndex = 6;
            this.preview10.TabStop = false;
            this.preview10.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel11, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel12, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxPresents, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1169, 726);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.sound08, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.preview08, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(589, 336);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(187, 247);
            this.tableLayoutPanel9.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.sound01, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.preview01, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(203, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.23042F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.76958F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(187, 247);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // preview01
            // 
            this.preview01.BackColor = System.Drawing.Color.Transparent;
            this.preview01.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview01.BackgroundImage")));
            this.preview01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview01.Location = new System.Drawing.Point(96, 13);
            this.preview01.Name = "preview01";
            this.preview01.Size = new System.Drawing.Size(78, 108);
            this.preview01.TabIndex = 6;
            this.preview01.TabStop = false;
            this.preview01.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.sound02, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.preview02, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(396, 83);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(187, 247);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.sound03, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.preview03, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(589, 83);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(187, 247);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.sound04, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.preview04, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(782, 83);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(187, 247);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.sound05, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.preview05, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(975, 83);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(191, 247);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.sound06, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.preview06, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(203, 336);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(187, 247);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.sound07, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.preview07, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(396, 336);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(187, 247);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.sound09, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.preview09, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(782, 336);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(187, 247);
            this.tableLayoutPanel10.TabIndex = 9;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.preview10, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.sound10, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(975, 336);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(191, 247);
            this.tableLayoutPanel11.TabIndex = 10;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel12, 5);
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel12.Controls.Add(this.resultText, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(203, 589);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(963, 134);
            this.tableLayoutPanel12.TabIndex = 12;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Controls.Add(this.buttonReset, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.comboBoxPort, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(773, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(187, 128);
            this.tableLayoutPanel13.TabIndex = 1;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 6);
            this.panel1.Controls.Add(this.tableLayoutPanel14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 74);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 3;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.52105F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.47895F));
            this.tableLayoutPanel14.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.pictureBoxClose, 2, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(1163, 74);
            this.tableLayoutPanel14.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel14.SetColumnSpan(this.panel2, 3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 1);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aero Music Pad";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(40, 49);
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.BackgroundImage")));
            this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxClose.Location = new System.Drawing.Point(1103, 10);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(50, 49);
            this.pictureBoxClose.TabIndex = 6;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // listBoxPresents
            // 
            this.listBoxPresents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listBoxPresents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPresents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPresents.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPresents.ForeColor = System.Drawing.Color.White;
            this.listBoxPresents.FormattingEnabled = true;
            this.listBoxPresents.ItemHeight = 25;
            this.listBoxPresents.Items.AddRange(new object[] {
            "Drum",
            "Piano",
            "Vinyl",
            "Loop",
            "Fx"});
            this.listBoxPresents.Location = new System.Drawing.Point(10, 90);
            this.listBoxPresents.Margin = new System.Windows.Forms.Padding(10);
            this.listBoxPresents.Name = "listBoxPresents";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxPresents, 3);
            this.listBoxPresents.Size = new System.Drawing.Size(180, 626);
            this.listBoxPresents.TabIndex = 13;
            this.listBoxPresents.SelectedIndexChanged += new System.EventHandler(this.listBoxPresents_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 726);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "AeroDrum";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.preview02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview10)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview01)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button sound01;
        private System.Windows.Forms.Button sound02;
        private System.Windows.Forms.Button sound03;
        private System.Windows.Forms.Button sound04;
        private System.Windows.Forms.Button sound05;
        private System.Windows.Forms.Button sound06;
        private System.Windows.Forms.Button sound08;
        private System.Windows.Forms.Button sound07;
        private System.Windows.Forms.Button sound09;
        private System.Windows.Forms.Button sound10;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox preview02;
        private System.Windows.Forms.PictureBox preview03;
        private System.Windows.Forms.PictureBox preview04;
        private System.Windows.Forms.PictureBox preview05;
        private System.Windows.Forms.PictureBox preview06;
        private System.Windows.Forms.PictureBox preview08;
        private System.Windows.Forms.PictureBox preview07;
        private System.Windows.Forms.PictureBox preview09;
        private System.Windows.Forms.PictureBox preview10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox preview01;
        private System.Windows.Forms.ListBox listBoxPresents;
    }
}

