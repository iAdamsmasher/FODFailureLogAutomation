
namespace FODFailureLogAutomation
{
    partial class FrmMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageGodix = new System.Windows.Forms.TabPage();
            this.tabPageEgis = new System.Windows.Forms.TabPage();
            this.labelTrackId = new System.Windows.Forms.Label();
            this.textBoxTrackId = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageGodix);
            this.tabControlMain.Controls.Add(this.tabPageEgis);
            this.tabControlMain.Location = new System.Drawing.Point(273, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(888, 643);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageGodix
            // 
            this.tabPageGodix.Location = new System.Drawing.Point(4, 29);
            this.tabPageGodix.Name = "tabPageGodix";
            this.tabPageGodix.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGodix.Size = new System.Drawing.Size(880, 610);
            this.tabPageGodix.TabIndex = 0;
            this.tabPageGodix.Text = "GODIX";
            this.tabPageGodix.UseVisualStyleBackColor = true;
            // 
            // tabPageEgis
            // 
            this.tabPageEgis.Location = new System.Drawing.Point(4, 29);
            this.tabPageEgis.Name = "tabPageEgis";
            this.tabPageEgis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEgis.Size = new System.Drawing.Size(880, 610);
            this.tabPageEgis.TabIndex = 1;
            this.tabPageEgis.Text = "EGIS";
            this.tabPageEgis.UseVisualStyleBackColor = true;
            // 
            // labelTrackId
            // 
            this.labelTrackId.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelTrackId.AutoSize = true;
            this.labelTrackId.Location = new System.Drawing.Point(30, 56);
            this.labelTrackId.Name = "labelTrackId";
            this.labelTrackId.Size = new System.Drawing.Size(83, 20);
            this.labelTrackId.TabIndex = 0;
            this.labelTrackId.Text = "TRACK ID";
            // 
            // textBoxTrackId
            // 
            this.textBoxTrackId.Location = new System.Drawing.Point(34, 79);
            this.textBoxTrackId.Name = "textBoxTrackId";
            this.textBoxTrackId.Size = new System.Drawing.Size(183, 26);
            this.textBoxTrackId.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 667);
            this.Controls.Add(this.labelTrackId);
            this.Controls.Add(this.textBoxTrackId);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOD FailureLog Automation";
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageGodix;
        private System.Windows.Forms.TabPage tabPageEgis;
        private System.Windows.Forms.TextBox textBoxTrackId;
        private System.Windows.Forms.Label labelTrackId;
    }
}

