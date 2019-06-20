namespace KinowySystemRezerwacji.view
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.confirmLoginRegisterButton = new System.Windows.Forms.Button();
            this.switchLoginRegisterButton = new System.Windows.Forms.Button();
            this.usernameExtendedTextBox = new KinowySystemRezerwacji.view.ExtendedTextBox();
            this.passwordExtendedTextBox = new KinowySystemRezerwacji.view.ExtendedTextBox();
            this.firstNameExtendedTextBox = new KinowySystemRezerwacji.view.ExtendedTextBox();
            this.lastNameExtendedTextBox = new KinowySystemRezerwacji.view.ExtendedTextBox();
            this.emailExtendedTextBox = new KinowySystemRezerwacji.view.ExtendedTextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(13, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(359, 57);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Logowanie";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmLoginRegisterButton
            // 
            this.confirmLoginRegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmLoginRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmLoginRegisterButton.Location = new System.Drawing.Point(45, 275);
            this.confirmLoginRegisterButton.Name = "confirmLoginRegisterButton";
            this.confirmLoginRegisterButton.Size = new System.Drawing.Size(295, 40);
            this.confirmLoginRegisterButton.TabIndex = 6;
            this.confirmLoginRegisterButton.Text = "Zaloguj";
            this.confirmLoginRegisterButton.UseVisualStyleBackColor = true;
            this.confirmLoginRegisterButton.Click += new System.EventHandler(this.confirmLoginRegisterButton_Click);
            // 
            // switchLoginRegisterButton
            // 
            this.switchLoginRegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switchLoginRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.switchLoginRegisterButton.Location = new System.Drawing.Point(45, 409);
            this.switchLoginRegisterButton.Name = "switchLoginRegisterButton";
            this.switchLoginRegisterButton.Size = new System.Drawing.Size(295, 40);
            this.switchLoginRegisterButton.TabIndex = 7;
            this.switchLoginRegisterButton.Text = "Tryb rejestracji";
            this.switchLoginRegisterButton.UseVisualStyleBackColor = true;
            this.switchLoginRegisterButton.Click += new System.EventHandler(this.switchLoginRegisterButton_Click);
            // 
            // usernameExtendedTextBox
            // 
            this.usernameExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameExtendedTextBox.Location = new System.Drawing.Point(12, 70);
            this.usernameExtendedTextBox.Name = "usernameExtendedTextBox";
            this.usernameExtendedTextBox.Size = new System.Drawing.Size(360, 35);
            this.usernameExtendedTextBox.TabIndex = 0;
            // 
            // passwordExtendedTextBox
            // 
            this.passwordExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordExtendedTextBox.Location = new System.Drawing.Point(12, 111);
            this.passwordExtendedTextBox.Name = "passwordExtendedTextBox";
            this.passwordExtendedTextBox.Size = new System.Drawing.Size(360, 35);
            this.passwordExtendedTextBox.TabIndex = 1;
            // 
            // firstNameExtendedTextBox
            // 
            this.firstNameExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameExtendedTextBox.Location = new System.Drawing.Point(12, 152);
            this.firstNameExtendedTextBox.Name = "firstNameExtendedTextBox";
            this.firstNameExtendedTextBox.Size = new System.Drawing.Size(360, 35);
            this.firstNameExtendedTextBox.TabIndex = 2;
            this.firstNameExtendedTextBox.Visible = false;
            // 
            // lastNameExtendedTextBox
            // 
            this.lastNameExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameExtendedTextBox.Location = new System.Drawing.Point(12, 193);
            this.lastNameExtendedTextBox.Name = "lastNameExtendedTextBox";
            this.lastNameExtendedTextBox.Size = new System.Drawing.Size(360, 35);
            this.lastNameExtendedTextBox.TabIndex = 3;
            this.lastNameExtendedTextBox.Visible = false;
            // 
            // emailExtendedTextBox
            // 
            this.emailExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailExtendedTextBox.Location = new System.Drawing.Point(12, 234);
            this.emailExtendedTextBox.Name = "emailExtendedTextBox";
            this.emailExtendedTextBox.Size = new System.Drawing.Size(360, 35);
            this.emailExtendedTextBox.TabIndex = 4;
            this.emailExtendedTextBox.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.emailExtendedTextBox);
            this.Controls.Add(this.lastNameExtendedTextBox);
            this.Controls.Add(this.firstNameExtendedTextBox);
            this.Controls.Add(this.passwordExtendedTextBox);
            this.Controls.Add(this.usernameExtendedTextBox);
            this.Controls.Add(this.switchLoginRegisterButton);
            this.Controls.Add(this.confirmLoginRegisterButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie do systemu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button confirmLoginRegisterButton;
        private System.Windows.Forms.Button switchLoginRegisterButton;
        private ExtendedTextBox usernameExtendedTextBox;
        private ExtendedTextBox passwordExtendedTextBox;
        private ExtendedTextBox firstNameExtendedTextBox;
        private ExtendedTextBox lastNameExtendedTextBox;
        private ExtendedTextBox emailExtendedTextBox;
    }
}

