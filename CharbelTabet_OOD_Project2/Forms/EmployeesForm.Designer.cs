namespace CharbelTabet_OOD_Project2.Forms
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.EmployeeImage = new System.Windows.Forms.PictureBox();
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.DeductButton = new System.Windows.Forms.Button();
            this.BonusButton = new System.Windows.Forms.Button();
            this.SalaryLabelFill = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.FullNameLabelFill = new System.Windows.Forms.Label();
            this.TypeLabelFill = new System.Windows.Forms.Label();
            this.EmpAgeFillLabel = new System.Windows.Forms.Label();
            this.SSNFillLabel = new System.Windows.Forms.Label();
            this.RegNumberLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.CarLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.EmployeesListBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesListBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.ItemHeight = 72;
            this.EmployeesListBox.Location = new System.Drawing.Point(34, 38);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(573, 436);
            this.EmployeesListBox.TabIndex = 1;
            this.EmployeesListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EmployeesListBox_MouseClick);
            // 
            // EmployeeImage
            // 
            this.EmployeeImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmployeeImage.BackgroundImage")));
            this.EmployeeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmployeeImage.Location = new System.Drawing.Point(728, 38);
            this.EmployeeImage.Name = "EmployeeImage";
            this.EmployeeImage.Size = new System.Drawing.Size(179, 166);
            this.EmployeeImage.TabIndex = 3;
            this.EmployeeImage.TabStop = false;
            // 
            // InputTextbox
            // 
            this.InputTextbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.InputTextbox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.InputTextbox.Location = new System.Drawing.Point(578, 591);
            this.InputTextbox.MaxLength = 10;
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(410, 64);
            this.InputTextbox.TabIndex = 24;
            // 
            // DeductButton
            // 
            this.DeductButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.DeductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeductButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeductButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeductButton.Location = new System.Drawing.Point(578, 859);
            this.DeductButton.Name = "DeductButton";
            this.DeductButton.Size = new System.Drawing.Size(410, 73);
            this.DeductButton.TabIndex = 23;
            this.DeductButton.Text = "Deduct";
            this.DeductButton.UseVisualStyleBackColor = false;
            this.DeductButton.Click += new System.EventHandler(this.DeductButton_Click);
            // 
            // BonusButton
            // 
            this.BonusButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.BonusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BonusButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonusButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BonusButton.Location = new System.Drawing.Point(578, 731);
            this.BonusButton.Name = "BonusButton";
            this.BonusButton.Size = new System.Drawing.Size(410, 75);
            this.BonusButton.TabIndex = 22;
            this.BonusButton.Text = "Add Bonus";
            this.BonusButton.UseVisualStyleBackColor = false;
            this.BonusButton.Click += new System.EventHandler(this.BonusButton_Click);
            // 
            // SalaryLabelFill
            // 
            this.SalaryLabelFill.AutoSize = true;
            this.SalaryLabelFill.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryLabelFill.Location = new System.Drawing.Point(325, 731);
            this.SalaryLabelFill.Name = "SalaryLabelFill";
            this.SalaryLabelFill.Size = new System.Drawing.Size(86, 64);
            this.SalaryLabelFill.TabIndex = 21;
            this.SalaryLabelFill.Text = "NA";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(108, 731);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(163, 64);
            this.BalanceLabel.TabIndex = 20;
            this.BalanceLabel.Text = "Salary";
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.GoBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GoBackButton.Location = new System.Drawing.Point(261, 990);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(520, 98);
            this.GoBackButton.TabIndex = 19;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // FullNameLabelFill
            // 
            this.FullNameLabelFill.AutoSize = true;
            this.FullNameLabelFill.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabelFill.Location = new System.Drawing.Point(870, 260);
            this.FullNameLabelFill.Name = "FullNameLabelFill";
            this.FullNameLabelFill.Size = new System.Drawing.Size(56, 41);
            this.FullNameLabelFill.TabIndex = 32;
            this.FullNameLabelFill.Text = "NA";
            // 
            // TypeLabelFill
            // 
            this.TypeLabelFill.AutoSize = true;
            this.TypeLabelFill.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabelFill.Location = new System.Drawing.Point(870, 338);
            this.TypeLabelFill.Name = "TypeLabelFill";
            this.TypeLabelFill.Size = new System.Drawing.Size(56, 41);
            this.TypeLabelFill.TabIndex = 31;
            this.TypeLabelFill.Text = "NA";
            // 
            // EmpAgeFillLabel
            // 
            this.EmpAgeFillLabel.AutoSize = true;
            this.EmpAgeFillLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAgeFillLabel.Location = new System.Drawing.Point(870, 411);
            this.EmpAgeFillLabel.Name = "EmpAgeFillLabel";
            this.EmpAgeFillLabel.Size = new System.Drawing.Size(56, 41);
            this.EmpAgeFillLabel.TabIndex = 30;
            this.EmpAgeFillLabel.Text = "NA";
            // 
            // SSNFillLabel
            // 
            this.SSNFillLabel.AutoSize = true;
            this.SSNFillLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNFillLabel.Location = new System.Drawing.Point(870, 485);
            this.SSNFillLabel.Name = "SSNFillLabel";
            this.SSNFillLabel.Size = new System.Drawing.Size(56, 41);
            this.SSNFillLabel.TabIndex = 29;
            this.SSNFillLabel.Text = "NA";
            // 
            // RegNumberLabel
            // 
            this.RegNumberLabel.AutoSize = true;
            this.RegNumberLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNumberLabel.Location = new System.Drawing.Point(452, 485);
            this.RegNumberLabel.Name = "RegNumberLabel";
            this.RegNumberLabel.Size = new System.Drawing.Size(337, 41);
            this.RegNumberLabel.TabIndex = 28;
            this.RegNumberLabel.Text = "Social Security Number:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(711, 411);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(75, 41);
            this.AgeLabel.TabIndex = 27;
            this.AgeLabel.Text = "Age:";
            // 
            // CarLabel
            // 
            this.CarLabel.AutoSize = true;
            this.CarLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarLabel.Location = new System.Drawing.Point(711, 338);
            this.CarLabel.Name = "CarLabel";
            this.CarLabel.Size = new System.Drawing.Size(78, 41);
            this.CarLabel.TabIndex = 26;
            this.CarLabel.Text = "Type";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(631, 271);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(158, 41);
            this.FullNameLabel.TabIndex = 25;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1073, 1123);
            this.Controls.Add(this.FullNameLabelFill);
            this.Controls.Add(this.TypeLabelFill);
            this.Controls.Add(this.EmpAgeFillLabel);
            this.Controls.Add(this.SSNFillLabel);
            this.Controls.Add(this.RegNumberLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.CarLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.InputTextbox);
            this.Controls.Add(this.DeductButton);
            this.Controls.Add(this.BonusButton);
            this.Controls.Add(this.SalaryLabelFill);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.EmployeeImage);
            this.Controls.Add(this.EmployeesListBox);
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.PictureBox EmployeeImage;
        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.Button DeductButton;
        private System.Windows.Forms.Button BonusButton;
        private System.Windows.Forms.Label SalaryLabelFill;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label FullNameLabelFill;
        private System.Windows.Forms.Label TypeLabelFill;
        private System.Windows.Forms.Label EmpAgeFillLabel;
        private System.Windows.Forms.Label SSNFillLabel;
        private System.Windows.Forms.Label RegNumberLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label CarLabel;
        private System.Windows.Forms.Label FullNameLabel;
    }
}