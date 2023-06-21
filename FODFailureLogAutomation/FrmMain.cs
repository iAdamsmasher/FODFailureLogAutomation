using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace FODFailureLogAutomation
{
    public partial class FrmMain : Form
    {
        string strPathDefault = @"C:\prod\temp\";
        string strLogFileName = "inline_log.txt";
        string strTrackIdErrorMsg = "TrackId Not Found!!!";
        string strTictureViewErrorMsg = "Error to load the Picture view!";
        string strPicturePattern = "*.bmp*";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxTrackId.TextLength != 10)
            {
                MessageBox.Show("TrackId Inválido", "TrackId - ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTrackId.Text = "";
            }
            else
            {
                getFailureLog();
                getPicture();
            }
        }
        private void getFailureLog()
        {
            try
            {
                foreach (string file_name in Directory.GetFiles(strPathDefault + textBoxTrackId.Text + @"\", strLogFileName, SearchOption.AllDirectories))
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
            }
            catch
            {
                MessageBox.Show(strTrackIdErrorMsg);
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
                foreach (string pictureName in Directory.GetFiles(strPathDefault + textBoxTrackId.Text + @"\", strPicturePattern, SearchOption.AllDirectories))
                {
                    comboBoxFailurePictures.Items.Add(pictureName);
                }
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
                MessageBox.Show(strTictureViewErrorMsg);
            }
        }
    }
}
