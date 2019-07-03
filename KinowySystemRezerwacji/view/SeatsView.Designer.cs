namespace KinowySystemRezerwacji.view
{
    partial class SeatsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screenIndicatorLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.seatsPanel1 = new KinowySystemRezerwacji.view.SeatsPanel();
            this.SuspendLayout();
            // 
            // screenIndicatorLabel
            // 
            this.screenIndicatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screenIndicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.screenIndicatorLabel.Location = new System.Drawing.Point(3, 0);
            this.screenIndicatorLabel.Name = "screenIndicatorLabel";
            this.screenIndicatorLabel.Size = new System.Drawing.Size(355, 57);
            this.screenIndicatorLabel.TabIndex = 1;
            this.screenIndicatorLabel.Text = "Ekran";
            this.screenIndicatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmButton.Location = new System.Drawing.Point(3, 237);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(355, 42);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Rezerwuj";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // seatsPanel1
            // 
            this.seatsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seatsPanel1.Labels = null;
            this.seatsPanel1.Location = new System.Drawing.Point(4, 61);
            this.seatsPanel1.Name = "seatsPanel1";
            this.seatsPanel1.Size = new System.Drawing.Size(354, 170);
            this.seatsPanel1.TabIndex = 3;
            // 
            // SeatsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seatsPanel1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.screenIndicatorLabel);
            this.Name = "SeatsView";
            this.Size = new System.Drawing.Size(361, 282);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label screenIndicatorLabel;
        private System.Windows.Forms.Button confirmButton;
        private SeatsPanel seatsPanel1;
    }
}
