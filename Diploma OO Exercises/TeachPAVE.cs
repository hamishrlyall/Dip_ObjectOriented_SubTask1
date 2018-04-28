using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma_OO_Exercises
{
    class TeachPAVE : ITeach
    {
        public PAVETeacher pPaveTeacher;

        public TeachPAVE()
        {

        }
        public string Teach()
        {
            return "Teach Awesome SWD Students";
        }

    }
}
