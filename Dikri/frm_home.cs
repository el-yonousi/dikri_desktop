using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikri
{
    public partial class frm_home : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);

        private const string dikrNumber = "رقم الذكر";

        /// <summary>
        /// to change backColor of button click
        /// </summary>
        private Button currentButton;
        private Panel leftBorderButton;

        private bool notification;
        private int second;

        public frm_home()
        {
            InitializeComponent();

            // initialize
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(10, 79);
            pnl_right_side_bar.Controls.Add(leftBorderButton);

            // hide controle box
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();

                // button active
                currentButton = (Button)sender;
                currentButton.BackColor = Color.FromArgb(45, 45, 45);
                currentButton.ForeColor = Color.White;

                //left border
                leftBorderButton.BackColor = Color.White;
                leftBorderButton.Location = new Point(239, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                // button active
                currentButton.BackColor = Color.FromArgb(31, 31, 31);
                leftBorderButton.Visible = false;
            }
        }

        private void Repeat(Button Count)
        {
            Count.Text = string.Format("{0:00}", Int32.Parse(Count.Tag.ToString()));
        }
        /*end method*/

        private void pnl_header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); /*function*/
            SendMessage(this.Handle, 0x112, 0xf012, 0);  /*function*/
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //TotaleRead.TotalCount = Program.count;
            //TotaleRead.Save(TotaleRead.TotalCount);

            if (notification)
                this.Hide();
            else
                Environment.Exit(0);
        }

        private void btn_maximise_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btn_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string setting = "";
                using (StreamReader sr = new StreamReader("setting.txt"))
                {
                    setting = sr.ReadLine();
                    sr.Close();
                }

                second = int.Parse(setting.Split(',')[0]) * 60;
                notification = bool.Parse(setting.Split(',')[1]);

                if (notification)
                    tmr_auto_dikr.Start();
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }

            btn_home.PerformClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TotaleRead.TotalCount = Program.count;
            //TotaleRead.Save(TotaleRead.TotalCount);

            if (notification)
                this.Hide();
            else
                Environment.Exit(0);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            pnl_container.Controls.Clear();
            usr_home hm = new usr_home();
            hm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(hm);
            pnl_container.BringToFront();
        }

        /*start WakeUp*/
        private void btn_wake_up_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            pnl_container.Controls.Clear();
            usr_wake_up wp = new usr_wake_up();
            wp.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(wp);
            pnl_container.BringToFront();
        }

        private void btn_morning_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            pnl_container.Controls.Clear();
            usr_morning ev = new usr_morning();
            ev.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(ev);
            ev.BringToFront();
        }

        private void btn_evening_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            pnl_container.Controls.Clear();
            usr_evening ev = new usr_evening();
            ev.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(ev);
            ev.BringToFront();
        }

        private void btn_sleep_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            pnl_container.Controls.Clear();
            usr_sleep sp = new usr_sleep();
            sp.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(sp);
            pnl_container.BringToFront();
        }

        private void btn_add_dikr_Click(object sender, EventArgs e)
        {
            frm_add_dikr form = new frm_add_dikr();
            form.ShowDialog();
        }

        int sec = 0;
        private void tmr_auto_dikr_Tick(object sender, EventArgs e)
        {

            if (notification)
            {
                sec++;
                if (sec == second)
                {
                    sec = 0;
                    frm_auto_dikr dikr = new frm_auto_dikr();
                    dikr.Show();
                }
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            pnl_container.Controls.Clear();
            usr_setting usr = new usr_setting();
            usr.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(usr);
            usr.BringToFront();
        }
    }
}
