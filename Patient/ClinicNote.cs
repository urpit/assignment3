using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient
{
    public class ClinicNote
    {
       

        public int Id { get; set; }
        public string Name { get; set; }
        public string Problem { get; set; }
        public string[] ArrayOfProblems { get; set; }
        public DateTime BirthDate { get; set; }
        public string Note { get; set; }
        public ClinicNote(int id, string name, string[] problem, DateTime birthDate, string note)
        {
            Id = id;
            Name = name;
            foreach (string problems in problem)
            {
                Problem += problems;
            }
            ArrayOfProblems = problem;
            BirthDate = birthDate;
            Note = note;
        }
       public int GetId()
        {
            return this.Id;
        }
        public override string ToString()
        {
            return $"{Id}|{Name}|{Problem}|{BirthDate}|{Note}";
        }


    }
}
