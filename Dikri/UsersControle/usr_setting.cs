using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikri
{
    public partial class usr_setting : UserControl
    {
        public usr_setting()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("setting.txt"))
                {
                    sw.Write($"{nmrc_period.Value},{ck_notification.Checked}");
                    sw.Close();
                }
                MessageBox.Show("تم حفظ الإعدادات، المرجوا إعادة تشغيل البرنامج", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
            //Environment.Exit(0);
            //Application.Restart();
        }

        private void usr_setting_Load(object sender, EventArgs e)
        {
            try
            {
                string setting = "";
                using (StreamReader sr = new StreamReader("setting.txt"))
                {
                    setting = sr.ReadLine();
                    sr.Close();
                }

                nmrc_period.Value = int.Parse(setting.Split(',')[0]);
                ck_notification.Checked = bool.Parse(setting.Split(',')[1]);
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }
    }
}
