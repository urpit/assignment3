using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Patient
{
    public class Vitals
    {
        string sStrign { get; set; }
        public List<string> vitals = new List<string>();
        private Regex BpRegex = new Regex(@"BP: (\d{2,3})/(\d{2})");
        private Regex HrRegex = new Regex(@"HR: (\d{2,3})");
        private Regex RrRegex = new Regex(@"RR: (\d{2})");
        private Regex TRegex = new Regex(@"T: (\d{2}\.*\d{1,2})");
        public void ExtractBp(string note)
        {
            MatchCollection m = BpRegex.Matches(note, (int)RegexOptions.IgnoreCase);

            for (int i = 0; i < m.Count; i++)
            {
                if (int.Parse(m[i].Groups[1].Value) > 130 && int.Parse(m[i].Groups[2].Value) > 80)
                {
                    sStrign = $"{m[i].Value} mmHg(High)";
                    vitals.Add(sStrign);
                }

                if (int.Parse(m[i].Groups[1].Value) < 90 && int.Parse(m[i].Groups[2].Value) < 60)
                {
                    sStrign = $"{m[i].Value} mmHg(Low)";
                    vitals.Add(sStrign);
                }

                if (int.Parse(m[i].Groups[1].Value) > 90 && int.Parse(m[i].Groups[1].Value) < 130 && int.Parse(m[i].Groups[2].Value) < 80 && int.Parse(m[i].Groups[2].Value) > 60)
                {
                    sStrign = $"{m[i].Value} mmHg";
                    vitals.Add(sStrign);
                }
            }

        }
        public void ExtractHr(string note)
        {
            MatchCollection m1 = HrRegex.Matches(note, (int)RegexOptions.IgnoreCase);
            for (int i = 0; i < m1.Count; i++)
            {
                if (int.Parse(m1[i].Groups[1].Value) > 100)
                {
                    sStrign = $"{m1[i].Value} bpm(High)";
                    vitals.Add(sStrign);
                }
                if (int.Parse(m1[i].Groups[1].Value) < 60)
                {
                    sStrign = $"{m1[i].Value} bpm(Low)";
                    vitals.Add(sStrign);
                }
                if (int.Parse(m1[i].Groups[1].Value) > 60 && int.Parse(m1[i].Groups[1].Value) < 100)
                {
                    sStrign = $"{m1[i].Value} bpm";
                    vitals.Add(sStrign);
                }

            }
        }
        public void ExtractRr(string note)
        {
            MatchCollection m2 = RrRegex.Matches(note, (int)RegexOptions.IgnoreCase);
            for (int i = 0; i < m2.Count; i++)
            {
                if (int.Parse(m2[i].Groups[1].Value) > 16)
                {
                    sStrign = $"{m2[i].Value} bpm(High)";
                    vitals.Add(sStrign);
                }
                if (int.Parse(m2[i].Groups[1].Value) < 12)
                {
                    sStrign = $"{m2[i].Value} bpm(Low)";
                    vitals.Add(sStrign);
                }
                if (int.Parse(m2[i].Groups[1].Value) > 12 && int.Parse(m2[i].Groups[1].Value) < 16)
                {
                    sStrign = $"{m2[i].Value} bpm";
                    vitals.Add(sStrign);
                }

            }
        }
        public void ExtractT(string note)
        {
            MatchCollection m3 = TRegex.Matches(note, (int)RegexOptions.IgnoreCase);
            for (int i = 0; i < m3.Count; i++)
            {
                if (double.Parse(m3[i].Groups[1].Value) > 37.2)
                {
                    sStrign = $"{m3[i].Value} Celsius(High)";
                    vitals.Add(sStrign);
                }
                if (double.Parse(m3[i].Groups[1].Value) < 36.5)
                {
                    sStrign = $"{m3[i].Value} Celsius(Low)";
                    vitals.Add(sStrign);
                }
                if (double.Parse(m3[i].Groups[1].Value) > 36.5 && double.Parse(m3[i].Groups[1].Value) < 37.2)
                {
                    sStrign = $"{m3[i].Value} Celsius";
                    vitals.Add(sStrign);
                }

            }
        }
    }
}
