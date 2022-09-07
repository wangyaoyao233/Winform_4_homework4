using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_4_homework4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonItemInfo_Click(object sender, EventArgs e)
        {
            FormItemInfo formItemInfo =  new FormItemInfo();
            formItemInfo.Show();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            FormIncome formIncome = new FormIncome();
            formIncome.Show();
        }

        private void buttonExpend_Click(object sender, EventArgs e)
        {
            FormExpend formExpend = new FormExpend();
            formExpend.Show();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            FormActionFunc formActionFunc = new FormActionFunc();
            formActionFunc.Show();
        }
    }
}
