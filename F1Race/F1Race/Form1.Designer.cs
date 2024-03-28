namespace F1Race
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addDriverBtn = new System.Windows.Forms.Button();
            this.deleteDriver = new System.Windows.Forms.Button();
            this.driversLB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bestLapTxt = new System.Windows.Forms.TextBox();
            this.addLapBtn = new System.Windows.Forms.Button();
            this.timeNum = new System.Windows.Forms.NumericUpDown();
            this.secNum = new System.Windows.Forms.NumericUpDown();
            this.minNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lapsLB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.addDriverBtn);
            this.groupBox1.Controls.Add(this.deleteDriver);
            this.groupBox1.Controls.Add(this.driversLB);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возачи";
            // 
            // addDriverBtn
            // 
            this.addDriverBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addDriverBtn.Location = new System.Drawing.Point(3, 378);
            this.addDriverBtn.Name = "addDriverBtn";
            this.addDriverBtn.Size = new System.Drawing.Size(187, 43);
            this.addDriverBtn.TabIndex = 1;
            this.addDriverBtn.Text = "Додади возач";
            this.addDriverBtn.UseVisualStyleBackColor = true;
            this.addDriverBtn.Click += new System.EventHandler(this.addDriverBtn_Click);
            // 
            // deleteDriver
            // 
            this.deleteDriver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteDriver.Location = new System.Drawing.Point(3, 421);
            this.deleteDriver.Name = "deleteDriver";
            this.deleteDriver.Size = new System.Drawing.Size(187, 43);
            this.deleteDriver.TabIndex = 1;
            this.deleteDriver.Text = "Избриши возач";
            this.deleteDriver.UseVisualStyleBackColor = true;
            this.deleteDriver.Click += new System.EventHandler(this.deleteDriver_Click);
            // 
            // driversLB
            // 
            this.driversLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.driversLB.FormattingEnabled = true;
            this.driversLB.Location = new System.Drawing.Point(3, 16);
            this.driversLB.Margin = new System.Windows.Forms.Padding(4);
            this.driversLB.Name = "driversLB";
            this.driversLB.Size = new System.Drawing.Size(187, 355);
            this.driversLB.TabIndex = 0;
            this.driversLB.SelectedIndexChanged += new System.EventHandler(this.driversLB_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bestLapTxt);
            this.groupBox2.Controls.Add(this.addLapBtn);
            this.groupBox2.Controls.Add(this.timeNum);
            this.groupBox2.Controls.Add(this.secNum);
            this.groupBox2.Controls.Add(this.minNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lapsLB);
            this.groupBox2.Location = new System.Drawing.Point(212, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 467);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кругови";
            // 
            // bestLapTxt
            // 
            this.bestLapTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bestLapTxt.Enabled = false;
            this.bestLapTxt.Location = new System.Drawing.Point(7, 393);
            this.bestLapTxt.Name = "bestLapTxt";
            this.bestLapTxt.Size = new System.Drawing.Size(385, 20);
            this.bestLapTxt.TabIndex = 4;
            // 
            // addLapBtn
            // 
            this.addLapBtn.Location = new System.Drawing.Point(262, 344);
            this.addLapBtn.Name = "addLapBtn";
            this.addLapBtn.Size = new System.Drawing.Size(130, 23);
            this.addLapBtn.TabIndex = 3;
            this.addLapBtn.Text = "Додади круг";
            this.addLapBtn.UseVisualStyleBackColor = true;
            this.addLapBtn.Click += new System.EventHandler(this.addLapBtn_Click);
            // 
            // timeNum
            // 
            this.timeNum.Location = new System.Drawing.Point(7, 437);
            this.timeNum.Name = "timeNum";
            this.timeNum.Size = new System.Drawing.Size(120, 20);
            this.timeNum.TabIndex = 2;
            this.timeNum.ValueChanged += new System.EventHandler(this.timeNum_ValueChanged);
            // 
            // secNum
            // 
            this.secNum.Location = new System.Drawing.Point(136, 346);
            this.secNum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.secNum.Name = "secNum";
            this.secNum.Size = new System.Drawing.Size(120, 20);
            this.secNum.TabIndex = 2;
            this.secNum.ValueChanged += new System.EventHandler(this.secNum_ValueChanged);
            // 
            // minNum
            // 
            this.minNum.Location = new System.Drawing.Point(10, 347);
            this.minNum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minNum.Name = "minNum";
            this.minNum.Size = new System.Drawing.Size(120, 20);
            this.minNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Секунди";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Минути";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Време";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Најдобар  круг";
            // 
            // lapsLB
            // 
            this.lapsLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lapsLB.FormattingEnabled = true;
            this.lapsLB.Location = new System.Drawing.Point(3, 16);
            this.lapsLB.Name = "lapsLB";
            this.lapsLB.Size = new System.Drawing.Size(392, 303);
            this.lapsLB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addDriverBtn;
        private System.Windows.Forms.Button deleteDriver;
        private System.Windows.Forms.ListBox driversLB;
        private System.Windows.Forms.NumericUpDown minNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lapsLB;
        private System.Windows.Forms.Button addLapBtn;
        private System.Windows.Forms.NumericUpDown secNum;
        private System.Windows.Forms.TextBox bestLapTxt;
        private System.Windows.Forms.NumericUpDown timeNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

