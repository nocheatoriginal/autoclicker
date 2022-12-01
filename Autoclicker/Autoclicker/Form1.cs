using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Autoclicker
{
    public partial class Form1 : Form
    {
        #region dll's
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration
        #endregion

        public static ImageKeyConverter Key;
        int randomisedCPS;
        Random rndm;
        Keys hotkey;
        bool enabled;
        bool darkmode;
        string version;

        public Form1()
        {
            InitializeComponent();
            version = "v.1.0.1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rndm = new Random();
            button_Start.Text = "Start";

            darkmode = true;
            darkMode(this);

            enabled = false;
            cb_Toggle.ForeColor = Color.Red;

            label_credits.Text += " - " + version;
            this.Text += " - " + version;
        }

        private void darkMode(Form1 sender)
        {
            sender.ForeColor = Color.FromArgb(201, 209, 217);
            sender.BackColor = Color.FromArgb(13, 17, 23);
        }

        private void brightMode(Form1 sender)
        {
            sender.ForeColor = Color.FromArgb(36, 41, 47);
            sender.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void tb_cps_Scroll(object sender, EventArgs e)
        {
            l_cps.Text = $"CPS: {tb_cps.Value}";
        }

        private void RightClicker_Tick(object sender, EventArgs e)
        {
            RightClicker.Interval = 1000 / tb_cps.Value;

            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process item in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, item.MainWindowTitle))
                {
                    if (!cb_Toggle.Checked)
                    {
                        return;
                    }
                    // MouseButtons.XButton1 = Maustaste 4 (Die hintere extra Taste ...)

                    if (rb_Rightclick.Checked) // Rechtklick
                    {
                        if (MouseButtons == MouseButtons.Right) // MouseButtons.Right
                        {
                            SendMessage(GetForegroundWindow(), 0x204, 0, 0);
                            Task.Delay(20).Wait();
                            SendMessage(GetForegroundWindow(), 0x203, 0, 0);
                        }
                    }
                    else // Linksklick
                    {
                        if (MouseButtons == MouseButtons.Left) // MouseButtons.Left
                        {
                            SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                            Task.Delay(20).Wait();
                            SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                        }
                    }
                }
            }
        }

        private void Random_Tick(object sender, EventArgs e)
        {
            randomisedCPS = rndm.Next(tb_cps.Value - 3, tb_cps.Value + 3);
        }

        private void b_Hotkey_Click(object sender, EventArgs e)
        {
            b_Hotkey.Text = "...";
        }

        private void b_Hotkey_KeyUp(object sender, KeyEventArgs e)
        {
            if (b_Hotkey.Text != "...")
            {
                return;
            }
            if (e.KeyCode == Keys.Escape) //(GetAsyncKeyState(Keys.Escape) < 0)
            {
                b_Hotkey.Text = "none";
            }
            else
            {
                hotkey = e.KeyCode;
                b_Hotkey.Text = hotkey.ToString();
                
            }
        }

        private void Bind_Tick(object sender, EventArgs e)
        {
            if (!enabled)
            {
                return;
            }

            if(b_Hotkey.Text != "none" && b_Hotkey.Text != "..." && hotkey != Keys.None)
            {
                //Keys key = (Keys)Key.ConvertFromString(b_Hotkey.Text);

                if (GetAsyncKeyState(hotkey) < 0)
                {
                    cb_Toggle.Checked = !cb_Toggle.Checked;
                }
            }
        }

        private void l_cps_Click(object sender, EventArgs e)
        {
            if (!textBox_CPS.Visible)
            {
                textBox_CPS.Visible = true;
            }
            else
            {
                textBox_CPS.Visible = false;
                int cps = 0;
                try
                {
                    cps = Convert.ToInt32(textBox_CPS.Text);
                }
                catch (Exception)
                {
                    textBox_CPS.Text = "";
                    return;
                }

                if (cps >= 1 && cps <= 18)
                {
                    l_cps.Text = "CPS: " + cps;
                    tb_cps.Value = cps;
                    textBox_CPS.Text = "";
                }
                else
                {
                    textBox_CPS.Text = "";
                }
            }
        }

        private void rb_Leftclick_Click(object sender, EventArgs e)
        {
            rb_Leftclick.Checked = true;
            rb_Rightclick.Checked = false;
        }

        private void rb_Rightclick_Click(object sender, EventArgs e)
        {
            rb_Rightclick.Checked = true;
            rb_Leftclick.Checked = false;

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text == "Start")
            {
                enabled = true;
                button_Start.Text = "Stop";
            }
            else
            {
                enabled = false;
                button_Start.Text = "Start";
                cb_Toggle.Checked = false;
            }
        }

        private void cb_Toggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!enabled)
            {
                cb_Toggle.Checked = false;
            }

            if (cb_Toggle.Checked)
            {
                cb_Toggle.ForeColor = Color.Green;
            }
            else
            {
                cb_Toggle.ForeColor = Color.Red;
            }
        }

        private void textBox_CPS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_CPS.Visible = false;
                int cps = 0;
                try
                {
                    cps = Convert.ToInt32(textBox_CPS.Text);
                }
                catch (Exception)
                {
                    textBox_CPS.Text = "";
                    return;
                }

                if (cps >= 1 && cps <= 18)
                {
                    l_cps.Text = "CPS: " + cps;
                    tb_cps.Value = cps;
                    textBox_CPS.Text = "";
                }
            }
        }

        private void textBox_CPS_TextChanged(object sender, EventArgs e)
        {
            int cps = 0;
            try
            {
                cps = Convert.ToInt32(textBox_CPS.Text);
            }
            catch (Exception)
            {
                textBox_CPS.ForeColor = Color.Red;
                textBox_CPS.Text = "";
                return;
            }

            if (cps >= 1 && cps <= 18)
            {
                textBox_CPS.ForeColor = Color.Green;
            }
            else
            {
                textBox_CPS.ForeColor = Color.Red;
            }
        }

        private void label_credits_Click(object sender, EventArgs e)
        {
            if (darkmode)
            {
                darkmode = false;
                brightMode(this);
            }
            else
            {
                darkmode = true;
                darkMode(this);
            }
        }
    }
}
