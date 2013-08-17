using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace BeamerMeister
{
    public partial class BeamerMeister : Form
    {
        readonly string m_portName;

        public BeamerMeister()
        {
            IntPtr handle = Handle;
            m_portName = findBeamerPort();
            if(m_portName == null)
            {
                MessageBox.Show("Beamer not found. Shutting down.");
                BeginInvoke((Action)Close);
                return;
            }
            
            InitializeComponent();
            wireButton(buttonComponent, "SOURCE", "10");
            wireButton(buttonHDMI1,     "SOURCE", "30");
            wireButton(buttonHDMI2,     "SOURCE", "A0");
            wireButton(buttonSVideo,    "SOURCE", "42");
            wireButton(buttonComposite, "SOURCE", "41");
            wireButton(buttonVGA,       "SOURCE", "20");
            wireButton(buttonTurnOn,    "PWR",    "ON");
            wireButton(buttonPowerOff,  "PWR",    "OFF");
            wireUpDown(numericUpDownBrightness, "BRIGHT");
            wireUpDown(numericUpDownContrast, "CONTRAST");
        }

        static string findBeamerPort()
        {
            return SerialPort.GetPortNames().FirstOrDefault(isBeamerPort);
        }

        static bool isBeamerPort(string portName)
        {
            try
            {
                using (SerialPort port = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One))
                {
                    port.Open();
                    port.Write("\r");
                    port.ReadTimeout = 500;
                    return port.ReadByte() == ':';
                }
            }
            catch (Exception e)
            {
                if (e is UnauthorizedAccessException || e is TimeoutException || e is IOException || e is InvalidOperationException || e is ObjectDisposedException)
                    return false;
                throw;
            }
        }

        void wireButton(Button button, string field, string value)
        {
            button.Click += delegate { setValue(field, value); };
        }

        void wireUpDown(NumericUpDown upDown, string command)
        {
            using (SerialPort port = new SerialPort(m_portName, 9600, Parity.None, 8, StopBits.One))
            {
                port.Open();
                port.DiscardInBuffer();
                port.Write(command + "?\r");
                port.NewLine = "\r";
                string reply = port.ReadLine();
                Match match = Regex.Match(reply, @"^.*=([0-9]+)$");
                if (match.Success)
                    upDown.Value = int.Parse(match.Groups[1].Value);
            }

            upDown.ValueChanged += delegate { setValue(command, ((int)upDown.Value).ToString()); };
        }

        void setValue(string field, string value)
        {
            bool oldEnabled = Enabled;
            Enabled = false;

            new Thread(_ =>
            {
                try
                {
                    using (SerialPort port = new SerialPort(m_portName, 9600, Parity.None, 8, StopBits.One))
                    {
                        port.Open();
                        port.Write(field + " " + value + "\r");
                        port.ReadTimeout = 30000;
                        port.NewLine = ":";
                        string reply = port.ReadLine();
                        if (reply != "")
                            MessageBox.Show(reply);
                    }
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("The Beamer did not respond. :-(");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Invoke((Action)delegate
                    {
                        Enabled = oldEnabled;
                    });
                }
            }).Start();
        }
    }
}
