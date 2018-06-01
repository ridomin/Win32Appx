using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace WinForms461
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAppInfo();
        }

        private void ShowAppInfo()
        {
            textBox1.Text = $"ImageRuntime: {Assembly.GetExecutingAssembly().ImageRuntimeVersion} {Environment.NewLine}";
            textBox1.Text += $"WinForms: {this.FormBorderStyle.GetType().Assembly.Location} {Environment.NewLine}";
            textBox1.Text += $"ThisApp: {Assembly.GetExecutingAssembly().Location} {Environment.NewLine}";
            textBox1.Text += $"Architecture: {GetArch()}{Environment.NewLine}";
            textBox1.Text += $"Uptime: {TimeSpan.FromMilliseconds(Environment.TickCount).Humanize()  }";
        }

        string GetArch()
        {
            return IntPtr.Size == 4 ? "x86" : "x64";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-es");
            ShowAppInfo();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-eu");
            ShowAppInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("it-it");
            ShowAppInfo();
        }
    }
}
