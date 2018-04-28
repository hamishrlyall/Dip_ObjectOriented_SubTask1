using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma_OO_Exercises
{
    class TeachSpecialNeeds : ITeach
    {
        public SpecialNeedsTeacher pSpecialNeedsTeacher;
        
        public TeachSpecialNeeds()
        {

        }

        public string Teach()
        {
            return "Teach Special Needs Students";
        }

    }
}
