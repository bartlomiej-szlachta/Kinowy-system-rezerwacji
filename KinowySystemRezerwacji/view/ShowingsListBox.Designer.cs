namespace KinowySystemRezerwacji.view
{
    partial class ShowingsListBox
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
            this.listViewShowings = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewShowings
            // 
            this.listViewShowings.Location = new System.Drawing.Point(3, 3);
            this.listViewShowings.Name = "listViewShowings";
            this.listViewShowings.Size = new System.Drawing.Size(392, 301);
            this.listViewShowings.TabIndex = 0;
            this.listViewShowings.UseCompatibleStateImageBehavior = false;
            this.listViewShowings.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowingsListBox_MouseDoubleClick);
            // 
            // ShowingsListBox
            // 
            this.Controls.Add(this.listViewShowings);
            this.Name = "ShowingsListBox";
            this.Size = new System.Drawing.Size(398, 307);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShowings;
        private System.Windows.Forms.ListView listViewShowings;
    }
}
