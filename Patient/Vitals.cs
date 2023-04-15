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
        public List<string> vitals=new List<string>();
        private Regex BpRegex = new Regex(@"BP: (\d{3})/(\d{2})");
        public void ExtractBp(string note)
        {
            MatchCollection m = BpRegex.Matches(note, (int)RegexOptions.IgnoreCase);
            if (m.Count!=0)
            {
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
           
        }
    }
}
