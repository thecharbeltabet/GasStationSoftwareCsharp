namespace CharbelTabet_OOD_Project2.Forms
{
    partial class IncomeForm
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
            this.IncomePureButton = new System.Windows.Forms.RadioButton();
            this.IncomewTaxesButton = new System.Windows.Forms.RadioButton();
            this.SalestextBox = new System.Windows.Forms.TextBox();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalIncomeLabel = new System.Windows.Forms.Label();
            this.IncomewExpensesButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.GobackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IncomePureButton
            // 
            this.IncomePureButton.AutoCheck = false;
            this.IncomePureButton.AutoSize = true;
            this.IncomePureButton.Checked = true;
            this.IncomePureButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomePureButton.Location = new System.Drawing.Point(50, 295);
            this.IncomePureButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IncomePureButton.Name = "IncomePureButton";
            this.IncomePureButton.Size = new System.Drawing.Size(260, 52);
            this.IncomePureButton.TabIndex = 0;
            this.IncomePureButton.TabStop = true;
            this.IncomePureButton.Text = "Pure Income:";
            this.IncomePureButton.UseVisualStyleBackColor = true;
            // 
            // IncomewTaxesButton
            // 
            this.IncomewTaxesButton.AutoSize = true;
            this.IncomewTaxesButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomewTaxesButton.Location = new System.Drawing.Point(50, 406);
            this.IncomewTaxesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IncomewTaxesButton.Name = "IncomewTaxesButton";
            this.IncomewTaxesButton.Size = new System.Drawing.Size(318, 52);
            this.IncomewTaxesButton.TabIndex = 2;
            this.IncomewTaxesButton.TabStop = true;
            this.IncomewTaxesButton.Text = "Income With Tax:";
            this.IncomewTaxesButton.UseVisualStyleBackColor = true;
            // 
            // SalestextBox
            // 
            this.SalestextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalestextBox.Location = new System.Drawing.Point(399, 157);
            this.SalestextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalestextBox.Name = "SalestextBox";
            this.SalestextBox.Size = new System.Drawing.Size(332, 56);
            this.SalestextBox.TabIndex = 4;
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLabel.Location = new System.Drawing.Point(201, 157);
            this.SalesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(155, 65);
            this.SalesLabel.TabIndex = 5;
            this.SalesLabel.Text = "Sales:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(105, 689);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(526, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 58);
            this.label2.TabIndex = 7;
            this.label2.Text = "Income:";
            // 
            // TotalIncomeLabel
            // 
            this.TotalIncomeLabel.AutoSize = true;
            this.TotalIncomeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalIncomeLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIncomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalIncomeLabel.Location = new System.Drawing.Point(289, 689);
            this.TotalIncomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalIncomeLabel.Name = "TotalIncomeLabel";
            this.TotalIncomeLabel.Size = new System.Drawing.Size(79, 58);
            this.TotalIncomeLabel.TabIndex = 8;
            this.TotalIncomeLabel.Text = "NA";
            // 
            // IncomewExpensesButton
            // 
            this.IncomewExpensesButton.AutoSize = true;
            this.IncomewExpensesButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomewExpensesButton.Location = new System.Drawing.Point(50, 529);
            this.IncomewExpensesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IncomewExpensesButton.Name = "IncomewExpensesButton";
            this.IncomewExpensesButton.Size = new System.Drawing.Size(417, 52);
            this.IncomewExpensesButton.TabIndex = 9;
            this.IncomewExpensesButton.TabStop = true;
            this.IncomewExpensesButton.Text = "Income With Expenses:";
            this.IncomewExpensesButton.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculateButton.Location = new System.Drawing.Point(536, 397);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(319, 61);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // GobackButton
            // 
            this.GobackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GobackButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GobackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GobackButton.Location = new System.Drawing.Point(536, 685);
            this.GobackButton.Margin = new System.Windows.Forms.Padding(2);
            this.GobackButton.Name = "GobackButton";
            this.GobackButton.Size = new System.Drawing.Size(319, 62);
            this.GobackButton.TabIndex = 11;
            this.GobackButton.Text = "Go Back";
            this.GobackButton.UseVisualStyleBackColor = false;
            this.GobackButton.Click += new System.EventHandler(this.GobackButton_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1109, 846);
            this.Controls.Add(this.GobackButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.IncomewExpensesButton);
            this.Controls.Add(this.TotalIncomeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesLabel);
            this.Controls.Add(this.SalestextBox);
            this.Controls.Add(this.IncomewTaxesButton);
            this.Controls.Add(this.IncomePureButton);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton IncomePureButton;
        private System.Windows.Forms.RadioButton IncomewTaxesButton;
        private System.Windows.Forms.TextBox SalestextBox;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalIncomeLabel;
        private System.Windows.Forms.RadioButton IncomewExpensesButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button GobackButton;
    }
}