
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
            this.textBoxTrackIdSearched = new System.Windows.Forms.TextBox();
            this.textBoxHighLimit = new System.Windows.Forms.TextBox();
            this.textBoxLowLimit = new System.Windows.Forms.TextBox();
            this.labelHighLimit = new System.Windows.Forms.Label();
            this.labelLowLimit = new System.Windows.Forms.Label();
            this.labelTrackIdSearched = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxFailure = new System.Windows.Forms.PictureBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelFailureResult = new System.Windows.Forms.Label();
            this.textBoxMeasCode = new System.Windows.Forms.TextBox();
            this.textBoxFailure = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxImgFailure = new System.Windows.Forms.TextBox();
            this.labelImgFailure = new System.Windows.Forms.Label();
            this.groupBoxImgResult = new System.Windows.Forms.GroupBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageGodix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFailure)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxImgResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageGodix);
            this.tabControlMain.Controls.Add(this.tabPageEgis);
            this.tabControlMain.Location = new System.Drawing.Point(273, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1232, 643);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageGodix
            // 
            this.tabPageGodix.Controls.Add(this.groupBoxImgResult);
            this.tabPageGodix.Controls.Add(this.groupBox2);
            this.tabPageGodix.Controls.Add(this.groupBox1);
            this.tabPageGodix.Location = new System.Drawing.Point(4, 29);
            this.tabPageGodix.Name = "tabPageGodix";
            this.tabPageGodix.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGodix.Size = new System.Drawing.Size(1224, 610);
            this.tabPageGodix.TabIndex = 0;
            this.tabPageGodix.Text = "GODIX";
            this.tabPageGodix.UseVisualStyleBackColor = true;
            // 
            // tabPageEgis
            // 
            this.tabPageEgis.Location = new System.Drawing.Point(4, 29);
            this.tabPageEgis.Name = "tabPageEgis";
            this.tabPageEgis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEgis.Size = new System.Drawing.Size(1224, 610);
            this.tabPageEgis.TabIndex = 1;
            this.tabPageEgis.Text = "EGIS";
            this.tabPageEgis.UseVisualStyleBackColor = true;
            // 
            // labelTrackId
            // 
            this.labelTrackId.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelTrackId.AutoSize = true;
            this.labelTrackId.Location = new System.Drawing.Point(80, 21);
            this.labelTrackId.Name = "labelTrackId";
            this.labelTrackId.Size = new System.Drawing.Size(83, 20);
            this.labelTrackId.TabIndex = 0;
            this.labelTrackId.Text = "TRACK ID";
            // 
            // textBoxTrackId
            // 
            this.textBoxTrackId.Location = new System.Drawing.Point(27, 44);
            this.textBoxTrackId.Name = "textBoxTrackId";
            this.textBoxTrackId.Size = new System.Drawing.Size(183, 26);
            this.textBoxTrackId.TabIndex = 1;
            // 
            // textBoxTrackIdSearched
            // 
            this.textBoxTrackIdSearched.Location = new System.Drawing.Point(25, 51);
            this.textBoxTrackIdSearched.Name = "textBoxTrackIdSearched";
            this.textBoxTrackIdSearched.Size = new System.Drawing.Size(295, 26);
            this.textBoxTrackIdSearched.TabIndex = 0;
            // 
            // textBoxHighLimit
            // 
            this.textBoxHighLimit.Location = new System.Drawing.Point(315, 70);
            this.textBoxHighLimit.Multiline = true;
            this.textBoxHighLimit.Name = "textBoxHighLimit";
            this.textBoxHighLimit.Size = new System.Drawing.Size(131, 471);
            this.textBoxHighLimit.TabIndex = 1;
            // 
            // textBoxLowLimit
            // 
            this.textBoxLowLimit.Location = new System.Drawing.Point(162, 69);
            this.textBoxLowLimit.Multiline = true;
            this.textBoxLowLimit.Name = "textBoxLowLimit";
            this.textBoxLowLimit.Size = new System.Drawing.Size(127, 472);
            this.textBoxLowLimit.TabIndex = 2;
            // 
            // labelHighLimit
            // 
            this.labelHighLimit.AutoSize = true;
            this.labelHighLimit.Location = new System.Drawing.Point(334, 37);
            this.labelHighLimit.Name = "labelHighLimit";
            this.labelHighLimit.Size = new System.Drawing.Size(96, 20);
            this.labelHighLimit.TabIndex = 3;
            this.labelHighLimit.Text = "HIGH LIMIT";
            // 
            // labelLowLimit
            // 
            this.labelLowLimit.AutoSize = true;
            this.labelLowLimit.Location = new System.Drawing.Point(186, 40);
            this.labelLowLimit.Name = "labelLowLimit";
            this.labelLowLimit.Size = new System.Drawing.Size(90, 20);
            this.labelLowLimit.TabIndex = 4;
            this.labelLowLimit.Text = "LOW LIMIT";
            // 
            // labelTrackIdSearched
            // 
            this.labelTrackIdSearched.AutoSize = true;
            this.labelTrackIdSearched.Location = new System.Drawing.Point(21, 28);
            this.labelTrackIdSearched.Name = "labelTrackIdSearched";
            this.labelTrackIdSearched.Size = new System.Drawing.Size(83, 20);
            this.labelTrackIdSearched.TabIndex = 5;
            this.labelTrackIdSearched.Text = "TRACK ID";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::FODFailureLogAutomation.Properties.Resources.LogoFlex;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 523);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(268, 128);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxFailure
            // 
            this.pictureBoxFailure.Location = new System.Drawing.Point(6, 104);
            this.pictureBoxFailure.Name = "pictureBoxFailure";
            this.pictureBoxFailure.Size = new System.Drawing.Size(348, 262);
            this.pictureBoxFailure.TabIndex = 7;
            this.pictureBoxFailure.TabStop = false;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(26, 129);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(294, 26);
            this.textBoxProductName.TabIndex = 8;
            // 
            // labelFailureResult
            // 
            this.labelFailureResult.AutoSize = true;
            this.labelFailureResult.Location = new System.Drawing.Point(600, 37);
            this.labelFailureResult.Name = "labelFailureResult";
            this.labelFailureResult.Size = new System.Drawing.Size(105, 20);
            this.labelFailureResult.TabIndex = 10;
            this.labelFailureResult.Text = "MEAS CODE";
            // 
            // textBoxMeasCode
            // 
            this.textBoxMeasCode.Location = new System.Drawing.Point(467, 70);
            this.textBoxMeasCode.Multiline = true;
            this.textBoxMeasCode.Name = "textBoxMeasCode";
            this.textBoxMeasCode.Size = new System.Drawing.Size(354, 471);
            this.textBoxMeasCode.TabIndex = 11;
            // 
            // textBoxFailure
            // 
            this.textBoxFailure.Location = new System.Drawing.Point(17, 69);
            this.textBoxFailure.Multiline = true;
            this.textBoxFailure.Name = "textBoxFailure";
            this.textBoxFailure.Size = new System.Drawing.Size(120, 472);
            this.textBoxFailure.TabIndex = 12;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(27, 37);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(73, 20);
            this.labelResult.TabIndex = 13;
            this.labelResult.Text = "RESULT";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(22, 106);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(137, 20);
            this.labelProductName.TabIndex = 14;
            this.labelProductName.Text = "PRODUCT NAME";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTrackIdSearched);
            this.groupBox1.Controls.Add(this.labelProductName);
            this.groupBox1.Controls.Add(this.labelTrackIdSearched);
            this.groupBox1.Controls.Add(this.textBoxProductName);
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 177);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelResult);
            this.groupBox2.Controls.Add(this.labelLowLimit);
            this.groupBox2.Controls.Add(this.labelFailureResult);
            this.groupBox2.Controls.Add(this.textBoxMeasCode);
            this.groupBox2.Controls.Add(this.textBoxFailure);
            this.groupBox2.Controls.Add(this.textBoxLowLimit);
            this.groupBox2.Controls.Add(this.labelHighLimit);
            this.groupBox2.Controls.Add(this.textBoxHighLimit);
            this.groupBox2.Location = new System.Drawing.Point(372, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 578);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Details";
            // 
            // textBoxImgFailure
            // 
            this.textBoxImgFailure.Location = new System.Drawing.Point(6, 66);
            this.textBoxImgFailure.Name = "textBoxImgFailure";
            this.textBoxImgFailure.Size = new System.Drawing.Size(333, 26);
            this.textBoxImgFailure.TabIndex = 17;
            // 
            // labelImgFailure
            // 
            this.labelImgFailure.AutoSize = true;
            this.labelImgFailure.Location = new System.Drawing.Point(30, 43);
            this.labelImgFailure.Name = "labelImgFailure";
            this.labelImgFailure.Size = new System.Drawing.Size(107, 20);
            this.labelImgFailure.TabIndex = 18;
            this.labelImgFailure.Text = "Result Failure";
            this.labelImgFailure.Click += new System.EventHandler(this.labelImgFailure_Click);
            // 
            // groupBoxImgResult
            // 
            this.groupBoxImgResult.Controls.Add(this.pictureBoxFailure);
            this.groupBoxImgResult.Controls.Add(this.labelImgFailure);
            this.groupBoxImgResult.Controls.Add(this.textBoxImgFailure);
            this.groupBoxImgResult.Location = new System.Drawing.Point(6, 232);
            this.groupBoxImgResult.Name = "groupBoxImgResult";
            this.groupBoxImgResult.Size = new System.Drawing.Size(360, 372);
            this.groupBoxImgResult.TabIndex = 19;
            this.groupBoxImgResult.TabStop = false;
            this.groupBoxImgResult.Text = "IMAGE RESULT";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 667);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelTrackId);
            this.Controls.Add(this.textBoxTrackId);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOD FailureLog Automation";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGodix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFailure)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxImgResult.ResumeLayout(false);
            this.groupBoxImgResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageGodix;
        private System.Windows.Forms.TabPage tabPageEgis;
        private System.Windows.Forms.TextBox textBoxTrackId;
        private System.Windows.Forms.Label labelTrackId;
        private System.Windows.Forms.Label labelTrackIdSearched;
        private System.Windows.Forms.Label labelLowLimit;
        private System.Windows.Forms.Label labelHighLimit;
        private System.Windows.Forms.TextBox textBoxLowLimit;
        private System.Windows.Forms.TextBox textBoxHighLimit;
        private System.Windows.Forms.TextBox textBoxTrackIdSearched;
        private System.Windows.Forms.PictureBox pictureBoxFailure;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelFailureResult;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxFailure;
        private System.Windows.Forms.TextBox textBoxMeasCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxImgFailure;
        private System.Windows.Forms.GroupBox groupBoxImgResult;
        private System.Windows.Forms.Label labelImgFailure;
    }
}

