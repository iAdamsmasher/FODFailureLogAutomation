using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace FODFailureLogAutomation
{
    public partial class FrmMain : Form
    {
        string strLogFileName = "inline_log.txt";
        string strTrackIdErrorMsg = "TrackId Not Found!!!";
        string strPictureViewErrorMsg = "Error to load the Picture view!";
        string strPicturePattern = "*.bmp*";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            clearAllLog();
            if (textBoxTrackId.TextLength != 10)
            {
                MessageBox.Show("TrackId Inválido", "TrackId - ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTrackId.Text = "";
            }
            else
            {
                bool result = getFailureLog();

                if (result)
                    getPicture();
            }
        }
        private bool getFailureLog()
        {
            try
            {
                foreach (string file_name in Directory.GetFiles(textBoxDirectory.Text + "\\" + textBoxTrackId.Text + "\\", strLogFileName, SearchOption.AllDirectories))
                {
                    using (var reader = new StreamReader(file_name))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            linkLogWithBoxes(line);
                        }
                    }
                }
                return true;
            }
            catch
            {
                MessageBox.Show(strTrackIdErrorMsg);
                textBoxTrackId.Text = "";
                return false;
            }
        }
        private void linkLogWithBoxes(string line)
        {
            if (line.Contains("[MMI_RESULT]") && line.Contains("failed"))
            {
                listBoxMeasCode.Items.Add(line);
            }
            if (line.Contains("TH:["))
            {
                line = line.Replace("[MMI_TH]", "");
                listBoxSpecsLimit.Items.Add(line);
            }
            if (line.Contains("[MMI_Calibraiton]"))
            {
                line = line.Replace("[MMI_Calibraiton]", "");
                if (!line.Contains("Calibration Test Result:fail"))
                    listBoxResultFailure.Items.Add(line);
            }
        }
        private void getPicture()
        {
            try
            {
                string pictureModelCheck = "Godix";
                foreach (string pictureName in Directory.GetFiles(textBoxDirectory.Text + "\\" + textBoxTrackId.Text + "\\", strPicturePattern, SearchOption.AllDirectories))
                {
                    comboBoxFailurePictures.Items.Add(pictureName);
                    pictureModelCheck = "Egis";
                }
                labelProvider.Text = pictureModelCheck;

            }
            catch
            {
                MessageBox.Show(strTrackIdErrorMsg);
            }
        }
        private void comboBoxFailurePictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pictureName = string.Empty;
            pictureName = comboBoxFailurePictures.SelectedItem.ToString();

            if (pictureName.Contains("_mss_hbm_") || pictureName.Contains("_mss_wk") || pictureName.Contains("_sp_hbm_") || pictureName.Contains("_sp_wk") || pictureName.Contains("_testpattern_") || pictureName.Contains("_wk_bk"))
                labelFingerName.Text = "FINGER 1";

            else if (pictureName.Contains("_bp_map_") || pictureName.Contains("_fea_bk") || pictureName.Contains("_fea_mask_") || pictureName.Contains("_fea_v2_mask_") || pictureName.Contains("_snr_bk_") || pictureName.Contains("_sp_bk"))
                labelFingerName.Text = "FINGER 2";

            else if (pictureName.Contains("_snr_ct"))
                labelFingerName.Text = "FINGER 3";
           
            else
                labelFingerName.Text = "FINGER X";



            setPictureName(pictureName);
        }
        private void clearAllLog()
        {
            listBoxMeasCode.Items.Clear();
            listBoxSpecsLimit.Items.Clear();
            listBoxResultFailure.Items.Clear();
            comboBoxFailurePictures.Items.Clear();


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

        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
