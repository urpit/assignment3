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

        //Method for adding information into the list
        public void AddPatient(ClinicNote clinicNote)
        {
            ClinicNotes.Add(clinicNote);
        }
        
        //Method for getting new ID
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
        //Method for creating the text file
        public void AddNewUser(ClinicNote clinicNote)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {

                writer.WriteLine(clinicNote.ToString());

            }
        }

        //method for updating the text file
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

        //method for reading the information from the text file
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
