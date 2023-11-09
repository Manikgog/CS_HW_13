using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_13
{
    enum gender {female, male };
    enum major {бухгалтер, менеджер, программист, инженер };
    class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public int Age { get; set; }
        public gender Gender { get; set; }
        public major Major { get; set; }
        public List<string> Subjects { get; set; }

        public Student(string name, string surname, int age, gender gender, 
                        major major, List<string> subjects)
        {
            Name=name;
            Surname=surname;
            Age=age;
            Gender=gender;
            Major=major;
            Subjects=subjects;
        }

        public override string ToString()
        {
            string FIO = Name + " " + Surname + "; Возраст: " + Age +
                    "; Пол: " + Gender + "; Специальность: " + Major + "\n";
            string specialnost = null;
            for(int i = 0; i < Subjects.Count; i++)
            {
                if(i == Subjects.Count - 1 || i != 0)
                {
                    specialnost += ", ";
                }
                specialnost += Subjects[i];
            }
            return FIO + specialnost;
        }
    }
}
