namespace airport
{
    partial class AddAirport
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.shortNameTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.shortNameTxt);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.cityTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cityLbl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади аеродром";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(136, 176);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Откажи";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(21, 176);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Зачувај";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // shortNameTxt
            // 
            this.shortNameTxt.Location = new System.Drawing.Point(10, 137);
            this.shortNameTxt.Name = "shortNameTxt";
            this.shortNameTxt.Size = new System.Drawing.Size(73, 20);
            this.shortNameTxt.TabIndex = 3;
            this.shortNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.shortNameTxt_Validating);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(10, 89);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(224, 20);
            this.nameTxt.TabIndex = 2;
            this.nameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.nameTxt_Validating);
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(9, 42);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(225, 20);
            this.cityTxt.TabIndex = 1;
            this.cityTxt.Validating += new System.ComponentModel.CancelEventHandler(this.cityTxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кратенка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(7, 26);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(31, 13);
            this.cityLbl.TabIndex = 0;
            this.cityLbl.Text = "Град";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddAirport
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(277, 214);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAirport";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Нов аеродром";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox shortNameTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}