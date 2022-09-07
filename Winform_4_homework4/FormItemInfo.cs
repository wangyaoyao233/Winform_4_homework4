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
    public partial class FormItemInfo : Form
    {
        public FormItemInfo()
        {
            InitializeComponent();
        }

        private void ResetValue()
        {
            this.textId.Text = "";
            this.textName.Text = "";
            this.textType.Text = "";
        }

        BaseAct<ItemInfo> baseAct = new BaseAct<ItemInfo>();
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string type = this.textType.Text.Trim();
            string name = this.textName.Text.Trim();
            int id = int.Parse(this.textId.Text.Trim());

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Type", type);
            dict.Add("Name", name);
            dict.Add("Id", id);

            //根据字典创建实体类, 并添加到list
            ItemInfo itemInfo = baseAct.CreateInfo(dict);
            baseAct.Add(itemInfo);

            labelShow.Text += baseAct.GetInfo(itemInfo);
            labelNum.Text = $"名目数量: {baseAct.ListCnt}";//名目数量即list的实体数量

            this.ResetValue();
        }
    }
}
