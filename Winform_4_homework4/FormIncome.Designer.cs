namespace Winform_4_homework4
{
    partial class FormIncome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(104, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "名目名称:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(104, 95);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(35, 12);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "描述:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(104, 146);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(35, 12);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "金额:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(180, 38);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 3;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(180, 86);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(100, 21);
            this.textDescription.TabIndex = 4;
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(180, 137);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(100, 21);
            this.textAmount.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(106, 192);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "提交";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(104, 242);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 12);
            this.labelShow.TabIndex = 7;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(283, 197);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(47, 12);
            this.labelTotalAmount.TabIndex = 8;
            this.labelTotalAmount.Text = "总金额:";
            // 
            // FormIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Name = "FormIncome";
            this.Text = "FormIncome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label labelTotalAmount;
    }
}