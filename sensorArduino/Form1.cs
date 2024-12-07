using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace sensorArduino
{
    public partial class Form1 : Form
    {
        SerialPort arduinoPort;

        private ChartValues<double> temperatureValues = new ChartValues<double>();
        private ChartValues<double> pressureValues = new ChartValues<double>();
        private int timeStep = 0;

        private String cvsFilePath = "sensor_data.csv";

        public Form1()
        {
            InitializeComponent();

            // Grafik yapılandırması
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Temperature (°C)",
                    Values = temperatureValues,
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Pressure (hPa)",
                    Values = pressureValues,
                    PointGeometry = null
                }
            };

            cartesianChart1.AxisX.Add(new Axis { Title = "Time", Labels = null });
            cartesianChart1.AxisY.Add(new Axis { Title = "Values" });

            arduinoPort = new SerialPort
            {
                PortName = "COM5", // Arduino'nun bağlı olduğu port
                BaudRate = 9600
            };

            arduinoPort.DataReceived += ArduinoPort_DataReceived;

            if (!(File.Exists(cvsFilePath)))
            {
                File.WriteAllText(cvsFilePath, " Time, Temperature, Pressure\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelStatus.Text = "Click 'Start Reading' to begin.";
        }

        private void ArduinoPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = arduinoPort.ReadLine();
                Invoke(new Action(() =>
                {
                    string[] values = data.Split(',');
                    if (values.Length == 2)
                    {
                        double temperature = double.Parse(values[0]);
                        double pressure = double.Parse(values[1]);

                        temperatureValues.Add(temperature);
                        pressureValues.Add(pressure);

                        timeStep++;


                        if (temperatureValues.Count > 100) temperatureValues.RemoveAt(0);
                        if (pressureValues.Count > 100) pressureValues.RemoveAt(0);


                        labelStatus.Text = $"Time: {timeStep} , Temperature: {temperature} °C, Pressure: {pressure} hPa";
                        
                        string cvsLine = $" {timeStep} , {temperature} , {pressure} \n";
                        File.AppendAllText(cvsFilePath,cvsLine);

                    }
                }));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    labelStatus.Text = $"Error: {ex.Message}";
                }));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduinoPort.IsOpen)
            {
                arduinoPort.Close();
            }
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            labelStatus.Text = "Graph structure updated.";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!arduinoPort.IsOpen)
                {
                    arduinoPort.Open();
                    labelStatus.Text = "Connection started. Reading data...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening port: {ex.Message}");
            }
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current Status: " + labelStatus.Text, "Label Clicked");
        }
    }
}
