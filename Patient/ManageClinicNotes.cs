using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Patient
{
    public class ManageClinicNotes
    {
        public List<ClinicNote> ClinicNotes=new List<ClinicNote>();
        public string line { get; set; }
        public string[] part { get; set; }
        private string FilePath = "Patient.txt";
        private int value = 1;

        public void AddPatient(ClinicNote clinicNote)
        {
            ClinicNotes.Add(clinicNote);
        }
        
        public int GetNewID()
        {

            for (int i = 0; i < ClinicNotes.Count; i++)
            {
                if (ClinicNotes[i].GetId() >= value)
                {
                    value = ClinicNotes[i].GetId() + 1;
                }
            }
            return value;
        }
        public void AddNewUser(ClinicNote clinicNote)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {

                writer.WriteLine(clinicNote.ToString());

            }
        }
        public void UpdateUser()
        {
            using (StreamWriter writer = new StreamWriter("Patient.txt"))
            {
                foreach (var updatedNote in ClinicNotes)
                {
                    writer.WriteLine(updatedNote.ToString());
                }
            }
        }

        public void ReadUser()
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        part = line.Split('|');
                        int nId = int.Parse(part[0]);
                        string nName = part[1];
                        string[] nProblems = part[2].Split(',');
                        DateTime nBirthDate = DateTime.Parse(part[3]);
                        string nNote = part[4].Replace('+', '\n');

                        ClinicNote nClinicNote = new ClinicNote(nId, nName, nProblems, nBirthDate, nNote);
                        ClinicNotes.Add(nClinicNote);
                    }
                }
            }
        }

    }
}
