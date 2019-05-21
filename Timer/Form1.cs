using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace Timer
{
    public partial class Form1 : Form
    {
        int CountOrgNum = 0;

        private bool IntCheck()
        {
            if (Information.IsNumeric(this.txtNum.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("숫자를 입력하세요~", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (IntCheck())
            {
                CountOrgNum = Convert.ToInt32(this.txtNum.Text);
                this.Timer.Enabled = true;
                this.txtNum.ReadOnly = true;
            }
            else
            {
                this.txtNum.Text = "";
                this.txtNum.Focus();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                this.txtNum.ReadOnly = false;
                this.txtNum.Text = "";
                MessageBox.Show("펑!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.CountOrgNum--;
                this.txtCountDown.Text = Convert.ToString(this.CountOrgNum);
            }
        }
    }
}
