namespace Busses
{
    partial class Form1
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
            this.addBusBtn = new System.Windows.Forms.Button();
            this.deleteBusBtn = new System.Windows.Forms.Button();
            this.addLineBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expLineTxt = new System.Windows.Forms.TextBox();
            this.avrgPriceTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bussesLB = new System.Windows.Forms.ListBox();
            this.linesLB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBusBtn
            // 
            this.addBusBtn.Location = new System.Drawing.Point(25, 307);
            this.addBusBtn.Name = "addBusBtn";
            this.addBusBtn.Size = new System.Drawing.Size(310, 23);
            this.addBusBtn.TabIndex = 1;
            this.addBusBtn.Text = "Додоади автобус";
            this.addBusBtn.UseVisualStyleBackColor = true;
            this.addBusBtn.Click += new System.EventHandler(this.addBusBtn_Click);
            // 
            // deleteBusBtn
            // 
            this.deleteBusBtn.Location = new System.Drawing.Point(25, 345);
            this.deleteBusBtn.Name = "deleteBusBtn";
            this.deleteBusBtn.Size = new System.Drawing.Size(310, 23);
            this.deleteBusBtn.TabIndex = 1;
            this.deleteBusBtn.Text = "Избриши автобус";
            this.deleteBusBtn.UseVisualStyleBackColor = true;
            this.deleteBusBtn.Click += new System.EventHandler(this.deleteBusBtn_Click);
            // 
            // addLineBtn
            // 
            this.addLineBtn.Location = new System.Drawing.Point(25, 387);
            this.addLineBtn.Name = "addLineBtn";
            this.addLineBtn.Size = new System.Drawing.Size(310, 23);
            this.addLineBtn.TabIndex = 1;
            this.addLineBtn.Text = "Додади линија";
            this.addLineBtn.UseVisualStyleBackColor = true;
            this.addLineBtn.Click += new System.EventHandler(this.addLineBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.avrgPriceTxt);
            this.groupBox1.Controls.Add(this.expLineTxt);
            this.groupBox1.Location = new System.Drawing.Point(424, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Линии";
            // 
            // expLineTxt
            // 
            this.expLineTxt.Enabled = false;
            this.expLineTxt.Location = new System.Drawing.Point(8, 32);
            this.expLineTxt.Name = "expLineTxt";
            this.expLineTxt.Size = new System.Drawing.Size(319, 20);
            this.expLineTxt.TabIndex = 0;
            // 
            // avrgPriceTxt
            // 
            this.avrgPriceTxt.Enabled = false;
            this.avrgPriceTxt.Location = new System.Drawing.Point(8, 89);
            this.avrgPriceTxt.Name = "avrgPriceTxt";
            this.avrgPriceTxt.Size = new System.Drawing.Size(315, 20);
            this.avrgPriceTxt.TabIndex = 1;
            this.avrgPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Автобуси";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Линии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "најскапа линија";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Просечна цена на линиите";
            // 
            // bussesLB
            // 
            this.bussesLB.FormattingEnabled = true;
            this.bussesLB.Location = new System.Drawing.Point(27, 39);
            this.bussesLB.Name = "bussesLB";
            this.bussesLB.Size = new System.Drawing.Size(353, 238);
            this.bussesLB.TabIndex = 5;
            this.bussesLB.SelectedValueChanged += new System.EventHandler(this.bussesLB_SelectedValueChanged);
            // 
            // linesLB
            // 
            this.linesLB.FormattingEnabled = true;
            this.linesLB.Location = new System.Drawing.Point(409, 40);
            this.linesLB.Name = "linesLB";
            this.linesLB.Size = new System.Drawing.Size(354, 238);
            this.linesLB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linesLB);
            this.Controls.Add(this.bussesLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addLineBtn);
            this.Controls.Add(this.deleteBusBtn);
            this.Controls.Add(this.addBusBtn);
            this.Name = "Form1";
            this.Text = "Абтобуси";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBusBtn;
        private System.Windows.Forms.Button deleteBusBtn;
        private System.Windows.Forms.Button addLineBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox avrgPriceTxt;
        private System.Windows.Forms.TextBox expLineTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox bussesLB;
        private System.Windows.Forms.ListBox linesLB;
    }
}

