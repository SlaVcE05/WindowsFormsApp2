namespace airport
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
            this.airportsLB = new System.Windows.Forms.ListBox();
            this.destinationLB = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addDestinationBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.avrgDistanceTxt = new System.Windows.Forms.TextBox();
            this.mostExpTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aerportsLbl = new System.Windows.Forms.Label();
            this.destinationLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // airportsLB
            // 
            this.airportsLB.FormattingEnabled = true;
            this.airportsLB.Location = new System.Drawing.Point(20, 33);
            this.airportsLB.Name = "airportsLB";
            this.airportsLB.Size = new System.Drawing.Size(374, 329);
            this.airportsLB.TabIndex = 0;
            this.airportsLB.SelectedIndexChanged += new System.EventHandler(this.airportsLB_SelectedIndexChanged);
            // 
            // destinationLB
            // 
            this.destinationLB.FormattingEnabled = true;
            this.destinationLB.Location = new System.Drawing.Point(412, 33);
            this.destinationLB.Name = "destinationLB";
            this.destinationLB.Size = new System.Drawing.Size(376, 329);
            this.destinationLB.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(20, 379);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(374, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Додади аеродром";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(20, 415);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(374, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Избриши аеродром";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addDestinationBtn
            // 
            this.addDestinationBtn.Location = new System.Drawing.Point(20, 455);
            this.addDestinationBtn.Name = "addDestinationBtn";
            this.addDestinationBtn.Size = new System.Drawing.Size(374, 23);
            this.addDestinationBtn.TabIndex = 3;
            this.addDestinationBtn.Text = "Додади дестинација";
            this.addDestinationBtn.UseVisualStyleBackColor = true;
            this.addDestinationBtn.Click += new System.EventHandler(this.addDestinationBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.avrgDistanceTxt);
            this.groupBox1.Controls.Add(this.mostExpTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(412, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинација";
            // 
            // avrgDistanceTxt
            // 
            this.avrgDistanceTxt.Enabled = false;
            this.avrgDistanceTxt.Location = new System.Drawing.Point(9, 81);
            this.avrgDistanceTxt.Name = "avrgDistanceTxt";
            this.avrgDistanceTxt.Size = new System.Drawing.Size(347, 20);
            this.avrgDistanceTxt.TabIndex = 1;
            this.avrgDistanceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mostExpTxt
            // 
            this.mostExpTxt.Enabled = false;
            this.mostExpTxt.Location = new System.Drawing.Point(9, 36);
            this.mostExpTxt.Name = "mostExpTxt";
            this.mostExpTxt.Size = new System.Drawing.Size(347, 20);
            this.mostExpTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Просечна должина на дестинациите";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Најскапа дестинација";
            // 
            // aerportsLbl
            // 
            this.aerportsLbl.AutoSize = true;
            this.aerportsLbl.Location = new System.Drawing.Point(17, 17);
            this.aerportsLbl.Name = "aerportsLbl";
            this.aerportsLbl.Size = new System.Drawing.Size(64, 13);
            this.aerportsLbl.TabIndex = 5;
            this.aerportsLbl.Text = "Аеродроми";
            // 
            // destinationLbl
            // 
            this.destinationLbl.AutoSize = true;
            this.destinationLbl.Location = new System.Drawing.Point(409, 17);
            this.destinationLbl.Name = "destinationLbl";
            this.destinationLbl.Size = new System.Drawing.Size(69, 13);
            this.destinationLbl.TabIndex = 5;
            this.destinationLbl.Text = "Дестинации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.destinationLbl);
            this.Controls.Add(this.aerportsLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addDestinationBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.destinationLB);
            this.Controls.Add(this.airportsLB);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox airportsLB;
        private System.Windows.Forms.ListBox destinationLB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addDestinationBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label aerportsLbl;
        private System.Windows.Forms.Label destinationLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox avrgDistanceTxt;
        private System.Windows.Forms.TextBox mostExpTxt;
        private System.Windows.Forms.Label label2;
    }
}

