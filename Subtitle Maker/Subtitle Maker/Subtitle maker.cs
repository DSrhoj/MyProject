using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Subtitle_Maker.Classes;
using Subtitle_Maker.Forms;

namespace Subtitle_Maker
{
    public partial class SubtitleMaker : Form
    {
        public List<Subtitles> SubtitlesList = new List<Subtitles>();

        public SubtitleMaker()
        {
            InitializeComponent();
        }

        public void RefreshAll()
        {
            RefreshDataGridView();
            StreamToFile();
            RefreshSource();
        }

        public void RefreshDataGridView()
        {
            dataGridView.Rows.Clear();

            for (int i = 0; i < SubtitlesList.Count; i++)
            {
                dataGridView.Rows.Add(i + 1 + ".", SubtitlesList[i].StartTimeStringFormat, SubtitlesList[i].EndTimeStringFormat, SubtitlesList[i].Duration, SubtitlesList[i].Text);
            }
        }

        public void RefreshSource()
        {
            listBoxSourceView.Items.Clear();
            for (int i = 0; i < SubtitlesList.Count; i++)
            {
                listBoxSourceView.Items.Add(i + 1);
                listBoxSourceView.Items.Add(SubtitlesList[i].StartTimeStringFormat + " --> " + SubtitlesList[i].EndTimeStringFormat);

                string[] lines;
                lines = System.Text.RegularExpressions.Regex.Split(SubtitlesList[i].Text, "<br />");
                foreach (string line in lines)
                {
                    listBoxSourceView.Items.Add(line);
                }
                listBoxSourceView.Items.Add("");
            }
        }

        public void StreamToFile()
        {

            var stream = File.Create(@labelLocationsSubtitleLocationValue.Text);
            StreamWriter file = new StreamWriter(stream, Encoding.UTF8);

            for (int i = 0; i < SubtitlesList.Count; i++)
            {
                file.WriteLine(i + 1);
                file.WriteLine(SubtitlesList[i].StartTimeStringFormat + " --> " + SubtitlesList[i].EndTimeStringFormat);
                if (SubtitlesList[i].Text.Contains("<br />") == true)
                {
                    file.WriteLine(SubtitlesList[i].Text.Replace("<br />", "\r\n"));
                }
                else
                {
                    file.WriteLine(SubtitlesList[i].Text);
                }
                file.WriteLine();
            }
            file.Close();
            stream.Close();
        }

        public void StreamFromFile()
        {
            string[] lines = File.ReadAllLines(@labelLocationsSubtitleLocationValue.Text);
            string BothTimes = "";
            string Text = "";

            for (int i = 0; i < lines.Length; i++)
            {
                Text = "";

                if (lines[i] == (SubtitlesList.Count + 1).ToString())
                {
                    i += 1;
                    BothTimes = lines[i];

                    while (i + 1 != lines.Length && lines[i + 1] != (SubtitlesList.Count + 2).ToString())
                    {
                        i++;

                        if (string.IsNullOrWhiteSpace(Text) == true)
                        {
                            Text = lines[i];
                        }

                        else if (string.IsNullOrWhiteSpace(lines[i]) == false)
                        {
                            Text += "<br />" + lines[i];
                        }

                        else if (IsRestOfListEmpty(lines, i) == true)
                        {
                            break;
                        }

                        else if (i + 1 != lines.Length && lines[i + 1] != (SubtitlesList.Count + 2).ToString())
                        {
                            Text += "<br />";
                        }
                    }

                    Subtitles subtitle = new Subtitles(Text, CalculateStartTimeFromLine(BothTimes), CalculateEndTimeFromLine(BothTimes));
                    SubtitlesList.Add(subtitle);
                }
            }
        }

        public string CalculateStartTimeFromLine(string BothTimes)
        {
            string firstTime;

            firstTime = BothTimes.Substring(0, 12);

            return firstTime;
        }

