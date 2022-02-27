using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikri
{
    public partial class usr_home : UserControl
    {
        public usr_home()
        {
            InitializeComponent();
        }

        private void usr_home_Load(object sender, EventArgs e)
        {
            tmr_clock.Start();

            lbl_total_count.Text = $"{TotaleRead.Upload()}";
        }

        private void tmr_clock_Tick(object sender, EventArgs e)
        {
            DateTime clock = DateTime.Now;
            lbl_time.Text = string.Format("{0:D2}:{1:D2}", clock.Hour, clock.Minute);
            lbl_time_sec.Text = string.Format("{0:D2}", clock.Second);
            lbl_to_long.Text = clock.ToLongDateString();
        }
    }
}
