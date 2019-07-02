namespace KinowySystemRezerwacji.view
{
    partial class BookingsList
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
            this.bookingsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bookingsListBox
            // 
            this.bookingsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bookingsListBox.FormattingEnabled = true;
            this.bookingsListBox.ItemHeight = 24;
            this.bookingsListBox.Location = new System.Drawing.Point(4, 4);
            this.bookingsListBox.Name = "bookingsListBox";
            this.bookingsListBox.Size = new System.Drawing.Size(293, 292);
            this.bookingsListBox.TabIndex = 0;
            // 
            // BookingsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingsListBox);
            this.Name = "BookingsList";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookingsListBox;
    }
}