        public string CalculateEndTimeFromLine(string BothTimes)
        {
            string secondTime;
            int ArrowIndex;

            ArrowIndex = BothTimes.IndexOf("-->");
            secondTime = BothTimes.Substring(ArrowIndex + 4, 12);

            return secondTime;
        }

        public static bool IsRestOfListEmpty(string[] lines, int index)
        {
            int br = 0;
            for (int i = 0; i < (lines.Length - index - 1); i++)
            {
                if (string.IsNullOrWhiteSpace(lines[index + i]) == false)
                {
                    br++;
                }
            }

            if (br == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetDirectory(string location)
        {
            return location.Remove(location.LastIndexOf("\\") + 1, (location.Length - location.LastIndexOf("\\") - 1));
        }

        public void CheckStartEndTimeColorAdd()
        {
            if (maskedTextBoxAddStartTime.MaskFull == true && labelAddStartTime.ForeColor == Color.Firebrick)
            {
                labelAddStartTime.Text = labelAddStartTime.Text.Replace(" *", "");
                labelAddStartTime.ForeColor = SystemColors.ControlText;
                labelAddError.Visible = false;
            }

            if (maskedTextBoxAddEndTime.MaskFull == true && labelAddEndTime.ForeColor == Color.Firebrick)
            {
                labelAddEndTime.Text = labelAddEndTime.Text.Replace(" *", "");
                labelAddEndTime.ForeColor = SystemColors.ControlText;
                labelAddError.Visible = false;
            }
        }

        public void CheckTextColorAdd()
        {
            if (string.IsNullOrEmpty(labelAddText.Text) == false && labelAddText.ForeColor == Color.Firebrick)
            {
                labelAddText.Text = labelAddText.Text.Replace(" *", "");
                labelAddText.ForeColor = SystemColors.ControlText;
                labelAddError.Visible = false;
            }
        }

        public void CheckStartEndTimeColorEdit()
        {
            if (maskedTextBoxEditStartTime.MaskFull == true && labelEditStartTime.ForeColor == Color.Firebrick)
            {
                labelEditStartTime.Text = labelEditStartTime.Text.Replace(" *", "");
                labelEditStartTime.ForeColor = SystemColors.ControlText;
            }

            if (maskedTextBoxEditEndTime.MaskFull == true && labelEditEndTime.ForeColor == Color.Firebrick)
            {
                labelEditEndTime.Text = labelEditEndTime.Text.Replace(" *", "");
                labelEditEndTime.ForeColor = SystemColors.ControlText;
            }
        }

        public void CheckTextColorEdit()
        {
            if (string.IsNullOrWhiteSpace(labelEditText.Text) == false && labelEditText.ForeColor == Color.Firebrick)
            {
                labelEditText.Text = labelEditText.Text.Replace(" *", ""); ;
                labelEditText.ForeColor = SystemColors.ControlText;
            }
        }

        public void CheckBiggerTimeEdit()
        {
            if (maskedTextBoxEditStartTime.MaskFull == true && maskedTextBoxEditEndTime.MaskFull == true && Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditStartTime.Text) <= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditEndTime.Text))
            {
                labelEditDurationValue.Text = Subtitles.CalculateDuration(Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditStartTime.Text), Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditEndTime.Text));
                labelEditDurationValue.ForeColor = SystemColors.ControlText;
            }

            else if (maskedTextBoxEditStartTime.MaskFull == false || maskedTextBoxEditEndTime.MaskFull == false)
            {

            }

