﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace FODFailureLogAutomation
{
    public partial class FrmMain : Form
    {

        string strPictureViewErrorMsg = "Error to load the Picture view!";
        LogManager logManager;
        private static FrmMain INSTANCE = null;

        public FrmMain()
        {
            INSTANCE = this;
            InitializeComponent();
        }
        public static FrmMain getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new FrmMain();

            return INSTANCE;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            defineProgressBar();
            logManager = new LogManager();
            logManager.clearAllLog();
            if (textBoxTrackId.TextLength != 10)
            {
                MessageBox.Show("TrackId Inválido", "TrackId - ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTrackId.Text = "";
            }
            else
            {
                labelSearching.Text = "Searching......";
                Application.DoEvents();
                bool result = logManager.getPictureLog();
                if (!result)
                {
                    MessageBox.Show("Error to search Log Failures");
                    labelSearching.Text = "Log NOT found!!!!";
                }
                labelSearching.Text = "Log found!!!!";
            }
        }
        public void progressBarUpDate(int value)
        {
            if (progressBarTrackId.Value == 100)
            {

            }
            else
                progressBarTrackId.Value += value;
        }
        public void defineProgressBar()
        {
            progressBarTrackId.Minimum = 0;
            progressBarTrackId.Maximum = 100;
            progressBarTrackId.Value = 0;
        }

        private void comboBoxFailurePictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pictureName = string.Empty;
            pictureName = comboBoxFailurePictures.SelectedItem.ToString();
            fingerDetect(pictureName);
            setPictureName(pictureName);
        }
        private void setPictureName(string pictureName)
        {
            try
            {
                pictureBoxFailure.Image = Image.FromFile(pictureName);
            }
            catch
            {
                MessageBox.Show(strPictureViewErrorMsg);
            }
        }
        private void fingerDetect(string pictureName)
        {

            if (pictureName.Contains("_mss_hbm_") || pictureName.Contains("_mss_wk") || pictureName.Contains("_sp_hbm_") || pictureName.Contains("_sp_wk") || pictureName.Contains("_testpattern_") || pictureName.Contains("_wk_bk"))
                labelFingerName.Text = "FINGER 1 (FLASH)";

            else if (pictureName.Contains("_bp_map_") || pictureName.Contains("_fea_bk") || pictureName.Contains("_fea_mask_") || pictureName.Contains("_fea_v2_mask_") || pictureName.Contains("_snr_bk_") || pictureName.Contains("_sp_bk") || pictureName.Contains("_mss_bk") || pictureName.Contains("_mss_ct"))
                labelFingerName.Text = "FINGER 2 (BLACK)";

            else if (pictureName.Contains("_snr_ct") || pictureName.Contains("_snr_bk"))
                labelFingerName.Text = "FINGER 3 (DIGITAL)";

            else
                labelFingerName.Text = "FINGER X";
        }
        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
