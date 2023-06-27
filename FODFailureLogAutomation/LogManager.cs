
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FODFailureLogAutomation
{
    class LogManager
    {
        string strLogFileName = "inline_log.txt";
        string strTrackIdErrorMsg = "TrackId Not Found!!!";
        string strPicturePattern = "*.bmp*";
        FrmMain frmMn = FrmMain.getInstance();
        public bool getFailureLog()
        {
            try
            {
                foreach (string file_name in Directory.GetFiles(frmMn.textBoxDirectory.Text + "\\" + frmMn.textBoxTrackId.Text + "\\", strLogFileName, SearchOption.AllDirectories))
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
                frmMn.textBoxTrackId.Text = "";
                return false;
            }
        }
        public void linkLogWithBoxes(string line)
        {
            if (line.Contains("[MMI_RESULT]") && line.Contains("failed"))
            {
                frmMn.listBoxMeasCode.Items.Add(line);
            }
            if (line.Contains("TH:["))
            {
                line = line.Replace("[MMI_TH]", "");
                frmMn.listBoxSpecsLimit.Items.Add(line);
            }
            if (line.Contains("[MMI_Calibraiton]"))
            {
                line = line.Replace("[MMI_Calibraiton]", "");
                if (!line.Contains("Calibration Test Result:fail"))
                    frmMn.listBoxResultFailure.Items.Add(line);
            }
        }
        public void clearAllLog()
        {
            frmMn.listBoxMeasCode.Items.Clear();
            frmMn.listBoxSpecsLimit.Items.Clear();
            frmMn.listBoxResultFailure.Items.Clear();
            frmMn.comboBoxFailurePictures.Items.Clear();
            frmMn.comboBoxFailurePictures.Text = "";
            frmMn.pictureBoxFailure.Image = Properties.Resources.Default;
            frmMn.labelFingerName.Text = "";
        }
        public void getPictureLog()
        {
            try
            {
                string pictureModelCheck = "Godix";
                foreach (string pictureName in Directory.GetFiles(frmMn.textBoxDirectory.Text + "\\" + frmMn.textBoxTrackId.Text + "\\", strPicturePattern, SearchOption.AllDirectories))
                {
                    frmMn.comboBoxFailurePictures.Items.Add(pictureName);
                    pictureModelCheck = "Egis";
                }
                frmMn.labelProvider.Text = pictureModelCheck;
                if (pictureModelCheck == "Godix")
                    frmMn.tabControlFinger.SelectedIndex = 1;
                Application.DoEvents();
            }
            catch
            {
                MessageBox.Show(strTrackIdErrorMsg);
                frmMn.pictureBoxFailure.Image = Properties.Resources.Default;
            }
        }

    }
}
