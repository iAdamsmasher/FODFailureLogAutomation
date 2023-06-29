
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
            this.groupBoxEgis = new System.Windows.Forms.GroupBox();
            this.listBoxSpecsLimit = new System.Windows.Forms.ListBox();
            this.listBoxMeasCode = new System.Windows.Forms.ListBox();
            this.listBoxResultFailure = new System.Windows.Forms.ListBox();
            this.TabGodix = new System.Windows.Forms.TabPage();
            this.groupBoxGodix = new System.Windows.Forms.GroupBox();
            this.labelMeasResult = new System.Windows.Forms.Label();
            this.labelMeasDescription = new System.Windows.Forms.Label();
            this.labelMeasCode2 = new System.Windows.Forms.Label();
            this.listBoxMeasResult = new System.Windows.Forms.ListBox();
            this.listBoxMeasDescription = new System.Windows.Forms.ListBox();
            this.listBoxMeasCode2 = new System.Windows.Forms.ListBox();
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelProviderName = new System.Windows.Forms.Label();
            this.labelImgFailure = new System.Windows.Forms.Label();
            this.groupBoxImgResult = new System.Windows.Forms.GroupBox();
            this.pictureBoxFailure = new System.Windows.Forms.PictureBox();
            this.labelFingerName = new System.Windows.Forms.Label();
            this.comboBoxFailurePictures = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelDeveloperName = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelSearching = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.tabControlFinger.SuspendLayout();
            this.TabEgis.SuspendLayout();
            this.groupBoxEgis.SuspendLayout();
            this.TabGodix.SuspendLayout();
            this.groupBoxGodix.SuspendLayout();
            this.groupBoxImgResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFailure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTrackId
            // 
            this.labelTrackId.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelTrackId.AutoSize = true;
            this.labelTrackId.Location = new System.Drawing.Point(16, 178);
            this.labelTrackId.Name = "labelTrackId";
            this.labelTrackId.Size = new System.Drawing.Size(83, 20);
            this.labelTrackId.TabIndex = 0;
            this.labelTrackId.Text = "TRACK ID";
            // 
            // textBoxTrackId
            // 
            this.textBoxTrackId.Location = new System.Drawing.Point(21, 202);
            this.textBoxTrackId.Name = "textBoxTrackId";
            this.textBoxTrackId.Size = new System.Drawing.Size(234, 26);
            this.textBoxTrackId.TabIndex = 1;
            this.textBoxTrackId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHighLimit
            // 
            this.labelHighLimit.AutoSize = true;
            this.labelHighLimit.Location = new System.Drawing.Point(366, 30);
            this.labelHighLimit.Name = "labelHighLimit";
            this.labelHighLimit.Size = new System.Drawing.Size(296, 20);
            this.labelHighLimit.TabIndex = 3;
            this.labelHighLimit.Text = "LIMITE SUPERIOR / LIMITE INFERIOR";
            // 
            // labelFailureResult
            // 
            this.labelFailureResult.AutoSize = true;
            this.labelFailureResult.Location = new System.Drawing.Point(708, 30);
            this.labelFailureResult.Name = "labelFailureResult";
            this.labelFailureResult.Size = new System.Drawing.Size(105, 20);
            this.labelFailureResult.TabIndex = 10;
            this.labelFailureResult.Text = "MEAS CODE";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(24, 30);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(108, 20);
            this.labelResult.TabIndex = 13;
            this.labelResult.Text = "RESULTADO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControlFinger);
            this.groupBox2.Controls.Add(this.labelProvider);
            this.groupBox2.Controls.Add(this.labelProviderName);
            this.groupBox2.Location = new System.Drawing.Point(627, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1252, 880);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes do Teste";
            // 
            // tabControlFinger
            // 
            this.tabControlFinger.Controls.Add(this.TabEgis);
            this.tabControlFinger.Controls.Add(this.TabGodix);
            this.tabControlFinger.Location = new System.Drawing.Point(6, 45);
            this.tabControlFinger.Name = "tabControlFinger";
            this.tabControlFinger.SelectedIndex = 0;
            this.tabControlFinger.Size = new System.Drawing.Size(1210, 822);
            this.tabControlFinger.TabIndex = 0;
            // 
            // TabEgis
            // 
            this.TabEgis.Controls.Add(this.groupBoxEgis);
            this.TabEgis.Location = new System.Drawing.Point(4, 29);
            this.TabEgis.Name = "TabEgis";
            this.TabEgis.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabEgis.Size = new System.Drawing.Size(1202, 789);
            this.TabEgis.TabIndex = 0;
            this.TabEgis.Text = "Egis";
            this.TabEgis.UseVisualStyleBackColor = true;
            // 
            // groupBoxEgis
            // 
            this.groupBoxEgis.Controls.Add(this.labelResult);
            this.groupBoxEgis.Controls.Add(this.labelFailureResult);
            this.groupBoxEgis.Controls.Add(this.listBoxSpecsLimit);
            this.groupBoxEgis.Controls.Add(this.listBoxMeasCode);
            this.groupBoxEgis.Controls.Add(this.labelHighLimit);
            this.groupBoxEgis.Controls.Add(this.listBoxResultFailure);
            this.groupBoxEgis.Location = new System.Drawing.Point(21, 22);
            this.groupBoxEgis.Name = "groupBoxEgis";
            this.groupBoxEgis.Size = new System.Drawing.Size(1142, 731);
            this.groupBoxEgis.TabIndex = 24;
            this.groupBoxEgis.TabStop = false;
            this.groupBoxEgis.Text = "Detalhes do Egis";
            // 
            // listBoxSpecsLimit
            // 
            this.listBoxSpecsLimit.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxSpecsLimit.FormattingEnabled = true;
            this.listBoxSpecsLimit.ItemHeight = 20;
            this.listBoxSpecsLimit.Location = new System.Drawing.Point(362, 55);
            this.listBoxSpecsLimit.Name = "listBoxSpecsLimit";
            this.listBoxSpecsLimit.Size = new System.Drawing.Size(346, 644);
            this.listBoxSpecsLimit.TabIndex = 23;
            // 
            // listBoxMeasCode
            // 
            this.listBoxMeasCode.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxMeasCode.FormattingEnabled = true;
            this.listBoxMeasCode.ItemHeight = 20;
            this.listBoxMeasCode.Location = new System.Drawing.Point(712, 55);
            this.listBoxMeasCode.Name = "listBoxMeasCode";
            this.listBoxMeasCode.Size = new System.Drawing.Size(397, 644);
            this.listBoxMeasCode.TabIndex = 21;
            // 
            // listBoxResultFailure
            // 
            this.listBoxResultFailure.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxResultFailure.FormattingEnabled = true;
            this.listBoxResultFailure.ItemHeight = 20;
            this.listBoxResultFailure.Location = new System.Drawing.Point(28, 55);
            this.listBoxResultFailure.Name = "listBoxResultFailure";
            this.listBoxResultFailure.Size = new System.Drawing.Size(324, 644);
            this.listBoxResultFailure.TabIndex = 22;
            // 
            // TabGodix
            // 
            this.TabGodix.Controls.Add(this.groupBoxGodix);
            this.TabGodix.Location = new System.Drawing.Point(4, 29);
            this.TabGodix.Name = "TabGodix";
            this.TabGodix.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabGodix.Size = new System.Drawing.Size(1202, 789);
            this.TabGodix.TabIndex = 1;
            this.TabGodix.Text = "Godix";
            this.TabGodix.UseVisualStyleBackColor = true;
            // 
            // groupBoxGodix
            // 
            this.groupBoxGodix.Controls.Add(this.labelMeasResult);
            this.groupBoxGodix.Controls.Add(this.labelMeasDescription);
            this.groupBoxGodix.Controls.Add(this.labelMeasCode2);
            this.groupBoxGodix.Controls.Add(this.listBoxMeasResult);
            this.groupBoxGodix.Controls.Add(this.listBoxMeasDescription);
            this.groupBoxGodix.Controls.Add(this.listBoxMeasCode2);
            this.groupBoxGodix.Location = new System.Drawing.Point(16, 17);
            this.groupBoxGodix.Name = "groupBoxGodix";
            this.groupBoxGodix.Size = new System.Drawing.Size(1167, 755);
            this.groupBoxGodix.TabIndex = 0;
            this.groupBoxGodix.TabStop = false;
            this.groupBoxGodix.Text = "Detalhes Godix";
            // 
            // labelMeasResult
            // 
            this.labelMeasResult.AutoSize = true;
            this.labelMeasResult.Location = new System.Drawing.Point(28, 35);
            this.labelMeasResult.Name = "labelMeasResult";
            this.labelMeasResult.Size = new System.Drawing.Size(283, 24);
            this.labelMeasResult.TabIndex = 5;
            this.labelMeasResult.Text = "RESULTADO DO MEAS CODE";
            // 
            // labelMeasDescription
            // 
            this.labelMeasDescription.AutoSize = true;
            this.labelMeasDescription.Location = new System.Drawing.Point(28, 278);
            this.labelMeasDescription.Name = "labelMeasDescription";
            this.labelMeasDescription.Size = new System.Drawing.Size(280, 24);
            this.labelMeasDescription.TabIndex = 4;
            this.labelMeasDescription.Text = "DESCRIÇÃO DO MEAS CODE";
            // 
            // labelMeasCode2
            // 
            this.labelMeasCode2.AutoSize = true;
            this.labelMeasCode2.Location = new System.Drawing.Point(28, 518);
            this.labelMeasCode2.Name = "labelMeasCode2";
            this.labelMeasCode2.Size = new System.Drawing.Size(105, 20);
            this.labelMeasCode2.TabIndex = 3;
            this.labelMeasCode2.Text = "MEAS CODE";
            // 
            // listBoxMeasResult
            // 
            this.listBoxMeasResult.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxMeasResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMeasResult.FormattingEnabled = true;
            this.listBoxMeasResult.HorizontalScrollbar = true;
            this.listBoxMeasResult.ItemHeight = 29;
            this.listBoxMeasResult.Location = new System.Drawing.Point(32, 58);
            this.listBoxMeasResult.Name = "listBoxMeasResult";
            this.listBoxMeasResult.Size = new System.Drawing.Size(1116, 178);
            this.listBoxMeasResult.TabIndex = 2;
            // 
            // listBoxMeasDescription
            // 
            this.listBoxMeasDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxMeasDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMeasDescription.FormattingEnabled = true;
            this.listBoxMeasDescription.ItemHeight = 29;
            this.listBoxMeasDescription.Location = new System.Drawing.Point(32, 309);
            this.listBoxMeasDescription.Name = "listBoxMeasDescription";
            this.listBoxMeasDescription.Size = new System.Drawing.Size(1116, 178);
            this.listBoxMeasDescription.TabIndex = 1;
            // 
            // listBoxMeasCode2
            // 
            this.listBoxMeasCode2.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxMeasCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMeasCode2.FormattingEnabled = true;
            this.listBoxMeasCode2.ItemHeight = 29;
            this.listBoxMeasCode2.Location = new System.Drawing.Point(32, 542);
            this.listBoxMeasCode2.Name = "listBoxMeasCode2";
            this.listBoxMeasCode2.Size = new System.Drawing.Size(1116, 178);
            this.listBoxMeasCode2.TabIndex = 0;
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelProvider.Location = new System.Drawing.Point(136, 14);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(0, 26);
            this.labelProvider.TabIndex = 25;
            // 
            // labelProviderName
            // 
            this.labelProviderName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelProviderName.AutoSize = true;
            this.labelProviderName.ForeColor = System.Drawing.Color.Navy;
            this.labelProviderName.Location = new System.Drawing.Point(14, 22);
            this.labelProviderName.Name = "labelProviderName";
            this.labelProviderName.Size = new System.Drawing.Size(196, 24);
            this.labelProviderName.TabIndex = 24;
            this.labelProviderName.Text = "Nome do Fornecedor:";
            // 
            // labelImgFailure
            // 
            this.labelImgFailure.AutoSize = true;
            this.labelImgFailure.Location = new System.Drawing.Point(15, 22);
            this.labelImgFailure.Name = "labelImgFailure";
            this.labelImgFailure.Size = new System.Drawing.Size(132, 24);
            this.labelImgFailure.TabIndex = 18;
            this.labelImgFailure.Text = "Nome da Foto";
            // 
            // groupBoxImgResult
            // 
            this.groupBoxImgResult.Controls.Add(this.pictureBoxFailure);
            this.groupBoxImgResult.Controls.Add(this.labelFingerName);
            this.groupBoxImgResult.Controls.Add(this.comboBoxFailurePictures);
            this.groupBoxImgResult.Controls.Add(this.labelImgFailure);
            this.groupBoxImgResult.Location = new System.Drawing.Point(14, 343);
            this.groupBoxImgResult.Name = "groupBoxImgResult";
            this.groupBoxImgResult.Size = new System.Drawing.Size(592, 535);
            this.groupBoxImgResult.TabIndex = 19;
            this.groupBoxImgResult.TabStop = false;
            this.groupBoxImgResult.Text = "RESULTADO DA IMAGEM";
            // 
            // pictureBoxFailure
            // 
            this.pictureBoxFailure.Image = global::FODFailureLogAutomation.Properties.Resources.Default;
            this.pictureBoxFailure.Location = new System.Drawing.Point(6, 78);
            this.pictureBoxFailure.Name = "pictureBoxFailure";
            this.pictureBoxFailure.Size = new System.Drawing.Size(580, 452);
            this.pictureBoxFailure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFailure.TabIndex = 7;
            this.pictureBoxFailure.TabStop = false;
            // 
            // labelFingerName
            // 
            this.labelFingerName.AutoSize = true;
            this.labelFingerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFingerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelFingerName.Location = new System.Drawing.Point(189, 15);
            this.labelFingerName.Name = "labelFingerName";
            this.labelFingerName.Size = new System.Drawing.Size(0, 22);
            this.labelFingerName.TabIndex = 21;
            // 
            // comboBoxFailurePictures
            // 
            this.comboBoxFailurePictures.FormattingEnabled = true;
            this.comboBoxFailurePictures.Location = new System.Drawing.Point(8, 45);
            this.comboBoxFailurePictures.Name = "comboBoxFailurePictures";
            this.comboBoxFailurePictures.Size = new System.Drawing.Size(578, 28);
            this.comboBoxFailurePictures.TabIndex = 19;
            this.comboBoxFailurePictures.SelectedIndexChanged += new System.EventHandler(this.comboBoxFailurePictures_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Silver;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(298, 192);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(302, 42);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelDeveloperName
            // 
            this.labelDeveloperName.AutoSize = true;
            this.labelDeveloperName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloperName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelDeveloperName.Location = new System.Drawing.Point(12, 882);
            this.labelDeveloperName.Name = "labelDeveloperName";
            this.labelDeveloperName.Size = new System.Drawing.Size(321, 20);
            this.labelDeveloperName.TabIndex = 21;
            this.labelDeveloperName.Text = "Developed by Matheus Paiva/A.Patricio";
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(16, 248);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(146, 24);
            this.labelDirectory.TabIndex = 22;
            this.labelDirectory.Text = "Diretório do Log";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(14, 269);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(472, 26);
            this.textBoxDirectory.TabIndex = 23;
            this.textBoxDirectory.Text = "V:\\CAMERA_FAIL_DATA\\FOD";
            // 
            // buttonDirectory
            // 
            this.buttonDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirectory.Location = new System.Drawing.Point(554, 269);
            this.buttonDirectory.Name = "buttonDirectory";
            this.buttonDirectory.Size = new System.Drawing.Size(46, 35);
            this.buttonDirectory.TabIndex = 24;
            this.buttonDirectory.Text = "...";
            this.buttonDirectory.UseVisualStyleBackColor = true;
            this.buttonDirectory.Click += new System.EventHandler(this.buttonDirectory_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBoxLogo.Image = global::FODFailureLogAutomation.Properties.Resources.LogoFlex;
            this.pictureBoxLogo.Location = new System.Drawing.Point(21, 17);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(580, 148);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelSearching
            // 
            this.labelSearching.AutoSize = true;
            this.labelSearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearching.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelSearching.Location = new System.Drawing.Point(298, 242);
            this.labelSearching.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearching.Name = "labelSearching";
            this.labelSearching.Size = new System.Drawing.Size(0, 22);
            this.labelSearching.TabIndex = 25;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1892, 906);
            this.Controls.Add(this.labelSearching);
            this.Controls.Add(this.buttonDirectory);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.labelDeveloperName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxImgResult);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelTrackId);
            this.Controls.Add(this.textBoxTrackId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOD FailureLog Automation  V1.0";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControlFinger.ResumeLayout(false);
            this.TabEgis.ResumeLayout(false);
            this.groupBoxEgis.ResumeLayout(false);
            this.groupBoxEgis.PerformLayout();
            this.TabGodix.ResumeLayout(false);
            this.groupBoxGodix.ResumeLayout(false);
            this.groupBoxGodix.PerformLayout();
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
        public System.Windows.Forms.Label labelDeveloperName;
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
        public System.Windows.Forms.GroupBox groupBoxEgis;
        public System.Windows.Forms.GroupBox groupBoxGodix;
        public System.Windows.Forms.ListBox listBoxMeasCode2;
        public System.Windows.Forms.Label labelMeasResult;
        public System.Windows.Forms.Label labelMeasDescription;
        public System.Windows.Forms.Label labelMeasCode2;
        public System.Windows.Forms.ListBox listBoxMeasResult;
        public System.Windows.Forms.ListBox listBoxMeasDescription;
        private System.Windows.Forms.Label labelSearching;
    }
}

