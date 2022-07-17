namespace CharbelTabet_OOD_Project2.Forms
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.ClientsListBox = new System.Windows.Forms.ListBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ClientImage = new System.Windows.Forms.PictureBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.CarLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.RegNumberLabel = new System.Windows.Forms.Label();
            this.RegNumLabelfill = new System.Windows.Forms.Label();
            this.agelabelfill = new System.Windows.Forms.Label();
            this.CarLabelFill = new System.Windows.Forms.Label();
            this.FullNameLabelFill = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BalanceLabelFill = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.Fillbutton = new System.Windows.Forms.Button();
            this.TankFilledTextbox = new System.Windows.Forms.TextBox();
            this.LitersFilledTextBox = new System.Windows.Forms.TextBox();
            this.AmountFilledTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsListBox
            // 
            this.ClientsListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientsListBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsListBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientsListBox.FormattingEnabled = true;
            this.ClientsListBox.ItemHeight = 72;
            this.ClientsListBox.Location = new System.Drawing.Point(12, 35);
            this.ClientsListBox.Name = "ClientsListBox";
            this.ClientsListBox.Size = new System.Drawing.Size(364, 436);
            this.ClientsListBox.TabIndex = 0;
            this.ClientsListBox.Click += new System.EventHandler(this.ClientsListBox_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.GoBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GoBackButton.Location = new System.Drawing.Point(544, 1049);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(520, 98);
            this.GoBackButton.TabIndex = 1;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ClientImage
            // 
            this.ClientImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClientImage.BackgroundImage")));
            this.ClientImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientImage.Location = new System.Drawing.Point(714, 35);
            this.ClientImage.Name = "ClientImage";
            this.ClientImage.Size = new System.Drawing.Size(179, 166);
            this.ClientImage.TabIndex = 2;
            this.ClientImage.TabStop = false;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(537, 271);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(158, 41);
            this.FullNameLabel.TabIndex = 3;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // CarLabel
            // 
            this.CarLabel.AutoSize = true;
            this.CarLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarLabel.Location = new System.Drawing.Point(625, 338);
            this.CarLabel.Name = "CarLabel";
            this.CarLabel.Size = new System.Drawing.Size(70, 41);
            this.CarLabel.TabIndex = 4;
            this.CarLabel.Text = "Car:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(625, 411);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(75, 41);
            this.AgeLabel.TabIndex = 5;
            this.AgeLabel.Text = "Age:";
            // 
            // RegNumberLabel
            // 
            this.RegNumberLabel.AutoSize = true;
            this.RegNumberLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNumberLabel.Location = new System.Drawing.Point(396, 485);
            this.RegNumberLabel.Name = "RegNumberLabel";
            this.RegNumberLabel.Size = new System.Drawing.Size(299, 41);
            this.RegNumberLabel.TabIndex = 6;
            this.RegNumberLabel.Text = "Registration Number:";
            // 
            // RegNumLabelfill
            // 
            this.RegNumLabelfill.AutoSize = true;
            this.RegNumLabelfill.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNumLabelfill.Location = new System.Drawing.Point(784, 485);
            this.RegNumLabelfill.Name = "RegNumLabelfill";
            this.RegNumLabelfill.Size = new System.Drawing.Size(56, 41);
            this.RegNumLabelfill.TabIndex = 9;
            this.RegNumLabelfill.Text = "NA";
            // 
            // agelabelfill
            // 
            this.agelabelfill.AutoSize = true;
            this.agelabelfill.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelabelfill.Location = new System.Drawing.Point(784, 411);
            this.agelabelfill.Name = "agelabelfill";
            this.agelabelfill.Size = new System.Drawing.Size(56, 41);
            this.agelabelfill.TabIndex = 10;
            this.agelabelfill.Text = "NA";
            // 
            // CarLabelFill
            // 
            this.CarLabelFill.AutoSize = true;
            this.CarLabelFill.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarLabelFill.Location = new System.Drawing.Point(784, 338);
            this.CarLabelFill.Name = "CarLabelFill";
            this.CarLabelFill.Size = new System.Drawing.Size(56, 41);
            this.CarLabelFill.TabIndex = 11;
            this.CarLabelFill.Text = "NA";
            // 
            // FullNameLabelFill
            // 
            this.FullNameLabelFill.AutoSize = true;
            this.FullNameLabelFill.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabelFill.Location = new System.Drawing.Point(784, 271);
            this.FullNameLabelFill.Name = "FullNameLabelFill";
            this.FullNameLabelFill.Size = new System.Drawing.Size(56, 41);
            this.FullNameLabelFill.TabIndex = 12;
            this.FullNameLabelFill.Text = "NA";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(43, 748);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(203, 64);
            this.BalanceLabel.TabIndex = 14;
            this.BalanceLabel.Text = "Balance:";
            // 
            // BalanceLabelFill
            // 
            this.BalanceLabelFill.AutoSize = true;
            this.BalanceLabelFill.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabelFill.Location = new System.Drawing.Point(277, 748);
            this.BalanceLabelFill.Name = "BalanceLabelFill";
            this.BalanceLabelFill.Size = new System.Drawing.Size(86, 64);
            this.BalanceLabelFill.TabIndex = 15;
            this.BalanceLabelFill.Text = "NA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(483, 745);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 75);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Amount";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(483, 873);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(410, 73);
            this.button2.TabIndex = 17;
            this.button2.Text = "Receive Payment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputTextbox
            // 
            this.InputTextbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.InputTextbox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.InputTextbox.Location = new System.Drawing.Point(483, 612);
            this.InputTextbox.MaxLength = 10;
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(410, 64);
            this.InputTextbox.TabIndex = 18;
            this.InputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Fillbutton
            // 
            this.Fillbutton.BackColor = System.Drawing.SystemColors.MenuText;
            this.Fillbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fillbutton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fillbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fillbutton.Location = new System.Drawing.Point(1006, 792);
            this.Fillbutton.Name = "Fillbutton";
            this.Fillbutton.Size = new System.Drawing.Size(410, 75);
            this.Fillbutton.TabIndex = 19;
            this.Fillbutton.Text = "Fill Gasoline";
            this.Fillbutton.UseVisualStyleBackColor = false;
            this.Fillbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // TankFilledTextbox
            // 
            this.TankFilledTextbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TankFilledTextbox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TankFilledTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.TankFilledTextbox.Location = new System.Drawing.Point(1277, 579);
            this.TankFilledTextbox.MaxLength = 1;
            this.TankFilledTextbox.Name = "TankFilledTextbox";
            this.TankFilledTextbox.Size = new System.Drawing.Size(139, 64);
            this.TankFilledTextbox.TabIndex = 20;
            this.TankFilledTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LitersFilledTextBox
            // 
            this.LitersFilledTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LitersFilledTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LitersFilledTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LitersFilledTextBox.Location = new System.Drawing.Point(1277, 680);
            this.LitersFilledTextBox.MaxLength = 2;
            this.LitersFilledTextBox.Name = "LitersFilledTextBox";
            this.LitersFilledTextBox.Size = new System.Drawing.Size(139, 64);
            this.LitersFilledTextBox.TabIndex = 21;
            this.LitersFilledTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AmountFilledTextBox
            // 
            this.AmountFilledTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AmountFilledTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountFilledTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.AmountFilledTextBox.Location = new System.Drawing.Point(1277, 479);
            this.AmountFilledTextBox.MaxLength = 3;
            this.AmountFilledTextBox.Name = "AmountFilledTextBox";
            this.AmountFilledTextBox.Size = new System.Drawing.Size(139, 64);
            this.AmountFilledTextBox.TabIndex = 22;
            this.AmountFilledTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(999, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 41);
            this.label1.TabIndex = 23;
            this.label1.Text = "Amount Filled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(999, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 41);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tank Filled From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(999, 697);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 41);
            this.label3.TabIndex = 25;
            this.label3.Text = "Liters Filled";
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1478, 1169);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountFilledTextBox);
            this.Controls.Add(this.LitersFilledTextBox);
            this.Controls.Add(this.TankFilledTextbox);
            this.Controls.Add(this.Fillbutton);
            this.Controls.Add(this.InputTextbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BalanceLabelFill);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.FullNameLabelFill);
            this.Controls.Add(this.CarLabelFill);
            this.Controls.Add(this.agelabelfill);
            this.Controls.Add(this.RegNumLabelfill);
            this.Controls.Add(this.RegNumberLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.CarLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.ClientImage);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.ClientsListBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ClientsListBox;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.PictureBox ClientImage;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label CarLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label RegNumberLabel;
        private System.Windows.Forms.Label RegNumLabelfill;
        private System.Windows.Forms.Label agelabelfill;
        private System.Windows.Forms.Label CarLabelFill;
        private System.Windows.Forms.Label FullNameLabelFill;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label BalanceLabelFill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.Button Fillbutton;
        private System.Windows.Forms.TextBox TankFilledTextbox;
        private System.Windows.Forms.TextBox LitersFilledTextBox;
        private System.Windows.Forms.TextBox AmountFilledTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}