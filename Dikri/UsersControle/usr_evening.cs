﻿using System;
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
    public partial class usr_evening : UserControl
    {
        public usr_evening()
        {
            InitializeComponent();
        }

        /// <summary>
        /// repeat count
        /// </summary>
        /// <param name="Count"></param>
        private void Repeat(Button Count)
        {
            Count.Text = string.Format("{0:00}", Int32.Parse(Count.Tag.ToString()));

        }

        List<Evening> evenings = new List<Evening>();
        private void usr_evening_Load(object sender, EventArgs e)
        {
            try
            {
                evenings = Evening.Upload(evenings);

                string[] splt = evenings[0].ToString().Split(',');
                lbl_number.Text = $"{int.Parse(splt[0]).ToString("D2")}:{Program.dikrNumber}";
                btn_count.Text = $"{int.Parse(splt[1]).ToString("D2")}";
                btn_count.Tag = $"{int.Parse(splt[1]).ToString("D2")}";
                lbl_dikr.Text = splt[2];
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(lbl_number.Text.Split(':')[0]);
                if (num == evenings.Count)
                    return;

                string lst = string.Format("{0}", evenings[num]);
                string[] splt = lst.Split(',');
                lbl_number.Text = $"{int.Parse(splt[0]).ToString("D2")}:{Program.dikrNumber}";
                btn_count.Text = $"{int.Parse(splt[1]).ToString("D2")}";
                btn_count.Tag = $"{int.Parse(splt[1]).ToString("D2")}";
                lbl_dikr.Text = splt[2];
                num += 1;
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            try
            {
                int numLeft = Convert.ToInt32(lbl_number.Text.Split(':')[0]) - 1;
                if (numLeft == 0)
                    return;
                numLeft -= 1;

                string lst = string.Format("{0}", evenings[numLeft]);
                string[] splt = lst.Split(',');
                lbl_number.Text = $"{int.Parse(splt[0]).ToString("D2")}:{Program.dikrNumber}";
                btn_count.Text = $"{int.Parse(splt[1]).ToString("D2")}";
                btn_count.Tag = $"{int.Parse(splt[1]).ToString("D2")}";
                lbl_dikr.Text = splt[2];
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(btn_count.Text) == 0)
                    return;

                TotaleRead.Save(TotaleRead.Upload() + 1);

                btn_count.Text = (int.Parse(btn_count.Text) - 1).ToString("D2");

                if (btn_count.Text == "00")
                    btn_next.PerformClick();
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btn_repeat_Click(object sender, EventArgs e)
        {
            Repeat(btn_count);
        }
    }
}
