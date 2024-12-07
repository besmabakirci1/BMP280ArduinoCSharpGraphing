#include <Wire.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_BMP280.h>

Adafruit_BMP280 bmp;

void setup() {
 Serial.begin(9600);
    if (!bmp.begin(0x76)) {
        Serial.println("BMP280 not found!");
        while (1);
    }
}

void loop() {
  float temperature = bmp.readTemperature();
    float pressure = bmp.readPressure() / 100.0F;

    // Veriyi CSV formatında gönder
    Serial.print(temperature);
    Serial.print(",");
    Serial.println(pressure);

    delay(1000); // Her saniyede bir veri gönder
}
