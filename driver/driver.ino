#include <Button.h>
#include <Ultrasonic.h>
/*
  Name:		AeroDrum.ino
  Created:	2016/9/20 21:39:19
  Author:	TT
*/

//define ultrasonic sensor pins
Ultrasonic ultrasonic(A2, A1);
//define button pins
Button btn1(2);
Button btn2(3);
//ultrasonic sensor params
int triggedCount = 0;
int threshold = 60;
int delayTime = 70;
//btn params
int btnCount = 0;

void setup()
{
  while (!Serial) { }; // for Leos
  Serial.begin(9600);
  btn1.begin();
  btn2.begin();
}

void loop()
{
  int distance = ultrasonic.distanceRead();
  if (distance < threshold && distance > 0) {
    //if (triggedCount == 0)
    //{
      Serial.println(distance);
    //triggedCount++;
      delay(delayTime);
    //}
  }
//  else
//  {
//    triggedCount = 0;
//  }
  if (btn1.released())
    Serial.println(101);
  if (btn2.released())
    Serial.println(102);
}

