using BaseLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_4_homework4.Base;

namespace Winform_4_homework4
{
    public partial class FormIncome : Form
    {
        public FormIncome()
        {
            InitializeComponent();
        }

        private void ResetValue()
        {
            this.textDescription.Text = "";
            this.textName.Text = "";
            this.textAmount.Text = "";
        }

        BaseAct<IncomeRecord> baseAct = new BaseAct<IncomeRecord>();
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string description = this.textDescription.Text.Trim();
            string name = this.textName.Text.Trim();
            decimal amount = decimal.Parse(this.textAmount.Text.Trim());

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Description", description);
            dict.Add("Name", name);
            dict.Add("Amount", amount);

            //根据字典创建实体类, 并添加到list
            IncomeRecord incomeRecord = baseAct.CreateInfo(dict);
            baseAct.Add(incomeRecord);
            {// 修改属性值
                baseAct.SetProp(incomeRecord, "Description", description);
                baseAct.SetProp(incomeRecord, "Amount", amount);
            }

            labelShow.Text += baseAct.GetInfo(incomeRecord);
            baseAct.CalTotalAmount(incomeRecord);
            labelTotalAmount.Text = ComUtility.TotalIncome.ToString("0.00");

            this.ResetValue();
        }
    }
}
