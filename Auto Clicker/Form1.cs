using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Auto_Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        int msDelay = 0;
        int secDelay = 0;
        int minDelay = 0;
        bool is_Started = false;
        int totalDelay = 0;
        int LEFTDOWN = 0x0002;
        int LEFTUP = 0x0004;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            is_Started= true;   
        }

        private async void AutoClickerDelay()
        {
            totalDelay = msDelay + secDelay + minDelay;
            do
            {
                await Task.Delay(totalDelay);
                mouse_event(LEFTDOWN, 0, 0, 0, 0);
                mouse_event(LEFTUP, 0, 0, 0, 0);
            } while (is_Started == true && totalDelay != 0);

            if(totalDelay == 0)
            {
                MessageBox.Show("Please enter a time for me to delay between clicks");
            }
        }

        private void msDelayTXT_TextChanged(object sender, EventArgs e)
        {
            msDelay = int.Parse(msDelayTXT.Text);
        }

        private void secDelayTXT_TextChanged(object sender, EventArgs e)
        {
            secDelay = int.Parse(secDelayTXT.Text) * 1000;
        }

        private void minDelayTXT_TextChanged(object sender, EventArgs e)
        {
            minDelay = int.Parse(minDelayTXT.Text) * 60000;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Q))
            {
                Application.Exit();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
