namespace CharbelTabet_OOD_Project2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginAvatar = new System.Windows.Forms.PictureBox();
            this.UsernameEntry = new System.Windows.Forms.TextBox();
            this.PasswordEntry = new System.Windows.Forms.TextBox();
            this.LoginUsername = new System.Windows.Forms.Label();
            this.LoginPassword = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginCheckBox = new System.Windows.Forms.CheckBox();
            this.ChangecredButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DevelopedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginAvatar
            // 
            this.LoginAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginAvatar.BackgroundImage")));
            this.LoginAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginAvatar.Location = new System.Drawing.Point(658, 57);
            this.LoginAvatar.Name = "LoginAvatar";
            this.LoginAvatar.Size = new System.Drawing.Size(286, 254);
            this.LoginAvatar.TabIndex = 0;
            this.LoginAvatar.TabStop = false;
            // 
            // UsernameEntry
            // 
            this.UsernameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsernameEntry.Location = new System.Drawing.Point(658, 450);
            this.UsernameEntry.Name = "UsernameEntry";
            this.UsernameEntry.Size = new System.Drawing.Size(286, 53);
            this.UsernameEntry.TabIndex = 1;
            // 
            // PasswordEntry
            // 
            this.PasswordEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordEntry.Location = new System.Drawing.Point(658, 555);
            this.PasswordEntry.MaxLength = 10;
            this.PasswordEntry.Name = "PasswordEntry";
            this.PasswordEntry.PasswordChar = '*';
            this.PasswordEntry.Size = new System.Drawing.Size(286, 53);
            this.PasswordEntry.TabIndex = 2;
            // 
            // LoginUsername
            // 
            this.LoginUsername.AutoSize = true;
            this.LoginUsername.BackColor = System.Drawing.Color.DarkGreen;
            this.LoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginUsername.Location = new System.Drawing.Point(384, 457);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(214, 46);
            this.LoginUsername.TabIndex = 3;
            this.LoginUsername.Text = "Username:";
            // 
            // LoginPassword
            // 
            this.LoginPassword.AutoSize = true;
            this.LoginPassword.BackColor = System.Drawing.Color.DarkGreen;
            this.LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginPassword.Location = new System.Drawing.Point(391, 562);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(207, 46);
            this.LoginPassword.TabIndex = 4;
            this.LoginPassword.Text = "Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(672, 728);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(272, 62);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginCheckBox
            // 
            this.LoginCheckBox.AutoSize = true;
            this.LoginCheckBox.BackColor = System.Drawing.Color.DarkGray;
            this.LoginCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginCheckBox.Location = new System.Drawing.Point(675, 652);
            this.LoginCheckBox.Name = "LoginCheckBox";
            this.LoginCheckBox.Size = new System.Drawing.Size(255, 36);
            this.LoginCheckBox.TabIndex = 6;
            this.LoginCheckBox.Text = "Show Password";
            this.LoginCheckBox.UseVisualStyleBackColor = false;
            this.LoginCheckBox.CheckedChanged += new System.EventHandler(this.LoginCheckBox_CheckedChanged);
            // 
            // ChangecredButton
            // 
            this.ChangecredButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangecredButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangecredButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ChangecredButton.Location = new System.Drawing.Point(38, 946);
            this.ChangecredButton.Name = "ChangecredButton";
            this.ChangecredButton.Size = new System.Drawing.Size(340, 97);
            this.ChangecredButton.TabIndex = 7;
            this.ChangecredButton.Text = "Change Credentials";
            this.ChangecredButton.UseVisualStyleBackColor = false;
            this.ChangecredButton.Click += new System.EventHandler(this.ChangecredButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // DevelopedLabel
            // 
            this.DevelopedLabel.AutoSize = true;
            this.DevelopedLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DevelopedLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DevelopedLabel.Location = new System.Drawing.Point(1112, 972);
            this.DevelopedLabel.Name = "DevelopedLabel";
            this.DevelopedLabel.Size = new System.Drawing.Size(390, 41);
            this.DevelopedLabel.TabIndex = 9;
            this.DevelopedLabel.Text = "Developed by: Charbel Tabet";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1514, 1077);
            this.Controls.Add(this.DevelopedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangecredButton);
            this.Controls.Add(this.LoginCheckBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginUsername);
            this.Controls.Add(this.PasswordEntry);
            this.Controls.Add(this.UsernameEntry);
            this.Controls.Add(this.LoginAvatar);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome ! Login";
            ((System.ComponentModel.ISupportInitialize)(this.LoginAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginAvatar;
        private System.Windows.Forms.TextBox UsernameEntry;
        private System.Windows.Forms.TextBox PasswordEntry;
        private System.Windows.Forms.Label LoginUsername;
        private System.Windows.Forms.Label LoginPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox LoginCheckBox;
        private System.Windows.Forms.Button ChangecredButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DevelopedLabel;
    }
}