            else
            {
                labelEditDurationValue.Text = "Start time is bigger than end time!";
                labelEditDurationValue.ForeColor = Color.Firebrick;
            }
        }

        public void CheckBiggerTimeAdd()
        {
            if (maskedTextBoxAddStartTime.MaskFull == true && maskedTextBoxAddEndTime.MaskFull == true && Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddStartTime.Text) <= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddEndTime.Text))
            {
                labelAddDurationValue.Text = Subtitles.CalculateDuration(Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddStartTime.Text), Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddEndTime.Text));
                labelAddDurationValue.ForeColor = SystemColors.ControlText;
            }

            else if (maskedTextBoxAddStartTime.MaskFull == false || maskedTextBoxAddEndTime.MaskFull == false)
            {

            }

            else
            {
                labelAddDurationValue.Text = "Start time is bigger than end time!";
                labelAddDurationValue.ForeColor = Color.Firebrick;
            }
        }

        private void SubtitleMaker_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            groupBoxEdit.Enabled = false;
            groupBoxAdd.Enabled = false;
            labelAddError.Visible = false;
            undotoolStripMenuItem.Enabled = false;
            findtoolStripMenuItem.Enabled = false;
            replacetoolStripMenuItem.Enabled = false;
            multiplereplacetoolStripMenuItem.Enabled = false;
            gotosubtitlenumbertoolStripMenuItem.Enabled = false;
            buttonEditAutobr.Enabled = false;
            buttonPlayerPanel.Enabled = false;
            buttonPlayer025sBackward.Enabled = false;
            buttonPlayer025sForward.Enabled = false;
            buttonPlayer1sBackward.Enabled = false;
            buttonPlayer1sForwards.Enabled = false;
            buttonPlayer5sBackward.Enabled = false;
            buttonPlayer5sForwards.Enabled = false;
            buttonPlayerMoveCurrentTimeFor.Enabled = false;
            radioButtonPlayerBackward.Enabled = false;
            radioButtonPlayerForward.Enabled = false;
            maskedTextBoxPlayer.Enabled = false;
            buttonPlayerPlayPause.Enabled = false;
            buttonPlayerStop.Enabled = false;
            buttonPlayerMute.Enabled = false;
            buttonPlayerVolUp.Enabled = false;
            buttonPlayerVolDown.Enabled = false;
            timer.Enabled = false;

        }



        //
        //timer
        //
        private void timer_Tick(object sender, EventArgs e)
        {
            int index = 0;

            while (index < SubtitlesList.Count && (SubtitlesList[index].StartTimeDoubleFormat > axWindowsMediaPlayer.Ctlcontrols.currentPosition || axWindowsMediaPlayer.Ctlcontrols.currentPosition > SubtitlesList[index].EndTimeDoubleFormat))
            {
                index++;
            }
            if (index < SubtitlesList.Count)
            {
                labelPlayerSubtitlePreview.Text = SubtitlesList[index].Text.Replace("<br />", "\n");
            }
            else
            {
                labelPlayerSubtitlePreview.Text = "";
            }
        }

        //
        //tool strip
        //

        //
        //file
        //
        private void newToolStripMenuItem_Click(object sender, EventArgs e)         //creates "create new file" form
        {
            CreateNewFile createNewFile = new CreateNewFile(this);
            createNewFile.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)            //opens file dialog 
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = ".str files (*.srt)|*.srt|All files (*.*)|*.*";         //filter file extensions

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelLocationsSubtitleLocationValue.Text = openFileDialog.FileName;
                groupBoxAdd.Enabled = true;
                SubtitlesList.Clear();
                StreamFromFile();
                RefreshDataGridView();
                RefreshSource();
                timer.Enabled = true;
            }
        }

        private void subtitlesToolStripMenuItem_Click(object sender, EventArgs e)           //opens subtitile file location folder
        {
            if (File.Exists(labelLocationsSubtitleLocationValue.Text) == true)
            {
                Process.Start(@GetDirectory(labelLocationsSubtitleLocationValue.Text));
            }
            else
            {
                MessageBox.Show("You have to choose file first!");
            } 
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)           //opens video file location folder
        {
            if (File.Exists(labelLocationsVideoLocationValue.Text) == true)
            {
                Process.Start(@GetDirectory(labelLocationsVideoLocationValue.Text));
            }
            else
            {
                MessageBox.Show("You have to choose file first!");
            }
        }

        private void loadVideoToolStripMenuItem_Click(object sender, EventArgs e)           //opens video file
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "MP4 files (*.mp4)|*.mp4|AVI files (*.avi)|*.avi|MOV files (*.mov)|*.mov|WMV files (*.wmv)|*.wmv|All files (*.*)|*.*";          //filter file extensions

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer.URL = openFileDialog.FileName;
                labelLocationsVideoLocationValue.Text = openFileDialog.FileName;

                buttonPlayerPanel.Enabled = true;
                buttonPlayer025sBackward.Enabled = true;
                buttonPlayer025sForward.Enabled = true;
                buttonPlayer1sBackward.Enabled = true;
                buttonPlayer1sForwards.Enabled = true;
                buttonPlayer5sBackward.Enabled = true;
                buttonPlayer5sForwards.Enabled = true;
                buttonPlayerMoveCurrentTimeFor.Enabled = true;
                radioButtonPlayerBackward.Enabled = true;
                radioButtonPlayerForward.Enabled = true;
                maskedTextBoxPlayer.Enabled = true;
                buttonPlayerPlayPause.Enabled = true;
                buttonPlayerStop.Enabled = true;
                buttonPlayerMute.Enabled = true;
                buttonPlayerVolUp.Enabled = true;
                buttonPlayerVolDown.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        //edit
        //
        private void undotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonEditUndoChanges_Click(sender, e);
        }

        private void findtoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findnexttoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replacetoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void multiplereplacetoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gotosubtitlenumbertoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //
        //player
        //
        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)         //something was used in panel
        {
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                buttonPlayerPlayPause.Text = "Pause";
            }

            else
            {
                buttonPlayerPlayPause.Text = "Play";
            }
        }

        private void buttonPlayerPlay_Click(object sender, EventArgs e)
        {
            if (buttonPlayerPlayPause.Text == "Pause")
            {
                axWindowsMediaPlayer.Ctlcontrols.pause();
                buttonPlayerPlayPause.Text = "Play";
            }

            else
            {
                axWindowsMediaPlayer.Ctlcontrols.play();
                buttonPlayerPlayPause.Text = "Pause";
            }

        }

        private void buttonPlayerStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void buttonPlayerMute_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.settings.mute == true)
            {
                axWindowsMediaPlayer.settings.mute = false;
                buttonPlayerMute.Text = "Mute";
            }

            else if (axWindowsMediaPlayer.settings.mute == false)
            {
                axWindowsMediaPlayer.settings.mute = true;
                buttonPlayerMute.Text = "Unmut";
            }
        }

        private void buttonPlayerVolUp_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.settings.volume++;
            buttonPlayerMute.Text = "Mute";
        }

        private void buttonPlayerVolDown_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.settings.volume--;
            buttonPlayerMute.Text = "Mute";
        }

        private void buttonPlayerPanel_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.uiMode == "none")
            {
                axWindowsMediaPlayer.uiMode = "full";
                buttonPlayerPanel.Text = "Hide panel";
            }

            else if (axWindowsMediaPlayer.uiMode == "full")
            {
                axWindowsMediaPlayer.uiMode = "none";
                buttonPlayerPanel.Text = "Show panel";
            }
        }

        private void buttonPlayer5sBackward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.currentPosition -= 5;
        }

        private void buttonPlayer1sBackward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.currentPosition -= 1;
        }

        private void buttonPlayer025sBackward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.currentPosition -= 0.25;
        }

        private void buttonPlayer025sForward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.currentPosition += 0.25;
        }

        private void buttonPlayer1sForwards_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.currentPosition += 1;
        }

        private void buttonPlayer5sForwards_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.currentPosition += 5;
        }

        private void buttonPlayerMoveCurrentTimeFor_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlayer.MaskFull == false)
            {
                MessageBox.Show("You have to fill the box!");
            }

            else if (radioButtonPlayerBackward.Checked == true && maskedTextBoxPlayer.MaskFull == true)
            {
                axWindowsMediaPlayer.Ctlcontrols.currentPosition -= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxPlayer.Text);
            }

            else if (radioButtonPlayerForward.Checked == true && maskedTextBoxPlayer.MaskFull == true)
            {
                axWindowsMediaPlayer.Ctlcontrols.currentPosition += Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxPlayer.Text);
            }
        }

        private void buttonPlayerLoadVideo_Click(object sender, EventArgs e)
        {
            loadVideoToolStripMenuItem_Click(sender, e);
        }

        //
        //locations
        //
        private void buttonLocationsOpenInFolderSubtitles_Click(object sender, EventArgs e)
        {
            subtitlesToolStripMenuItem_Click(sender, e);
        }

        private void buttonLocationsOpenInFolderVideo_Click(object sender, EventArgs e)
        {
            videoToolStripMenuItem_Click(sender, e);
        }

        //
        //add
        //
        private void buttonAddPickCurrentStartTime_Click(object sender, EventArgs e)
        {
            maskedTextBoxAddStartTime.Text = Subtitles.TimeDoubleFormatToTimeStringFormat(axWindowsMediaPlayer.Ctlcontrols.currentPosition);
        }

        private void maskedTextBoxAddEndTime_TextChanged(object sender, EventArgs e)
        {
            CheckBiggerTimeAdd();
            CheckStartEndTimeColorAdd();
        }

        private void buttonAddPickCurrentEndTime_Click(object sender, EventArgs e)
        {
            maskedTextBoxAddEndTime.Text = Subtitles.TimeDoubleFormatToTimeStringFormat(axWindowsMediaPlayer.Ctlcontrols.currentPosition);
        }

        private void maskedTextBoxAddStartTime_TextChanged(object sender, EventArgs e)
        {
            CheckBiggerTimeAdd();
            CheckStartEndTimeColorAdd();
        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {
            CheckTextColorAdd();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            int br = 0;

            if (maskedTextBoxAddStartTime.MaskFull == false || maskedTextBoxAddEndTime.MaskFull == false || string.IsNullOrWhiteSpace(textBoxAdd.Text) == true)
            {
                if (maskedTextBoxAddStartTime.MaskFull == false && labelAddStartTime.ForeColor != Color.Firebrick)
                {
                    labelAddError.Visible = true;
                    labelAddStartTime.Text = labelAddStartTime.Text + " *";
                    labelAddStartTime.ForeColor = Color.Firebrick;
                }

                if (maskedTextBoxAddEndTime.MaskFull == false && labelAddEndTime.ForeColor != Color.Firebrick)
                {
                    labelAddError.Visible = true;
                    labelAddEndTime.Text = labelAddEndTime.Text + " *";
                    labelAddEndTime.ForeColor = Color.Firebrick;
                }

                if (string.IsNullOrWhiteSpace(textBoxAdd.Text) == true && labelAddText.ForeColor != Color.Firebrick)
                {
                    labelAddError.Visible = true;
                    labelAddText.Text = labelAddText.Text + " *";
                    labelAddText.ForeColor = Color.Firebrick;
                }
            }

            else if (Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddStartTime.Text) > Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddEndTime.Text))
            {

            }

            else if (SubtitlesList.Count == 0 || SubtitlesList[SubtitlesList.Count - 1].EndTimeDoubleFormat <= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddStartTime.Text))
            {
                Subtitles subtitle = new Subtitles(textBoxAdd.Text, maskedTextBoxAddStartTime.Text, maskedTextBoxAddEndTime.Text);
                SubtitlesList.Add(subtitle);
                RefreshAll();
            }

            else if (SubtitlesList[0].StartTimeDoubleFormat >= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddEndTime.Text))
            {
                Subtitles subtitle = new Subtitles(textBoxAdd.Text, maskedTextBoxAddStartTime.Text, maskedTextBoxAddEndTime.Text);
                SubtitlesList.Insert(0, subtitle);
                RefreshAll();
            }

            else
            {
                for (int i = 0; i < SubtitlesList.Count; i++)
                {
                    if (SubtitlesList[i].EndTimeDoubleFormat <= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddStartTime.Text) && Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddEndTime.Text) <= SubtitlesList[i + 1].StartTimeDoubleFormat && Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddStartTime.Text) <= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxAddEndTime.Text))
                    {
                        Subtitles subtitle = new Subtitles(textBoxAdd.Text, maskedTextBoxAddStartTime.Text, maskedTextBoxAddEndTime.Text);
                        SubtitlesList.Insert(i + 1, subtitle);
                        RefreshAll();
                        br++;
                        break;
                    }
                }

                if (br == 0)
                {
                    MessageBox.Show("There is a subtitle in selected time interval");
                }
            }
        }

        //
        //edit
        //
        public void dataGridView_SelectionChanged(object sender, EventArgs e)           //if selection changed refreshs edit group box
        {
            if (dataGridView.CurrentRow.Selected == true)           //if something is selected
            {
                groupBoxEdit.Enabled = true;
                undotoolStripMenuItem.Enabled = true;
                if (SubtitlesList[dataGridView.CurrentRow.Index].Text.Contains("<br />") == true)
                {
                    textBoxEdit.Text = SubtitlesList[dataGridView.CurrentRow.Index].Text.Replace("<br />", "\r\n");
                    SubtitlesList[dataGridView.CurrentRow.Index].Text.Remove(SubtitlesList[dataGridView.CurrentRow.Index].Text.IndexOf(@"<br />"), 5);
                }
                else
                {
                    textBoxEdit.Text = SubtitlesList[dataGridView.CurrentRow.Index].Text;
                }
                maskedTextBoxEditStartTime.Text = SubtitlesList[dataGridView.CurrentRow.Index].StartTimeStringFormat;
                maskedTextBoxEditEndTime.Text = SubtitlesList[dataGridView.CurrentRow.Index].EndTimeStringFormat;
                labelEditDurationValue.Text = SubtitlesList[dataGridView.CurrentRow.Index].Duration;
                labelEditSubtitleIndexValue.Text = (dataGridView.CurrentRow.Index + 1).ToString();
            }

            else           //if nothing is selected
            {
                groupBoxEdit.Enabled = false;
                undotoolStripMenuItem.Enabled = false;
                textBoxEdit.Text = "";
                maskedTextBoxEditStartTime.Text = "000000000";
                maskedTextBoxEditEndTime.Text = "000000000";
                labelEditDurationValue.Text = "00:00:00.000";
                labelEditSubtitleIndexValue.Text = "not selected";
            }
        }

        private void buttonEditPrev_Click(object sender, EventArgs e)           //moves selected index for one backward
        {
            if (dataGridView.CurrentCell.RowIndex > 0)
            {
                dataGridView.CurrentCell = dataGridView[0, dataGridView.CurrentCell.RowIndex - 1];
                dataGridView_SelectionChanged(sender, e);
            }
            else if (dataGridView.CurrentCell.RowIndex == 0)
            {
                dataGridView.CurrentCell = dataGridView[0, dataGridView.RowCount - 1];
                dataGridView_SelectionChanged(sender, e);
            }
        }

        private void buttonEditNext_Click(object sender, EventArgs e)           //moves selected index for one forward
        {
            if (dataGridView.CurrentCell.RowIndex < dataGridView.RowCount - 1)
            {
                dataGridView.CurrentCell = dataGridView[0, dataGridView.CurrentCell.RowIndex + 1];
                dataGridView_SelectionChanged(sender, e);
            }
            else if (dataGridView.CurrentCell.RowIndex == dataGridView.RowCount - 1)
            {
                dataGridView.CurrentCell = dataGridView[0, 0];
                dataGridView_SelectionChanged(sender, e);
            }
        }

        private void buttonEditPickCurrentStartTime_Click(object sender, EventArgs e)
        {
            maskedTextBoxEditStartTime.Text = Subtitles.TimeDoubleFormatToTimeStringFormat(axWindowsMediaPlayer.Ctlcontrols.currentPosition);
        }
        private void maskedTextBoxEditStartTime_TextChanged(object sender, EventArgs e)
        {
            CheckBiggerTimeEdit();          //checks if start time is bigger than end time
            CheckStartEndTimeColorEdit();           //checks color of label
        }

        private void buttonEditPickCurrentEndTime_Click(object sender, EventArgs e)
        {
            maskedTextBoxEditEndTime.Text = Subtitles.TimeDoubleFormatToTimeStringFormat(axWindowsMediaPlayer.Ctlcontrols.currentPosition);
        }

        private void maskedTextBoxEditEndTime_TextChanged(object sender, EventArgs e)
        {
            CheckBiggerTimeEdit();          //checks if start time is bigger than end time
            CheckStartEndTimeColorEdit();           //checks color of label
        }

        private void textBoxEdit_TextChanged(object sender, EventArgs e)
        {
            CheckTextColorEdit();
        }

        private void buttonEditDelete_Click(object sender, EventArgs e)         //deletes current row
        {
            SubtitlesList.RemoveAt(dataGridView.CurrentRow.Index);
            RefreshAll();
        }

        private void buttonEditUndoChanges_Click(object sender, EventArgs e)            //undo changes by calling selection change method
        {
            dataGridView_SelectionChanged(sender, e);
        }

        private void buttonEditSaveChanges_Click(object sender, EventArgs e)
        {
            int br = 0;

            if (maskedTextBoxEditStartTime.MaskFull == false || maskedTextBoxEditEndTime.MaskFull == false || string.IsNullOrWhiteSpace(textBoxEdit.Text) == true)          //checks if some box is empty and makes them red if yes
            {
                if (maskedTextBoxEditStartTime.MaskFull == false && labelEditStartTime.ForeColor != Color.Firebrick)
                {
                    labelEditStartTime.Text = labelEditStartTime.Text + " *";
                    labelEditStartTime.ForeColor = Color.Firebrick;
                }

                if (maskedTextBoxEditEndTime.MaskFull == false && labelEditEndTime.ForeColor != Color.Firebrick)
                {
                    labelEditEndTime.Text = labelAddEndTime.Text + " *";
                    labelEditEndTime.ForeColor = Color.Firebrick;
                }

                if (string.IsNullOrWhiteSpace(textBoxEdit.Text) == true && labelEditText.ForeColor != Color.Firebrick)
                {
                    labelEditText.Text = labelEditText.Text + " *";
                    labelEditText.ForeColor = Color.Firebrick;
                }
            }

            else if (Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditStartTime.Text) > Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditEndTime.Text))           //shows "start time is bigger than end time" and does nothing
            {

            }

           else if (dataGridView.Rows.Count == 1)
            {
                Subtitles subtitle;
                if (textBoxEdit.Text.Contains("\r\n") == true)
                {
                    subtitle = new Subtitles(textBoxEdit.Text.Replace("\r\n", "<br />"), maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                }
                else
                {
                    subtitle = new Subtitles(textBoxEdit.Text, maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                }

                SubtitlesList.RemoveAt(dataGridView.CurrentRow.Index);
                SubtitlesList.Insert(0, subtitle);
                RefreshAll();
            }

            else if (dataGridView.CurrentRow.Index == 0 && SubtitlesList[1].StartTimeDoubleFormat >= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditEndTime.Text))         //if first in data grid view and should come first
            {
                Subtitles subtitle;
                if (textBoxEdit.Text.Contains("\r\n") == true)
                {
                    subtitle = new Subtitles(textBoxEdit.Text.Replace("\r\n", "<br />"), maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                }
                else
                {
                    subtitle = new Subtitles(textBoxEdit.Text, maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                }

                SubtitlesList.RemoveAt(dataGridView.CurrentRow.Index);
                SubtitlesList.Insert(0, subtitle);
                RefreshAll();
            }

            else if (dataGridView.CurrentRow.Index == SubtitlesList.Count - 1 && SubtitlesList[SubtitlesList.Count - 2].EndTimeDoubleFormat <= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditStartTime.Text))         //if last in data grid view and should come last
            {
                Subtitles subtitle;
                if (textBoxEdit.Text.Contains("\r\n") == true)
                {
                    subtitle = new Subtitles(textBoxEdit.Text.Replace("\r\n", "<br />"), maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                }
                else
                {
                    subtitle = new Subtitles(textBoxEdit.Text, maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                }

                SubtitlesList.RemoveAt(dataGridView.CurrentRow.Index);
                SubtitlesList.Add(subtitle);
                RefreshAll();
            }

            else if (SubtitlesList[0].StartTimeDoubleFormat >= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditEndTime.Text))           //if in the middle of data grid view and should come first
            {
                Subtitles subtitle;
                if (textBoxEdit.Text.Contains("\r\n") == true)
                {
                    subtitle = new Subtitles(textBoxEdit.Text.Replace("\r\n", "<br />"), maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                }
                else
                {
                    subtitle = new Subtitles(textBoxEdit.Text, maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                }

                SubtitlesList.RemoveAt(dataGridView.CurrentRow.Index);
                SubtitlesList.Insert(0, subtitle);
                RefreshAll();
            }

            else if (SubtitlesList[SubtitlesList.Count - 1].EndTimeDoubleFormat <= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditStartTime.Text))           //if in the middle of data grid view and should come last
            {
                Subtitles subtitle;
                if (textBoxEdit.Text.Contains("\r\n") == true)
                {
                    subtitle = new Subtitles(textBoxEdit.Text.Replace("\r\n", "<br />"), maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                }
                else
                {
                    subtitle = new Subtitles(textBoxEdit.Text, maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                }

                SubtitlesList.RemoveAt(dataGridView.CurrentRow.Index);
                SubtitlesList.Add(subtitle);
                RefreshAll();
            }

            else           //if anywhere in data grid view and should come in the middle
            {
                Subtitles subtitleTemp = SubtitlesList[dataGridView.CurrentRow.Index];
                SubtitlesList.RemoveAt(dataGridView.CurrentRow.Index);

                for (int i = 0; i < SubtitlesList.Count; i++)
                {
                    if (SubtitlesList[i].EndTimeDoubleFormat <= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditStartTime.Text) && Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditEndTime.Text) <= SubtitlesList[i + 1].StartTimeDoubleFormat && Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditStartTime.Text) <= Subtitles.TimeStringFormToTimeDoubleForm(maskedTextBoxEditEndTime.Text))
                    {
                        Subtitles subtitle;
                        if (textBoxEdit.Text.Contains("\r\n") == true)
                        {
                            subtitle = new Subtitles(textBoxEdit.Text.Replace("\r\n", "<br />"), maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                        }
                        else
                        {
                            subtitle = new Subtitles(textBoxEdit.Text, maskedTextBoxEditStartTime.Text, maskedTextBoxEditEndTime.Text);
                        }
                        br++;

                        SubtitlesList.Insert(i + 1, subtitle);
                        RefreshAll();
                        break;
                    }
                }

                if (br == 0)
                {
                    SubtitlesList.Insert(dataGridView.CurrentRow.Index, subtitleTemp);
                    MessageBox.Show("There is a subtitle in selected time interval");
                }
            }
        }
    }
}
