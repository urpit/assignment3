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
        private string FilePath = "Patient.txt";
        private int value = 1;

        public void AddPatient(ClinicNote clinicNote)
        {
            ClinicNotes.Add(clinicNote);
        }
        public ManageClinicNotes()
        {
            if(File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
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

    }
}
