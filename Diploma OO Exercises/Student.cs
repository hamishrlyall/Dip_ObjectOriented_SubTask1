using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma_OO_Exercises
{
    public class Student : Person 
    {
        private string StudentID { get; set; }

        public Student()
        {

        }

        public Student(string pStudentId, string pFName, string pLName, string pGender)
        {
            StudentID = pStudentId;
        }

        public override string Work()
        {
            return "Study, Drink Coffee, Party, Sleep, Repeat";
        }
    }
}
