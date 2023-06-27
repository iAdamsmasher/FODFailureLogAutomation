
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
        string strGodixPattern = "*.csv*";

        FrmMain frmMn = FrmMain.getInstance();
        public string FingerModel { get; set; }
        public bool getFailureLogEgis()
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
                            linkLogWithBoxesEgis(line);
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
        public bool getFailureLogGodix()
        {
            try
            {
                foreach (string file_name in Directory.GetFiles(frmMn.textBoxDirectory.Text + "\\" + frmMn.textBoxTrackId.Text + "\\", strGodixPattern, SearchOption.AllDirectories))
                {
                    using (var reader = new StreamReader(file_name))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("Fail,0x"))
                                linkLogWithBoxesGodix(line);
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
        public void linkLogWithBoxesEgis(string line)
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
        public void linkLogWithBoxesGodix(string line)
        {
            string[] tempVecna = line.Split(',');
            string LogFailureCode = tempVecna[2];

            using (var GodixParameters = new StreamReader("ParametersGodix.csv"))
            {
                string lineParameter;
                while ((lineParameter = GodixParameters.ReadLine()) != null)
                {
                    if (lineParameter.Contains(LogFailureCode))
                    {
                        string[] description = lineParameter.Split(';');
                        frmMn.listBoxMeasCode2.Items.Add(description[1]);
                        frmMn.listBoxMeasDescription.Items.Add(description[2]);
                        frmMn.listBoxMeasResult.Items.Add(description[3]);
                    }
                }
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
            frmMn.listBoxMeasCode2.Items.Clear();
            frmMn.listBoxMeasDescription.Items.Clear();
            frmMn.listBoxMeasResult.Items.Clear();
        }
        public bool getPictureLog()
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

                if (pictureModelCheck == "Egis")
                {
                    getFailureLogEgis();
                    frmMn.tabControlFinger.SelectedIndex = 0;
                }

                if (pictureModelCheck == "Godix")
                {
                    frmMn.tabControlFinger.SelectedIndex = 1;
                    Application.DoEvents();
                    getFailureLogGodix();
                }

                return true;

            }
            catch
            {
                MessageBox.Show(strTrackIdErrorMsg);
                frmMn.pictureBoxFailure.Image = Properties.Resources.Default;
                return false;
            }
        }
    }
}
