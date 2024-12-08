Real-Time Data Visualization with BMP280 and C#
---
🎯 Amaç 
BMP280 sensöründen sıcaklık ve basınç verilerini okumak.
Seri port üzerinden C# uygulaması ile Arduino arasında iletişim kurmak.
Verileri grafik üzerinde gerçek zamanlı olarak görselleştirmek.
Gelen verileri bir CSV dosyasına kaydederek daha sonra analiz edilebilir hale getirmek.
---
📁 Proje İçeriği
---
### **Gerekli Donanımlar:**
- Arduino Uno
- BMP280 sensörü
- Breadboard ve bağlantı kabloları

BMP280 sensörünü Arduino'ya bağlayın:
   - **VCC** → Arduino **3.3V**
   - **GND** → Arduino **GND**
   - **SCL** → Arduino **SCL (OR A5)**
   - **SDA** → Arduino **SDA (OR A4)**

![Devre görseli](https://github.com/user-attachments/assets/d7d11f02-f2f9-4099-adb9-27f984705f90)
[Arduino Uno Datasheet](https://github.com/user-attachments/files/18050024/A000066-datasheet.pdf)

### **Arduino IDE Kurulumu:**
[Arduino IDE](https://www.arduino.cc/en/software) indirin ve yükleyin.
Arduino'nuzu bilgisayarınıza bağlayın.
**Araçlar > Port** menüsünden doğru COM portunu seçin.
### **Gerekli Kütüphaneleri Yükleyin:**
**Adafruit_Sensor** ve **Adafruit_BMP280** kütüphanelerini yükleyin:
   - **Sketch > Include Library > Manage Libraries** menüsüne gidin.
   - **Adafruit_Sensor** ve **Adafruit_BMP280** kütüphanelerini aratıp yükleyin.

## **Arduino Kodunu Yükleme**
**Araçlar > Kart** menüsünden **Arduino Uno** seçin.
**Araçlar > Port** menüsünden Arduino'nuzun bağlı olduğu portu seçin.
**Yükle** butonuna tıklayarak kodu Arduino'ya yükleyin.

## Arduino Kodunun Açıklaması:
#### Adafruit_BMP280.h: Sensörü kontrol etmek için kullanılan kütüphane.
#### bmp.readTemperature(): Sıcaklık değerini okur.
#### bmp.readPressure(): Basınç değerini okur (Pascal olarak, hPa'ya çevrilir).
#### Serial.print() ve Serial.println(): Verileri seri port üzerinden gönderir.
#### System.IO.Ports: Seri port üzerinden iletişim için.
#### LiveCharts: Grafik çizimi için

### **Visual Studio Kurulumu:**
1. [Visual Studio](https://visualstudio.microsoft.com/) indirin ve kurun.
2. Yeni bir proje oluşturun:
   - **Windows Forms App (.NET Framework)** şablonunu seçin.

### **Gerekli NuGet Paketlerini Yükleyin:**
1. Tools > NuGet Package Manager > Manage NuGet Packages for Solution** seçeneğine gidin.
2. Aşağıdaki paketleri aratıp yükleyin:
   - System.IO.Ports
   - LiveCharts.WinForms

 Form Tasarımı için Toolbox'tan Label , Button , CartesianChart ( LiveCharts.WinForms > CartesianChart ) ekleyin.

##### Arduino'nuzun bağlı olduğu COM portunu kontrol edin ve C# kodundaki `PortName` değerini buna göre ayarlayın.
   ```csharp
   arduinoPort = new SerialPort
   {
       PortName = "COM5", // Arduino'nun bağlı olduğu port
       BaudRate = 9600
   };
   ```
##### Projeyi çalıştırıp "Start Reading" butonuna tıkladığınızda sıcaklık ve basınç değerlerini grafikte anlık olarak görebileceksiniz.

 [Video](https://github.com/user-attachments/assets/e434ce86-d4ad-497b-97ca-7ab0b9213ac5)


