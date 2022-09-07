using System;
using System.Windows.Forms;

namespace Winform_4_homework4
{
    public partial class FormActionFunc : Form
    {
        public FormActionFunc()
        {
            InitializeComponent();
        }

        private void FormActionFunc_Load(object sender, EventArgs e)
        {
        }

        decimal totalIncome = 0;
        decimal totalExpend = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Action actions = null;

            actions += () => this.labelShow.Text += "欢迎进入记账本系统！\n";

            actions += () =>
            {
                this.labelShow.Text += "请先登录系统，输入账号,密码；\n";
                //以下会卡线程
                string account = Console.ReadLine();
                string password = Console.ReadLine();
                this.labelShow.Text += $"账号：{account},密码：{password}；\n";
            };

            actions += () =>
            {
                this.labelShow.Text += "请添加名目信息\n";
            };

            actions += () =>
            {
                this.labelShow.Text += "请录入收入记录\n";
                //输入
                //添加到 totalIncome
                string income = Console.ReadLine();
                totalIncome += decimal.Parse(income);
                this.labelShow.Text += $"记录: {income}";
            };

            actions += () =>
            {
                this.labelShow.Text += "请录入支出记录\n";
                //输入
                //添加到totalExpend
                string expend = Console.ReadLine();
                totalExpend += decimal.Parse(expend);
                this.labelShow.Text += $"记录: {expend}";
            };

            actions.Invoke();

            Func<decimal> func = () =>
            {
                return totalIncome - totalExpend;
            };
            this.labelShow.Text += $"总收支 {func()}";
        }
    }
}
