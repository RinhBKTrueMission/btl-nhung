#include <Wire.h>
#include <OneWire.h>
#include <DallasTemperature.h>
#include <ESP8266WiFi.h>
#include "MAX30100_PulseOximeter.h"
#include <PubSubClient.h>
#define DS18B20 D4
#define REPORTING_PERIOD_MS     1000
#define mqtt_server "broker.hivemq.com"
float BPM, SpO2,bodytemperature;

OneWire oneWire(DS18B20);
DallasTemperature sensors(&oneWire);
const char* ssid = "iPhone";  // Enter SSID here
const char* password = "55555555";  //Enter Password here
const uint16_t mqtt_port = 1883;

WiFiClient espClient;
PubSubClient client(espClient);

PulseOximeter pox;
uint32_t tsLastReport = 0;
unsigned long tsLastTime = millis() ;
void setup_wifi() 
{
  delay(10);
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
}
void onBeatDetected()
{
  Serial.println("Beat!");
}
void callback(char* topic, byte* payload, unsigned int length) 
{
  Serial.print("Co tin nhan moi tu topic:");
  Serial.println(topic);
  for (int i = 0; i < length; i++) 
  Serial.print((char)payload[i]);
  Serial.println();
}
// Hàm reconnect thực hiện kết nối lại khi mất kết nối với MQTT Broker
void reconnect() 
{
  while (!client.connected()) // Chờ tới khi kết nối
  {
    // Thực hiện kết nối với mqtt user và pass
    if (client.connect("ESP8266_id1","ESP_offline",0,0,"ESP8266_id1_offline"))  //kết nối vào broker
    {
      Serial.println("Đã kết nối:");
      client.subscribe("demobtl"); //đăng kí nhận dữ liệu từ topic IoT47_MQTT_Test
    }
    else 
    {
      Serial.print("Lỗi:, rc=");
      Serial.print(client.state());
      Serial.println(" try again in 5 seconds");
      // Đợi 5s
      delay(5000);
    }
  }
}
void setup() {
  // put your setup code here, to run once:
 // pinMode(D5, OUTPUT);
  Serial.begin(115200);
  delay(100);
  setup_wifi();
  client.setServer(mqtt_server, mqtt_port); 
  client.setCallback(callback);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.print(".");
  }
  Serial.println("");
  Serial.println("WiFi connected..!");
  Serial.print("Got IP: ");  Serial.println(WiFi.localIP());
  Serial.print("Initializing pulse oximeter..");

  if (!pox.begin()) {
    Serial.println("FAILED");
    for (;;);
  } else {
    Serial.println("SUCCESS");
    pox.setOnBeatDetectedCallback(onBeatDetected);
    
  }
  pox.setIRLedCurrent(MAX30100_LED_CURR_7_6MA);
  

}

void loop() {
  
   //char h[]="5/7.13/93.00/71.28";
   // client.publish("demobtl1",h);
   //tsLastTime = millis();
   pox.update();
   BPM = pox.getHeartRate();
   SpO2 = pox.getSpO2();
  // Serial.print(millis() - tsLastTime );
  // Serial.println("ms");
   
  
   if (!client.connected()){// Kiểm tra kết nối
         reconnect();
   }else{
   
    }
   if(!client.loop())
    client.connect("ESP8266Client");
   if (millis() - tsLastReport > REPORTING_PERIOD_MS) {
    //sensors.requestTemperatures();
    tsLastTime = millis();
    sensors.requestTemperatures();
    bodytemperature = sensors.getTempCByIndex(0);
    Serial.print(millis() - tsLastTime );
    Serial.println("ms");
    String mess="5/" + String(bodytemperature) + "/" + String(SpO2) + "/" + String(BPM);
    int n = mess.length();
    char char_coppy[n+1];
    strcpy(char_coppy, mess.c_str());
    //tsLastTime = millis();
    client.publish("demobtl1",char_coppy);
    //Serial.print(millis() - tsLastTime );
    //Serial.println("ms");
    //Serial.println(t);
    delay(100);
    Serial.print("BPM: ");
    Serial.println(BPM);

    Serial.print("SpO2: ");
    Serial.print(SpO2);
    Serial.println("%");

    Serial.print("Body Temperature: ");
    Serial.print(bodytemperature);
    Serial.println("°C");
    Serial.println("*********************************");
    Serial.println();
    
    Serial.println(char_coppy);
   
    delay(10000);
    tsLastReport = millis();
  }
  
  
}
