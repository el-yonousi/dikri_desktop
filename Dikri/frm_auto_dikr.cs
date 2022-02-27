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

namespace Dikri
{
    public partial class frm_auto_dikr : Form
    {
        // move the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);

        public frm_auto_dikr()
        {
            InitializeComponent();
        }

        private void lbl_dikr_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        List<Notification> notifications = new List<Notification>();
        private void frm_auto_dikr_Load(object sender, EventArgs e)
        {
            try
            {
                tmr_hide.Start();

                notifications = Notification.Upload(notifications);

                Random random = new Random();

                int num = random.Next(0, notifications.Count - 1);

                string[] splt = notifications[num].ToString().Split(',');
                btn_count.Text = string.Format("{0:D2}", splt[1]);
                lbl_dikr.Text = string.Format("{0}", splt[2]);
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        int num = 0;
        private void tmr_hide_Tick(object sender, EventArgs e)
        {
            num++;
            if (num == 60)
                this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            try
            {
                TotaleRead.Save(TotaleRead.Upload() + 1);

                btn_count.Text = (int.Parse(btn_count.Text) - 1).ToString("D2");

                if (btn_count.Text == "00")
                    this.Close();
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }
    }
}
