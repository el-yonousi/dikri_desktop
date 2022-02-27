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
    public partial class frm_add_dikr : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);

        List<WakeUp> wakeUps = new List<WakeUp>();
        List<Morning> mornings = new List<Morning>();
        List<Evening> evnings = new List<Evening>();
        List<Sleep> sleeps = new List<Sleep>();
        List<Notification> notifications = new List<Notification>();

        public frm_add_dikr()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void clearFileds()
        {
            txt_number.Text = (Convert.ToInt32(txt_number.Text) + 1).ToString();
            txt_repeat.Clear();
            txt_dikr.Clear();
            txt_repeat.Focus();
        }

        private void frm_add_dikr_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_List.Items.Add("أذكار الإستيقاظ");
                cmb_List.Items.Add("أذكار الصباح");
                cmb_List.Items.Add("أذكار المساء");
                cmb_List.Items.Add("أذكار النوم");
                cmb_List.Items.Add("الإشعارات");
                cmb_List.SelectedIndex = 0;

                if (cmb_List.SelectedIndex == 0)
                {
                    wakeUps = WakeUp.Upload(wakeUps);
                    txt_number.Text = (wakeUps.Count + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDikr_Click(object sender, EventArgs e)
        {
            if (txt_repeat.Text == string.Empty)
            {
                MessageBox.Show("لم تدخل عدد التكرار", "انتبه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_repeat.Focus();
                return;
            }
            if (txt_dikr.Text == string.Empty)
            {
                MessageBox.Show("لم تدخل الذِّكر", "انتبه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dikr.Focus();
                return;
            }

            switch (cmb_List.SelectedIndex)
            {
                case 0:
                    wakeUps.Add(new WakeUp(Convert.ToInt32(txt_number.Text), Int32.Parse(txt_repeat.Text), txt_dikr.Text));
                    WakeUp wakeUp = new WakeUp();
                    wakeUp.Save(wakeUps);
                    clearFileds();
                    break;
                case 1:
                    mornings.Add(new Morning(Convert.ToInt32(txt_number.Text), Int32.Parse(txt_repeat.Text), txt_dikr.Text));
                    Morning morning = new Morning();
                    morning.Save(mornings);
                    clearFileds();
                    break;
                case 2:
                    evnings.Add(new Evening(Convert.ToInt32(txt_number.Text), Int32.Parse(txt_repeat.Text), txt_dikr.Text));
                    Evening evning = new Evening();
                    evning.Save(evnings);
                    clearFileds();
                    break;
                case 3:
                    sleeps.Add(new Sleep(Convert.ToInt32(txt_number.Text), Int32.Parse(txt_repeat.Text), txt_dikr.Text));
                    Sleep sleep = new Sleep();
                    sleep.Save(sleeps);
                    clearFileds();
                    break;
                case 4:
                    notifications.Add(new Notification(Convert.ToInt32(txt_number.Text), Int32.Parse(txt_repeat.Text), txt_dikr.Text));
                    Notification notification = new Notification();
                    notification.Save(notifications);
                    clearFileds();
                    break;
            }
        }

        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_List.SelectedIndex == 0)
                {
                    wakeUps = WakeUp.Upload(wakeUps);
                    txt_number.Text = (wakeUps.Count + 1).ToString();
                }
                if (cmb_List.SelectedIndex == 1)
                {
                    mornings = Morning.Upload(mornings);
                    txt_number.Text = (mornings.Count + 1).ToString();
                }
                if (cmb_List.SelectedIndex == 2)
                {
                    evnings = Evening.Upload(evnings);
                    txt_number.Text = (evnings.Count + 1).ToString();
                }
                if (cmb_List.SelectedIndex == 3)
                {
                    sleeps = Sleep.Upload(sleeps);
                    txt_number.Text = (sleeps.Count + 1).ToString();
                }
                if (cmb_List.SelectedIndex == 4)
                {
                    notifications = Notification.Upload(notifications);
                    txt_number.Text = (notifications.Count + 1).ToString();
                }
            }
            catch(Exception ex) 
            {
                LogFile.Message(ex);
            }
        }

        private void txtRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); /*function*/
            SendMessage(this.Handle, 0x112, 0xf012, 0);  /*function*/
        }
    }
}
