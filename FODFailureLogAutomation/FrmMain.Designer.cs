
namespace FODFailureLogAutomation
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.labelTrackId = new System.Windows.Forms.Label();
            this.textBoxTrackId = new System.Windows.Forms.TextBox();
            this.labelHighLimit = new System.Windows.Forms.Label();
            this.labelFailureResult = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControlFinger = new System.Windows.Forms.TabControl();
            this.TabEgis = new System.Windows.Forms.TabPage();
            this.listBoxSpecsLimit = new System.Windows.Forms.ListBox();
            this.listBoxResultFailure = new System.Windows.Forms.ListBox();
            this.listBoxMeasCode = new System.Windows.Forms.ListBox();
            this.TabGodix = new System.Windows.Forms.TabPage();
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelProviderName = new System.Windows.Forms.Label();
            this.labelImgFailure = new System.Windows.Forms.Label();
            this.groupBoxImgResult = new System.Windows.Forms.GroupBox();
            this.pictureBoxFailure = new System.Windows.Forms.PictureBox();
            this.labelFingerName = new System.Windows.Forms.Label();
            this.comboBoxFailurePictures = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.tabControlFinger.SuspendLayout();
            this.TabEgis.SuspendLayout();
            this.groupBoxImgResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFailure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTrackId
            // 
            this.labelTrackId.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelTrackId.AutoSize = true;
            this.labelTrackId.Location = new System.Drawing.Point(17, 179);
            this.labelTrackId.Name = "labelTrackId";
            this.labelTrackId.Size = new System.Drawing.Size(83, 20);
            this.labelTrackId.TabIndex = 0;
            this.labelTrackId.Text = "TRACK ID";
            // 
            // textBoxTrackId
            // 
            this.textBoxTrackId.Location = new System.Drawing.Point(21, 202);
            this.textBoxTrackId.Name = "textBoxTrackId";
            this.textBoxTrackId.Size = new System.Drawing.Size(194, 26);
            this.textBoxTrackId.TabIndex = 1;
            this.textBoxTrackId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHighLimit
            // 
            this.labelHighLimit.AutoSize = true;
            this.labelHighLimit.Location = new System.Drawing.Point(335, 3);
            this.labelHighLimit.Name = "labelHighLimit";
            this.labelHighLimit.Size = new System.Drawing.Size(189, 20);
            this.labelHighLimit.TabIndex = 3;
            this.labelHighLimit.Text = "HIGH LIMIT / LOW LIMIT";
            // 
            // labelFailureResult
            // 
            this.labelFailureResult.AutoSize = true;
            this.labelFailureResult.Location = new System.Drawing.Point(687, 3);
            this.labelFailureResult.Name = "labelFailureResult";
            this.labelFailureResult.Size = new System.Drawing.Size(105, 20);
            this.labelFailureResult.TabIndex = 10;
            this.labelFailureResult.Text = "MEAS CODE";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 3);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(77, 20);
            this.labelResult.TabIndex = 13;
            this.labelResult.Text = "RESULT ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControlFinger);
            this.groupBox2.Controls.Add(this.labelProvider);
            this.groupBox2.Controls.Add(this.labelProviderName);
            this.groupBox2.Location = new System.Drawing.Point(504, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1110, 760);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Details";
            // 
            // tabControlFinger
            // 
            this.tabControlFinger.Controls.Add(this.TabEgis);
            this.tabControlFinger.Controls.Add(this.TabGodix);
            this.tabControlFinger.Location = new System.Drawing.Point(6, 45);
            this.tabControlFinger.Name = "tabControlFinger";
            this.tabControlFinger.SelectedIndex = 0;
            this.tabControlFinger.Size = new System.Drawing.Size(1075, 709);
            this.tabControlFinger.TabIndex = 0;
            // 
            // TabEgis
            // 
            this.TabEgis.Controls.Add(this.labelResult);
            this.TabEgis.Controls.Add(this.listBoxSpecsLimit);
            this.TabEgis.Controls.Add(this.labelHighLimit);
            this.TabEgis.Controls.Add(this.listBoxResultFailure);
            this.TabEgis.Controls.Add(this.listBoxMeasCode);
            this.TabEgis.Controls.Add(this.labelFailureResult);
            this.TabEgis.Location = new System.Drawing.Point(4, 29);
            this.TabEgis.Name = "TabEgis";
            this.TabEgis.Padding = new System.Windows.Forms.Padding(3);
            this.TabEgis.Size = new System.Drawing.Size(1067, 676);
            this.TabEgis.TabIndex = 0;
            this.TabEgis.Text = "Egis";
            this.TabEgis.UseVisualStyleBackColor = true;
            // 
            // listBoxSpecsLimit
            // 
            this.listBoxSpecsLimit.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxSpecsLimit.FormattingEnabled = true;
            this.listBoxSpecsLimit.ItemHeight = 20;
            this.listBoxSpecsLimit.Location = new System.Drawing.Point(339, 26);
            this.listBoxSpecsLimit.Name = "listBoxSpecsLimit";
            this.listBoxSpecsLimit.Size = new System.Drawing.Size(346, 644);
            this.listBoxSpecsLimit.TabIndex = 23;
            // 
            // listBoxResultFailure
            // 
            this.listBoxResultFailure.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxResultFailure.FormattingEnabled = true;
            this.listBoxResultFailure.ItemHeight = 20;
            this.listBoxResultFailure.Location = new System.Drawing.Point(6, 26);
            this.listBoxResultFailure.Name = "listBoxResultFailure";
            this.listBoxResultFailure.Size = new System.Drawing.Size(323, 644);
            this.listBoxResultFailure.TabIndex = 22;
            // 
            // listBoxMeasCode
            // 
            this.listBoxMeasCode.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxMeasCode.FormattingEnabled = true;
            this.listBoxMeasCode.ItemHeight = 20;
            this.listBoxMeasCode.Location = new System.Drawing.Point(691, 26);
            this.listBoxMeasCode.Name = "listBoxMeasCode";
            this.listBoxMeasCode.Size = new System.Drawing.Size(397, 644);
            this.listBoxMeasCode.TabIndex = 21;
            // 
            // TabGodix
            // 
            this.TabGodix.Location = new System.Drawing.Point(4, 29);
            this.TabGodix.Name = "TabGodix";
            this.TabGodix.Padding = new System.Windows.Forms.Padding(3);
            this.TabGodix.Size = new System.Drawing.Size(1067, 676);
            this.TabGodix.TabIndex = 1;
            this.TabGodix.Text = "Godix";
            this.TabGodix.UseVisualStyleBackColor = true;
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(136, 22);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(0, 20);
            this.labelProvider.TabIndex = 25;
            // 
            // labelProviderName
            // 
            this.labelProviderName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelProviderName.AutoSize = true;
            this.labelProviderName.ForeColor = System.Drawing.Color.Navy;
            this.labelProviderName.Location = new System.Drawing.Point(13, 22);
            this.labelProviderName.Name = "labelProviderName";
            this.labelProviderName.Size = new System.Drawing.Size(116, 20);
            this.labelProviderName.TabIndex = 24;
            this.labelProviderName.Text = "Provider Name:";
            // 
            // labelImgFailure
            // 
            this.labelImgFailure.AutoSize = true;
            this.labelImgFailure.Location = new System.Drawing.Point(15, 21);
            this.labelImgFailure.Name = "labelImgFailure";
            this.labelImgFailure.Size = new System.Drawing.Size(104, 20);
            this.labelImgFailure.TabIndex = 18;
            this.labelImgFailure.Text = "Picture Name";
            // 
            // groupBoxImgResult
            // 
            this.groupBoxImgResult.Controls.Add(this.pictureBoxFailure);
            this.groupBoxImgResult.Controls.Add(this.labelFingerName);
            this.groupBoxImgResult.Controls.Add(this.comboBoxFailurePictures);
            this.groupBoxImgResult.Controls.Add(this.labelImgFailure);
            this.groupBoxImgResult.Location = new System.Drawing.Point(14, 343);
            this.groupBoxImgResult.Name = "groupBoxImgResult";
            this.groupBoxImgResult.Size = new System.Drawing.Size(490, 436);
            this.groupBoxImgResult.TabIndex = 19;
            this.groupBoxImgResult.TabStop = false;
            this.groupBoxImgResult.Text = "IMAGE RESULT";
            // 
            // pictureBoxFailure
            // 
            this.pictureBoxFailure.Image = global::FODFailureLogAutomation.Properties.Resources.Default;
            this.pictureBoxFailure.Location = new System.Drawing.Point(6, 78);
            this.pictureBoxFailure.Name = "pictureBoxFailure";
            this.pictureBoxFailure.Size = new System.Drawing.Size(460, 356);
            this.pictureBoxFailure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFailure.TabIndex = 7;
            this.pictureBoxFailure.TabStop = false;
            // 
            // labelFingerName
            // 
            this.labelFingerName.AutoSize = true;
            this.labelFingerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFingerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelFingerName.Location = new System.Drawing.Point(189, 16);
            this.labelFingerName.Name = "labelFingerName";
            this.labelFingerName.Size = new System.Drawing.Size(0, 22);
            this.labelFingerName.TabIndex = 21;
            // 
            // comboBoxFailurePictures
            // 
            this.comboBoxFailurePictures.FormattingEnabled = true;
            this.comboBoxFailurePictures.Location = new System.Drawing.Point(7, 44);
            this.comboBoxFailurePictures.Name = "comboBoxFailurePictures";
            this.comboBoxFailurePictures.Size = new System.Drawing.Size(459, 28);
            this.comboBoxFailurePictures.TabIndex = 19;
            this.comboBoxFailurePictures.SelectedIndexChanged += new System.EventHandler(this.comboBoxFailurePictures_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Silver;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(250, 193);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(204, 41);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(18, 782);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Developed by Matheus Paiva/A.Patricio";
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(17, 247);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(99, 20);
            this.labelDirectory.TabIndex = 22;
            this.labelDirectory.Text = "LogDirectory";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(14, 270);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(414, 26);
            this.textBoxDirectory.TabIndex = 23;
            this.textBoxDirectory.Text = "C:\\prod\\temp";
            // 
            // buttonDirectory
            // 
            this.buttonDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirectory.Location = new System.Drawing.Point(434, 270);
            this.buttonDirectory.Name = "buttonDirectory";
            this.buttonDirectory.Size = new System.Drawing.Size(46, 35);
            this.buttonDirectory.TabIndex = 24;
            this.buttonDirectory.Text = "...";
            this.buttonDirectory.UseVisualStyleBackColor = true;
            this.buttonDirectory.Click += new System.EventHandler(this.buttonDirectory_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::FODFailureLogAutomation.Properties.Resources.LogoFlex;
            this.pictureBoxLogo.Location = new System.Drawing.Point(20, 17);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(444, 147);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1626, 797);
            this.Controls.Add(this.buttonDirectory);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxImgResult);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelTrackId);
            this.Controls.Add(this.textBoxTrackId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOD FailureLog Automation";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControlFinger.ResumeLayout(false);
            this.TabEgis.ResumeLayout(false);
            this.TabEgis.PerformLayout();
            this.groupBoxImgResult.ResumeLayout(false);
            this.groupBoxImgResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFailure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxTrackId;
        public System.Windows.Forms.Label labelTrackId;
        public System.Windows.Forms.Label labelHighLimit;
        public System.Windows.Forms.PictureBox pictureBoxFailure;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
        public System.Windows.Forms.Label labelFailureResult;
        public System.Windows.Forms.Label labelResult;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBoxImgResult;
        public System.Windows.Forms.Label labelImgFailure;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.ListBox listBoxMeasCode;
        public System.Windows.Forms.ListBox listBoxSpecsLimit;
        public System.Windows.Forms.ListBox listBoxResultFailure;
        public System.Windows.Forms.ComboBox comboBoxFailurePictures;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelDirectory;
        public System.Windows.Forms.TextBox textBoxDirectory;
        public System.Windows.Forms.Button buttonDirectory;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.Label labelProviderName;
        public System.Windows.Forms.Label labelProvider;
        public System.Windows.Forms.Label labelFingerName;
        public System.Windows.Forms.TabControl tabControlFinger;
        public System.Windows.Forms.TabPage TabEgis;
        public System.Windows.Forms.TabPage TabGodix;
    }
}

