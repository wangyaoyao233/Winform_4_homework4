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
    public partial class FormExpend : Form
    {
        public FormExpend()
        {
            InitializeComponent();
        }

        private void ResetValue()
        {
            this.textDescription.Text = "";
            this.textName.Text = "";
            this.textNum.Text = "";
            this.textPrice.Text = "";
        }

        /// <summary>
        /// 定义委托
        /// </summary>
        /// <param name="info"></param>
        delegate void ShowExpend(ExpendRecord info);

        BaseAct<ExpendRecord> baseAct = new BaseAct<ExpendRecord>();
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = this.textName.Text.Trim();
            string description = this.textDescription.Text.Trim();
            int num = int.Parse(this.textNum.Text.Trim());
            decimal price = decimal.Parse(this.textPrice.Text.Trim());
            decimal amount = num * price;

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Name", name);
            dict.Add("Description", description);
            dict.Add("Amount", amount);
            dict.Add("Num", num);
            dict.Add("Price", price);

            //根据字典创建实体类, 并添加到list
            ExpendRecord expendRecord = baseAct.CreateInfo(dict);
            baseAct.Add(expendRecord);

            //生成委托并调用
            new ShowExpend((ExpendRecord info) =>
            {
                this.labelShow.Text += baseAct.GetInfo(info);
            }).Invoke(expendRecord);

            baseAct.CalTotalAmount(expendRecord);
            this.labelTotalAmount.Text = $"总金额: {ComUtility.TotalExpend.ToString("0.00")}";
            this.textAmount.Text = amount.ToString("0.00");

            this.ResetValue();
        }
    }
}
