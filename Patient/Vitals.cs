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
            Match m = BpRegex.Match(note, (int)RegexOptions.IgnoreCase);
            if (m.Success && !vitals.Contains(m.Value))
            {
                if (int.Parse(m.Groups[1].Value) > 130 && int.Parse(m.Groups[2].Value) > 80)
                {
                    sStrign = $"{m.Value} mmHg(High)";
                    vitals.Add(sStrign);
                }
                else
                {
                    sStrign = $"{m.Value} mmHg(Low)";
                    vitals.Add(sStrign);
                }
            }
           
        }
    }
}
