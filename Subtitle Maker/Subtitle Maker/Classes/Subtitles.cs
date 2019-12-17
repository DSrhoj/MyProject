using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtitle_Maker.Classes
{
    public class Subtitles
    {
        public string Text;
        public string StartTimeStringFormat;
        public string EndTimeStringFormat;
        public string Duration;
        public double StartTimeDoubleFormat;
        public double EndTimeDoubleFormat;


        public Subtitles(string Text, string StartTimeStringFormat, string EndTimeStringFormat)
        {
            this.Text = Text;
            this.StartTimeStringFormat = StartTimeStringFormat;
            this.EndTimeStringFormat = EndTimeStringFormat;
            this.StartTimeDoubleFormat = TimeStringFormToTimeDoubleForm(this.StartTimeStringFormat);
            this.EndTimeDoubleFormat = TimeStringFormToTimeDoubleForm(this.EndTimeStringFormat);
            this.Duration = CalculateDuration(this.StartTimeDoubleFormat, this.EndTimeDoubleFormat);
        }

        public static string TimeDoubleFormatToTimeStringFormat(double TimeDoubleFormat)
        {
            string H, M, S, MS, TimeStringFormat;
            double h, m, s, ms;

            ms = TimeDoubleFormat % 1 * 1000;
            if (ms < 10)
            {
                MS = "00" + Math.Truncate(ms).ToString();
            }
            else if (ms < 100)
            {
                MS = "0" + Math.Truncate(ms).ToString();
            }
            else
                MS = Math.Truncate(ms).ToString();

            s = Math.Truncate(TimeDoubleFormat) % 3600 % 60;
            if (s < 10)
            {
                S = "0" + s.ToString();
            }
            else
                S = s.ToString();

            m = Math.Truncate(Math.Truncate(TimeDoubleFormat) % 3600 / 60);
            if (m < 10)
            {
                M = "0" + m.ToString();
            }
            else
                M = m.ToString();

            h = Math.Truncate(Math.Truncate(TimeDoubleFormat) / 3600);
            if (h < 10)
            {
                H = "0" + h.ToString();
            }
            else
                H = h.ToString();

            TimeStringFormat = H + ":" + M + ":" + S + "," + MS;
            return TimeStringFormat;
        }

        public static double TimeStringFormToTimeDoubleForm(string TimeStringFormat)
        {
            double TimeDoubleFormat = 0;

            TimeDoubleFormat += ((int.Parse(TimeStringFormat[0].ToString())) * 36000);      // hours x10
            TimeDoubleFormat += ((int.Parse(TimeStringFormat[1].ToString())) * 3600);       // hours
            TimeDoubleFormat += ((int.Parse(TimeStringFormat[3].ToString())) * 600);        // minutes x10
            TimeDoubleFormat += ((int.Parse(TimeStringFormat[4].ToString())) * 60);         // minutes
            TimeDoubleFormat += ((int.Parse(TimeStringFormat[6].ToString())) * 10);         // seconds x10
            TimeDoubleFormat += ((int.Parse(TimeStringFormat[7].ToString())));              // seconds
            TimeDoubleFormat += ((double.Parse(TimeStringFormat[9].ToString())) / 10);      //
            TimeDoubleFormat += ((double.Parse(TimeStringFormat[10].ToString())) / 100);    // miliseconds
            TimeDoubleFormat += ((double.Parse(TimeStringFormat[11].ToString())) / 1000);   //

            return TimeDoubleFormat;
        }

        public static string CalculateDuration(double StartTimeDoubleFormat, double EndTimeDoubleFormat)
        {
            double Duration = 0;
            Duration = EndTimeDoubleFormat - StartTimeDoubleFormat;
            return TimeDoubleFormatToTimeStringFormat(Duration);
        }
    }
}
