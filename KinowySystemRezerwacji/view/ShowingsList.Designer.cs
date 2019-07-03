namespace KinowySystemRezerwacji.view
{
    partial class ShowingsList
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
            this.showingsListView = new System.Windows.Forms.ListView();
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ratingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lengthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // showingsListView
            // 
            this.showingsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.titleHeader,
            this.dateHeader,
            this.ratingHeader,
            this.lengthHeader});
            this.showingsListView.FullRowSelect = true;
            this.showingsListView.GridLines = true;
            this.showingsListView.Location = new System.Drawing.Point(17, 15);
            this.showingsListView.MultiSelect = false;
            this.showingsListView.Name = "showingsListView";
            this.showingsListView.Size = new System.Drawing.Size(495, 273);
            this.showingsListView.TabIndex = 1;
            this.showingsListView.UseCompatibleStateImageBehavior = false;
            this.showingsListView.View = System.Windows.Forms.View.Details;
            this.showingsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.showingsListView_MouseDoubleClick);
            // 
            // idHeader
            // 
            this.idHeader.Text = "Id";
            this.idHeader.Width = 30;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Tytuł";
            this.titleHeader.Width = 170;
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Data";
            this.dateHeader.Width = 127;
            // 
            // ratingHeader
            // 
            this.ratingHeader.Text = "Rok premiery";
            this.ratingHeader.Width = 71;
            // 
            // lengthHeader
            // 
            this.lengthHeader.Text = "Długość";
            this.lengthHeader.Width = 88;
            // 
            // ShowingsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showingsListView);
            this.Name = "ShowingsList";
            this.Size = new System.Drawing.Size(526, 301);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView showingsListView;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.ColumnHeader ratingHeader;
        private System.Windows.Forms.ColumnHeader lengthHeader;
    }
}
