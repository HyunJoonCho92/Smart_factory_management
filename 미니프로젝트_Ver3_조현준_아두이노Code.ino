#include <DHT.h>

#include <Wire.h>
#include <LiquidCrystal_I2C.h> //LCD 사용

#define DHTPIN A0  //온습도 센서 A0에 연결
#define DHTTYPE DHT11 //DHT11 온습도 센서 사용

DHT dht(DHTPIN, DHTTYPE);
DHT dht2(A1, DHT11);

LiquidCrystal_I2C lcd(0x27, 16, 2); //lcd(본인 lcd의 ID, X칸의 개수, Y칸의 개수)

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println(F("DHT11 Serial Start!"));
  dht.begin();
  dht2.begin();
  lcd.begin();
  lcd.clear();
  lcd.backlight();

  pinMode(2, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  float h = dht.readHumidity(); //습도값
  float t = dht.readTemperature(); //온도값

  float h2 = dht2.readHumidity(); //습도값
  float t2 = dht2.readTemperature(); //온도값
  
  lcd.setCursor(0, 0);
  lcd.print("Temperat[");
  lcd.print(t); lcd.print("C]");
  
  //Serial.print("Temperature: ");
  Serial.print((String) t + ", " + h + ", "); // 습도값 출력 
  Serial.println((String) t2 + ", " + h2); // 습도값 출력 
  //Serial.print("C "); 
  
  lcd.setCursor(0, 1);
  lcd.print("Huminity[");
  lcd.print(h);
  lcd.print("%]");
  
  //Serial.print("Humidity: "); // 문자열 출력
  //Serial.print(h); // 온도값 출력
  //Serial.println("%");

  if(t > 28 || h > 30)
  {
    digitalWrite(2, HIGH);
  }
  else
  {
    digitalWrite(2, LOW);
  }

  delay(1000);
}
