namespace WindowsFormsApp2
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
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemovePayments = new System.Windows.Forms.Button();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.lblSelectedStudent = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(12, 12);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(268, 342);
            this.lbStudents.TabIndex = 0;
            this.lbStudents.SelectedValueChanged += new System.EventHandler(this.lbStudents_SelectedValueChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 372);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(268, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Додади студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemovePayments
            // 
            this.btnRemovePayments.Location = new System.Drawing.Point(12, 415);
            this.btnRemovePayments.Name = "btnRemovePayments";
            this.btnRemovePayments.Size = new System.Drawing.Size(268, 23);
            this.btnRemovePayments.TabIndex = 2;
            this.btnRemovePayments.Text = "Избриши уплати";
            this.btnRemovePayments.UseVisualStyleBackColor = true;
            this.btnRemovePayments.Click += new System.EventHandler(this.btnRemovePayments_Click);
            // 
            // nudValue
            // 
            this.nudValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudValue.Location = new System.Drawing.Point(341, 12);
            this.nudValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(239, 20);
            this.nudValue.TabIndex = 3;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(341, 53);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(239, 23);
            this.btnAddPayment.TabIndex = 4;
            this.btnAddPayment.Text = "Додај уплата";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // lblSelectedStudent
            // 
            this.lblSelectedStudent.AutoSize = true;
            this.lblSelectedStudent.Location = new System.Drawing.Point(341, 97);
            this.lblSelectedStudent.Name = "lblSelectedStudent";
            this.lblSelectedStudent.Size = new System.Drawing.Size(209, 13);
            this.lblSelectedStudent.TabIndex = 6;
            this.lblSelectedStudent.Text = "Информации за селектираниот студент";
            // 
            // tbMax
            // 
            this.tbMax.Enabled = false;
            this.tbMax.Location = new System.Drawing.Point(341, 333);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(138, 20);
            this.tbMax.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 468);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.lblSelectedStudent);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.btnRemovePayments);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemovePayments;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Label lblSelectedStudent;
        private System.Windows.Forms.TextBox tbMax;
    }
}

