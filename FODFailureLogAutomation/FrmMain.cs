using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FODFailureLogAutomation
{
    public partial class FrmMain : Form
    {
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
                textBoxTrackIdSearched.Text = textBoxTrackId.Text;
                getFailureLog();
            }
        }
        private void getFailureLog()
        {
            string pathDefault = @"C:\prod\temp\" + textBoxTrackId.Text + @"\";
            string fileName = "inline_log.txt";

            try
            {
                foreach (string file_name in Directory.GetFiles(pathDefault, fileName, System.IO.SearchOption.AllDirectories))
                {
                    using (var reader = new StreamReader(file_name))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("fail"))
                            {
                                listBoxMeasCode.Items.Add(line);
                            }
                            if (line.Contains("[MMI_Calibraiton] Calibration Test Result:fail"))
                            {

                            }
                        }

                    }
                }
            }

            catch
            {
                MessageBox.Show("TrackId Not Found!!!");
            }
        }

    }
}
