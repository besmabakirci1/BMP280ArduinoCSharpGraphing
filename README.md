# Graphing BMP280-Arduino-CSharp

Arduino Kodunun Açıklaması:
Adafruit_BMP280.h: Sensörü kontrol etmek için kullanılan kütüphane.
bmp.readTemperature(): Sıcaklık değerini okur.
bmp.readPressure(): Basınç değerini okur (Pascal olarak, hPa'ya çevrilir).
Serial.print() ve Serial.println(): Verileri seri port üzerinden gönderir.
Gerekli NuGet Paketleri:
System.IO.Ports: Seri port üzerinden iletişim için.
LiveCharts: Grafik çizimi için


# BMP280-Arduino-CSharp-Graphing

Bu proje, BMP280 sensöründen alınan sıcaklık ve basınç verilerini Arduino üzerinden okuyup, C# uygulamasında grafikleştirmeyi amaçlar.

## Gereksinimler
- **Arduino Uno**
- **BMP280 Sensörü**
- **Visual Studio (C# Uygulaması için)**

Visual Studio:

Projeyi oluşturmak için Visual Studio'yu kurulu olduğundan emin olun.
Windows Forms App (.NET Framework) seçeneğiyle yeni bir proje oluşturun.
LiveCharts Kütüphanesini Yükleyin:

Visual Studio’da Tools > NuGet Package Manager > Manage NuGet Packages for Solution seçeneğine gidin.
Arama kutusuna LiveCharts.WinForms yazın.
LiveCharts.WinForms kütüphanesini yükleyin.
Arduino IDE:

Arduino IDE'yi indirin ve kurun.
Gerekli kütüphaneleri yüklemek için Adafruit_Sensor ve Adafruit_BMP280 kütüphanelerini ekleyin:
Sketch > Include Library > Manage Libraries menüsüne gidin.
Bu kütüphaneleri aratıp yükleyin.

Arduino’nuzun bağlı olduğu COM portunu kontrol edin:
Araçlar > Port menüsünden Arduino'nuzun bağlı olduğu COM portunu öğrenin.

Form Tasarımını Yapın
Label Ekleyin:

Toolbox’tan bir Label ekleyin.
Özelliklerini şu şekilde ayarlayın:
Name: labelStatus
Text: Click 'Start Reading' to begin.
Button Ekleyin:

Toolbox’tan bir Button ekleyin.
Özelliklerini şu şekilde ayarlayın:
Name: buttonStart
Text: Start Reading
CartesianChart Ekleyin:

Toolbox’ta LiveCharts.WinForms > CartesianChart kontrolünü bulun.
Form üzerine ekleyin.
Özelliklerini şu şekilde ayarlayın:
Name: cartesianChart1

 **C# Uygulamasını Çalıştırma:**
   - `CSharp_App` klasörünü açın.
   - NuGet bağımlılıklarını yükleyin.
   - Uygulamayı çalıştırın.
   - 
### Devre Şeması:
VCC pinini Arduino'nun 3.3V pinine bağlayın.
GND pinini Arduino'nun GND pinine bağlayın.
SCL pinini Arduino'nun SCL veya A5 pinine bağlayın.
SDA pinini Arduino'nun SDA veya A4 pinine bağlayın.
![Devre görseli](https://github.com/user-attachments/assets/d7d11f02-f2f9-4099-adb9-27f984705f90)
[Arduino Uno Datasheet](https://github.com/user-attachments/files/18050024/A000066-datasheet.pdf)
[Video](https://github.com/user-attachments/assets/e434ce86-d4ad-497b-97ca-7ab0b9213ac5)





# **Graphing BMP280-Arduino-CSharp Roadmap**

Bu roadmap, BMP280 sensöründen alınan verilerin Arduino ile okunup, C# uygulamasında grafikleştirilmesini adım adım anlatır. Proje boyunca temel yazılım, donanım bağlantıları ve grafik oluşturma süreçlerini içerir. Projeyi hiç bilmeyen birinin kolayca takip edebilmesi hedeflenmiştir.

---

## **Donanımı Hazırlama**

### **Gerekli Donanımlar:**
- Arduino Uno
- BMP280 sensörü
- Breadboard ve bağlantı kabloları

### **Bağlantı Şeması:**
1. BMP280 sensörünü Arduino'ya bağlayın:
   - **VCC** → Arduino **3.3V**
   - **GND** → Arduino **GND**
   - **SCL** → Arduino **SCL (A5)**
   - **SDA** → Arduino **SDA (A4)**

2. Bağlantıların doğru olduğundan emin olun ve aşağıdaki şema ile karşılaştırın:
   ![Devre görseli](https://github.com/user-attachments/assets/d7d11f02-f2f9-4099-adb9-27f984705f90)

---

## **Arduino IDE'yi Hazırlama**

### **Arduino IDE Kurulumu:**
[Arduino IDE](https://www.arduino.cc/en/software) indirin ve yükleyin.
Arduino'nuzu bilgisayarınıza bağlayın.
**Araçlar > Port** menüsünden doğru COM portunu seçin.

### **Gerekli Kütüphaneleri Yükleyin:**
**Adafruit_Sensor** ve **Adafruit_BMP280** kütüphanelerini yükleyin:
   - **Sketch > Include Library > Manage Libraries** menüsüne gidin.
   - **Adafruit_Sensor** ve **Adafruit_BMP280** kütüphanelerini aratıp yükleyin.

---

## **Arduino Kodunu Yükleme**
**Araçlar > Kart** menüsünden **Arduino Uno** seçin.
**Araçlar > Port** menüsünden Arduino'nuzun bağlı olduğu portu seçin.
**Yükle** butonuna tıklayarak kodu Arduino'ya yükleyin.

---

## **Adım 4: C# Uygulamasını Hazırlama**

### **Visual Studio Kurulumu:**
1. [Visual Studio](https://visualstudio.microsoft.com/) indirin ve kurun.
2. Yeni bir proje oluşturun:
   - **Windows Forms App (.NET Framework)** şablonunu seçin.

### **Gerekli NuGet Paketlerini Yükleyin:**
1. **Tools > NuGet Package Manager > Manage NuGet Packages for Solution** seçeneğine gidin.
2. Aşağıdaki paketleri aratıp yükleyin:
   - **System.IO.Ports**
   - **LiveCharts.WinForms**

---

## **Adım 5: Form Tasarımını Yapın**

1. **Label Ekleyin:**
   - **Name:** `labelStatus`
   - **Text:** `Click 'Start Reading' to begin.`

2. **Button Ekleyin:**
   - **Name:** `buttonStart`
   - **Text:** `Start Reading`

3. **CartesianChart Ekleyin:**
   - Toolbox'tan **LiveCharts.WinForms > CartesianChart** kontrolünü bulun.
   - Formunuza ekleyin.
   - **Name:** `cartesianChart1`

---

## **Adım 6: C# Uygulamasını Çalıştırma**

1. Arduino'nuzun bağlı olduğu COM portunu kontrol edin ve C# kodundaki `PortName` değerini buna göre ayarlayın.
   ```csharp
   arduinoPort = new SerialPort
   {
       PortName = "COM5", // Arduino'nun bağlı olduğu port
       BaudRate = 9600
   };
   ```
Projeyi çalıştırıp "Start Reading" butonuna tıkladığınızda sıcaklık ve basınç değerlerini grafikte anlık olarak görebileceksiniz.

---

## **Adım 7: Çıktı Analizi**

1. **Grafik Çıktısı**:
   - CartesianChart üzerinde sıcaklık ve basınç değerlerini gerçek zamanlı olarak görselleştirin.

2. **Verilerin Kaydedilmesi (Opsiyonel)**:
   - Verileri bir CSV dosyasına kaydedebilirsiniz. Bunu C# uygulamasında ek bir özellik olarak dahil edin:
     - Her veri alındığında bir satır ekleyerek CSV formatında kaydedin.

---
## **Kaynaklar**
- [Arduino IDE](https://www.arduino.cc/en/software)
- [LiveCharts](https://lvcharts.com/)
- [Adafruit BMP280 Documentation](https://learn.adafruit.com/adafruit-bmp280-barometric-pressure-plus-temperature-sensor/overview)

---

### **Video Rehberi**
[Video İzlemek İçin Tıklayın](https://github.com/user-attachments/assets/e434ce86-d4ad-497b-97ca-7ab0b9213ac5)


