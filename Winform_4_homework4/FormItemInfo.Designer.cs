namespace Winform_4_homework4
{
    partial class FormItemInfo
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
            this.labelShow = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.textType = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(102, 250);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 12);
            this.labelShow.TabIndex = 15;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(104, 200);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 14;
            this.buttonSubmit.Text = "提交";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(178, 145);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 13;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(178, 94);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 21);
            this.textId.TabIndex = 12;
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(178, 46);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(100, 21);
            this.textType.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(102, 154);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 12);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "名目名称:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(102, 103);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(59, 12);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "名目编号:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(102, 55);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(59, 12);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "名目类型:";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(420, 250);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(59, 12);
            this.labelNum.TabIndex = 16;
            this.labelNum.Text = "名目数量:";
            // 
            // FormItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelType);
            this.Name = "FormItemInfo";
            this.Text = "FormItemInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelNum;
    }
}