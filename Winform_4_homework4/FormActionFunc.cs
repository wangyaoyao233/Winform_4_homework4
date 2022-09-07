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
            Action action1 = () => this.labelShow.Text += "欢迎进入记账本系统！\n";
            action1.Invoke();

            Action action2 = () =>
            {
                this.labelShow.Text += "请先登录系统，输入账号：XXX,密码：XXXXXX；\n";
                //以下会卡线程
                string account = Console.ReadLine();
                string password = Console.ReadLine();
                this.labelShow.Text += $"账号：{account},密码：{password}；\n";
            };
            action2.Invoke();

            Action action3 = () =>
            {
                this.labelShow.Text += "请添加名目信息\n";
            };
            action3.Invoke();

            Action action4 = () =>
            {
                this.labelShow.Text += "请录入收入记录\n";
                //输入
                //添加到 totalIncome
            };

            Action action5 = () =>
            {
                this.labelShow.Text += "请录入支出记录\n";
                //输入
                //添加到totalExpend
            };

            Func<decimal> func = () =>
            {
                return totalIncome - totalExpend;
            };
            this.labelShow.Text += $"总收支 {func()}";
        }
    }
}
