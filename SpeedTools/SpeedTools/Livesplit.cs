using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SpeedTools
{
    public partial class Livesplit : Form
    {
        #region Variables
        ProcessStartInfo pythonInfo = new ProcessStartInfo();
        Process python;
        string port = "16834";
        string pypath = "C:\\Python27\\python.exe";
        string portpath = "C:\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools-Python\\livesplitport.txt";
        #endregion
        public Livesplit()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, EventArgs e) {
            this.Hide();
            var Inf = new Main();
            Inf.Closed += (s, args) => this.Close();
            Inf.Show();
        }
        private void button1_Click(object sender, EventArgs e) {
            #region File Management
            System.Threading.Thread.Sleep(10);
            if (!File.Exists(portpath))
            {
                string port = toolStripTextBox1.Text;
                File.WriteAllText(portpath, port);
            }
            #endregion
            // Start Timer
            pythonInfo.Arguments = @"C:\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools-Python\\start.py";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;
            richTextBox1.Text = "Timer Starting\r\n";
            python = Process.Start(pythonInfo);
            python.WaitForExit();
            python.Close();
        }
        private void button3_Click(object sender, EventArgs e) {
            // Split
            pythonInfo.Arguments = @"C:\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools-Python\\split.py";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;
            richTextBox1.Text = "Timer Starting\r\n";
            python = Process.Start(pythonInfo);
            python.WaitForExit();
            python.Close();
        }
        private void button2_Click(object sender, EventArgs e) {
            // Unsplit
            pythonInfo.Arguments = @"C:\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools-Python\\unsplit.py";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;
            richTextBox1.Text = "Timer Starting\r\n";
            python = Process.Start(pythonInfo);
            python.WaitForExit();
            python.Close();
        }
        private void button4_Click(object sender, EventArgs e) {
            // Skip Split
            pythonInfo.Arguments = @"C:\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools-Python\\skipsplit.py";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;
            richTextBox1.Text = "Timer Starting\r\n";
            python = Process.Start(pythonInfo);
            python.WaitForExit();
            python.Close();
        }
        private void button5_Click(object sender, EventArgs e) {
            // Pause
            pythonInfo.Arguments = @"C:\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools-Python\\pause.py";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;
            richTextBox1.Text = "Timer Starting\r\n";
            python = Process.Start(pythonInfo);
            python.WaitForExit();
            python.Close();
        }
        private void button7_Click(object sender, EventArgs e) {
            // Resume
            pythonInfo.Arguments = @"C:\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools-Python\\skipsplit.py";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;
            richTextBox1.Text = "Timer Starting\r\n";
            python = Process.Start(pythonInfo);
            python.WaitForExit();
            python.Close();
        }
        private void button6_Click(object sender, EventArgs e) {
            // Reset
            pythonInfo.Arguments = @"C:\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools\\SpeedTools-Python\\reset.py";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;
            richTextBox1.Text = "Timer Starting\r\n";
            python = Process.Start(pythonInfo);
            python.WaitForExit();
            python.Close();
        }
        private void button8_Click(object sender, EventArgs e) {
            // Port Menu
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
        }
        private void Livesplit_Load(object sender, EventArgs e)
        {
            pythonInfo.FileName = @"C:\Python27\python.exe";
        }
    }
}
