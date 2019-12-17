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
using Subtitle_Maker.Classes;

namespace Subtitle_Maker.Forms
{
    public partial class CreateNewFile : Form
    {
        SubtitleMaker subtitleMaker = new SubtitleMaker();

        public string path;

        public CreateNewFile(SubtitleMaker subtitleMaker)
        {
            InitializeComponent();
            this.subtitleMaker = subtitleMaker;
        }

        private void CreateNewFile_Load(object sender, EventArgs e)
        {
            labelError1.Visible = false;
            labelError2.Visible = false;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            labelError1.Visible = false;
            labelError2.Visible = false;

            if (string.IsNullOrWhiteSpace(textBoxPath.Text) == true)
            {
                labelError1.Visible = true;
            }

            else if (Directory.Exists(textBoxPath.Text) == false)
            {
                MessageBox.Show("Location does not exist!");
            }

            if (string.IsNullOrWhiteSpace(textBoxName.Text) == true)
            {
                labelError2.Visible = true;
            }

            else if (Directory.Exists(textBoxPath.Text) == true)
            {
                path = textBoxPath.Text + "\\" + textBoxName.Text + ".srt";
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                    subtitleMaker.labelLocationsSubtitleLocationValue.Text = path;   //U labelu zapisat lokaciju
                    MessageBox.Show("File Created");

                    subtitleMaker.groupBoxAdd.Enabled = true;                       //Omogućit gb
                    subtitleMaker.SubtitlesList.Clear();                            //očistit listu
                    subtitleMaker.RefreshDataGridView();                            //refreshat dgv

                    Close();
                }

                else
                {
                    MessageBox.Show("File Already Exists");
                }
            }
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
