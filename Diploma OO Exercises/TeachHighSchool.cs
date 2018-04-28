using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma_OO_Exercises
{
    class TeachHighSchool : ITeach
    {
        public SecondaryTeacher pSecondaryTeacher;

        public TeachHighSchool()
        {

        }
        public string Teach()
        {

            return "Teach High School Brats";
        }
    }
}
