namespace KinowySystemRezerwacji.view
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mojeRezerwacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repertuarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.użytkownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojeRezerwacjeToolStripMenuItem,
            this.repertuarToolStripMenuItem,
            this.użytkownikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mojeRezerwacjeToolStripMenuItem
            // 
            this.mojeRezerwacjeToolStripMenuItem.Name = "mojeRezerwacjeToolStripMenuItem";
            this.mojeRezerwacjeToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.mojeRezerwacjeToolStripMenuItem.Text = "Moje rezerwacje";
            // 
            // repertuarToolStripMenuItem
            // 
            this.repertuarToolStripMenuItem.Name = "repertuarToolStripMenuItem";
            this.repertuarToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.repertuarToolStripMenuItem.Text = "Repertuar";
            // 
            // użytkownikToolStripMenuItem
            // 
            this.użytkownikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujToolStripMenuItem});
            this.użytkownikToolStripMenuItem.Name = "użytkownikToolStripMenuItem";
            this.użytkownikToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.użytkownikToolStripMenuItem.Text = "Użytkownik";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click_1);
            // 
            // extendedMonthCalendar
            // 
            this.extendedMonthCalendar.Location = new System.Drawing.Point(173, 30);
            this.extendedMonthCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extendedMonthCalendar.Name = "extendedMonthCalendar";
            this.extendedMonthCalendar.Size = new System.Drawing.Size(692, 468);
            this.extendedMonthCalendar.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.extendedMonthCalendar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kinowy system rezerwacji";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mojeRezerwacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repertuarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem użytkownikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private ExtendedMonthCalendar extendedMonthCalendar;
    }
}