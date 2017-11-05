namespace HackPSU_2017
{
    partial class GUIGrades
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
            this.semestersTabList = new System.Windows.Forms.TabControl();
            this.overviewTab = new System.Windows.Forms.TabPage();
            this.semestersTabList.SuspendLayout();
            this.SuspendLayout();
            // 
            // semestersTabList
            // 
            this.semestersTabList.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.semestersTabList.Controls.Add(this.overviewTab);
            this.semestersTabList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestersTabList.Location = new System.Drawing.Point(3, 0);
            this.semestersTabList.Name = "semestersTabList";
            this.semestersTabList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.semestersTabList.SelectedIndex = 0;
            this.semestersTabList.Size = new System.Drawing.Size(1536, 1244);
            this.semestersTabList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.semestersTabList.TabIndex = 0;
            // 
            // overviewTab
            // 
            this.overviewTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.overviewTab.Location = new System.Drawing.Point(4, 58);
            this.overviewTab.Name = "overviewTab";
            this.overviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTab.Size = new System.Drawing.Size(1528, 1182);
            this.overviewTab.TabIndex = 0;
            this.overviewTab.Text = "Overview";
            // 
            // GUIGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2088, 1256);
            this.Controls.Add(this.semestersTabList);
            this.Name = "GUIGrades";
            this.Text = "GUIGrades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUIGrades_FormClosing);
            this.Load += new System.EventHandler(this.GUIGrades_Load);
            this.semestersTabList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl semestersTabList;
        private System.Windows.Forms.TabPage overviewTab;
    }
}