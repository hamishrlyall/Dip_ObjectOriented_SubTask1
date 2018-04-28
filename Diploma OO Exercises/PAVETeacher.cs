using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma_OO_Exercises
{
    class PAVETeacher : Teacher
    {
        public PAVETeacher()
        {

        }

        public PAVETeacher(int pStaffID, string pFName, string pLName, string pGender) : base (pStaffID, pFName, pLName, pGender)
        {
            TeachBehaviour = new TeachPAVE();
        }

        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }
    }
}
