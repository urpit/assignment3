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
        private Regex BpRegex = new Regex(@"BP: \d+/\d+");
        public void ExtractBp(string note)
        {
            Match m = BpRegex.Match(note, (int)RegexOptions.IgnoreCase);
            if (m.Success && !vitals.Contains(m.Value))
            {
                sStrign = m.Value;
                vitals.Add(sStrign);
            }
           
        }
    }
}
