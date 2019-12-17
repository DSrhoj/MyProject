using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Subtitle_Maker.Classes
{
    public class Methods
    {
        public Methods()
        {

        }

        public static void RefreshDataGridView(SubtitleMaker subtitleMaker)
        {
            subtitleMaker.dataGridView.Rows.Clear();

            for (int i = 0; i < Subtitles.SubtitlesList.Count; i++)
            {
                subtitleMaker.dataGridView.Rows.Add(i + 1 + ".", Subtitles.SubtitlesList[i].StartTimeStringFormat, Subtitles.SubtitlesList[i].EndTimeStringFormat, Subtitles.SubtitlesList[i].Duration, Subtitles.SubtitlesList[i].Text);
            }
        }

        public static void RefreshSource(SubtitleMaker subtitleMaker)
        {
            subtitleMaker.listBoxSourceView.Items.Clear();
            for (int i = 0; i < Subtitles.SubtitlesList.Count; i++)
            {
                subtitleMaker.listBoxSourceView.Items.Add(i + 1);
                subtitleMaker.listBoxSourceView.Items.Add(Subtitles.SubtitlesList[i].StartTimeStringFormat + " --> " + Subtitles.SubtitlesList[i].EndTimeStringFormat);

                string[] splitAt = new string[] { "<br />" };
                string[] lines;
                lines = System.Text.RegularExpressions.Regex.Split(Subtitles.SubtitlesList[i].Text, "<br />");
                foreach (string line in lines)
                {
                    subtitleMaker.listBoxSourceView.Items.Add(line);
                }
                subtitleMaker.listBoxSourceView.Items.Add("");
            }
        }


        public static void StreamToFile(SubtitleMaker subtitleMaker)
        {

            var stream = File.Create(@subtitleMaker.labelLocationsSubtitleLocationValue.Text);
            StreamWriter file = new StreamWriter(stream, Encoding.UTF8);

            for (int i = 0; i < Subtitles.SubtitlesList.Count; i++)
            {
                file.WriteLine(i + 1);
                file.WriteLine(Subtitles.SubtitlesList[i].StartTimeStringFormat + " --> " + Subtitles.SubtitlesList[i].EndTimeStringFormat);
                if (Subtitles.SubtitlesList[i].Text.Contains("<br />") == true)
                {
                    file.WriteLine(Subtitles.SubtitlesList[i].Text.Replace("<br />", "\r\n"));
                }
                else
                {
                    file.WriteLine(Subtitles.SubtitlesList[i].Text);
                }
                file.WriteLine();
            }
            file.Close();
        }

        public static void StreamFromFile(SubtitleMaker subtitleMaker)
        {
            string[] lines = File.ReadAllLines(@subtitleMaker.labelLocationsSubtitleLocationValue.Text);
            string BothTimes = "";
            string Text = "";

            for (int i = 0; i < lines.Length; i++)
            {
                Text = "";

                if (lines[i] == (Subtitles.SubtitlesList.Count + 1).ToString())
                {
                    i += 1;
                    BothTimes = lines[i];

                    while (i + 1 != lines.Length && lines[i + 1] != (Subtitles.SubtitlesList.Count + 2).ToString())
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

                        else if (i + 1 != lines.Length && lines[i + 1] != (Subtitles.SubtitlesList.Count + 2).ToString())
                        {
                            Text += "<br />";
                        }
                    }

                    Subtitles subtitle = new Subtitles(Text, CalculateStartTimeFromLine(BothTimes), CalculateEndTimeFromLine(BothTimes));
                    Subtitles.SubtitlesList.Add(subtitle);
                }
            }
        }

        public static string CalculateStartTimeFromLine(string BothTimes)
        {
            string firstTime;

            firstTime = BothTimes.Substring(0, 12);

            return firstTime;
        }

        public static string CalculateEndTimeFromLine(string BothTimes)
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

        public static string GetDirectory(SubtitleMaker subtitleMaker, string location)
        {
            return location.Remove(location.LastIndexOf("\\") + 1, (location.Length - location.LastIndexOf("\\") - 1));
        }

        public static void CheckStartEndTimeColorAdd(SubtitleMaker subtitleMaker)
        {
            if (subtitleMaker.maskedTextBoxAddStartTime.MaskFull == true && subtitleMaker.labelAddStartTime.ForeColor == Color.Firebrick)
            {
                subtitleMaker.labelAddStartTime.Text = subtitleMaker.labelAddStartTime.Text.Replace(" *", "");
                subtitleMaker.labelAddStartTime.ForeColor = SystemColors.ControlText;
                subtitleMaker.labelAddError.Visible = false;
            }

            if (subtitleMaker.maskedTextBoxAddEndTime.MaskFull == true && subtitleMaker.labelAddEndTime.ForeColor == Color.Firebrick)
            {
                subtitleMaker.labelAddEndTime.Text = subtitleMaker.labelAddEndTime.Text.Replace(" *", "");
                subtitleMaker.labelAddEndTime.ForeColor = SystemColors.ControlText;
                subtitleMaker.labelAddError.Visible = false;
            }
        }

        public static void CheckTextColorAdd(SubtitleMaker subtitleMaker)
        {
            if (string.IsNullOrEmpty(subtitleMaker.labelAddText.Text) == false && subtitleMaker.labelAddText.ForeColor == Color.Firebrick)
            {
                subtitleMaker.labelAddText.Text = subtitleMaker.labelAddText.Text.Replace(" *", "");
                subtitleMaker.labelAddText.ForeColor = SystemColors.ControlText;
                subtitleMaker.labelAddError.Visible = false;
            }
        }

        public static void CheckStartEndTimeColorEdit(SubtitleMaker subtitleMaker)
        {
            if (subtitleMaker.maskedTextBoxEditStartTime.MaskFull == true && subtitleMaker.labelEditStartTime.ForeColor == Color.Firebrick)
            {
                subtitleMaker.labelEditStartTime.Text = subtitleMaker.labelEditStartTime.Text.Replace(" *", "");
                subtitleMaker.labelEditStartTime.ForeColor = SystemColors.ControlText;
            }

            if (subtitleMaker.maskedTextBoxEditEndTime.MaskFull == true && subtitleMaker.labelEditEndTime.ForeColor == Color.Firebrick)
            {
                subtitleMaker.labelEditEndTime.Text = subtitleMaker.labelEditEndTime.Text.Replace(" *", "");
                subtitleMaker.labelEditEndTime.ForeColor = SystemColors.ControlText;
            }
        }

        public static void CheckTextColorEdit(SubtitleMaker subtitleMaker)
        {
            if (string.IsNullOrWhiteSpace(subtitleMaker.labelEditText.Text) == false && subtitleMaker.labelEditText.ForeColor == Color.Firebrick)
            {
                subtitleMaker.labelEditText.Text = subtitleMaker.labelEditText.Text.Replace(" *", ""); ;
                subtitleMaker.labelEditText.ForeColor = SystemColors.ControlText;
            }
        }

        public static void CheckBiggerTimeEdit(SubtitleMaker subtitleMaker)
        {
            if (subtitleMaker.maskedTextBoxEditStartTime.MaskFull == true && subtitleMaker.maskedTextBoxEditEndTime.MaskFull == true && Subtitles.TimeStringFormToTimeDoubleForm(subtitleMaker.maskedTextBoxEditStartTime.Text) <= Subtitles.TimeStringFormToTimeDoubleForm(subtitleMaker.maskedTextBoxEditEndTime.Text))
            {
                subtitleMaker.labelEditDurationValue.Text = Subtitles.CalculateDuration(Subtitles.TimeStringFormToTimeDoubleForm(subtitleMaker.maskedTextBoxEditStartTime.Text), Subtitles.TimeStringFormToTimeDoubleForm(subtitleMaker.maskedTextBoxEditEndTime.Text));
                subtitleMaker.labelEditDurationValue.ForeColor = SystemColors.ControlText;
            }

            else if (subtitleMaker.maskedTextBoxEditStartTime.MaskFull == false || subtitleMaker.maskedTextBoxEditEndTime.MaskFull == false)
            {

            }

            else
            {
                subtitleMaker.labelEditDurationValue.Text = "Start time is bigger than end time!";
                subtitleMaker.labelEditDurationValue.ForeColor = Color.Firebrick;
            }
        }

        public static void CheckBiggerTimeAdd(SubtitleMaker subtitleMaker)
        {
            if (subtitleMaker.maskedTextBoxAddStartTime.MaskFull == true && subtitleMaker.maskedTextBoxAddEndTime.MaskFull == true && Subtitles.TimeStringFormToTimeDoubleForm(subtitleMaker.maskedTextBoxAddStartTime.Text) <= Subtitles.TimeStringFormToTimeDoubleForm(subtitleMaker.maskedTextBoxAddEndTime.Text))
            {
                subtitleMaker.labelAddDurationValue.Text = Subtitles.CalculateDuration(Subtitles.TimeStringFormToTimeDoubleForm(subtitleMaker.maskedTextBoxAddStartTime.Text), Subtitles.TimeStringFormToTimeDoubleForm(subtitleMaker.maskedTextBoxAddEndTime.Text));
                subtitleMaker.labelAddDurationValue.ForeColor = SystemColors.ControlText;
            }

            else if (subtitleMaker.maskedTextBoxAddStartTime.MaskFull == false || subtitleMaker.maskedTextBoxAddEndTime.MaskFull == false)
            {

            }

            else
            {
                subtitleMaker.labelAddDurationValue.Text = "Start time is bigger than end time!";
                subtitleMaker.labelAddDurationValue.ForeColor = Color.Firebrick;
            }
        }

    }
}
