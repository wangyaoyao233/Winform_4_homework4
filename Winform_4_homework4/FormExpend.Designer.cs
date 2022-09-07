namespace Winform_4_homework4
{
    partial class FormExpend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpend));
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textNum = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTotalAmount
            // 
            resources.ApplyResources(this.labelTotalAmount, "labelTotalAmount");
            this.labelTotalAmount.Name = "labelTotalAmount";
            // 
            // labelShow
            // 
            resources.ApplyResources(this.labelShow, "labelShow");
            this.labelShow.Name = "labelShow";
            // 
            // buttonSubmit
            // 
            resources.ApplyResources(this.buttonSubmit, "buttonSubmit");
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textNum
            // 
            resources.ApplyResources(this.textNum, "textNum");
            this.textNum.Name = "textNum";
            // 
            // textDescription
            // 
            resources.ApplyResources(this.textDescription, "textDescription");
            this.textDescription.Name = "textDescription";
            // 
            // textName
            // 
            resources.ApplyResources(this.textName, "textName");
            this.textName.Name = "textName";
            // 
            // labelNum
            // 
            resources.ApplyResources(this.labelNum, "labelNum");
            this.labelNum.Name = "labelNum";
            // 
            // labelDescription
            // 
            resources.ApplyResources(this.labelDescription, "labelDescription");
            this.labelDescription.Name = "labelDescription";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // labelPrice
            // 
            resources.ApplyResources(this.labelPrice, "labelPrice");
            this.labelPrice.Name = "labelPrice";
            // 
            // textPrice
            // 
            resources.ApplyResources(this.textPrice, "textPrice");
            this.textPrice.Name = "textPrice";
            // 
            // labelAmount
            // 
            resources.ApplyResources(this.labelAmount, "labelAmount");
            this.labelAmount.Name = "labelAmount";
            // 
            // textAmount
            // 
            resources.ApplyResources(this.textAmount, "textAmount");
            this.textAmount.Name = "textAmount";
            // 
            // FormExpend
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Name = "FormExpend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textAmount;
    }
}