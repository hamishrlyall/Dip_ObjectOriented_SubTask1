using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma_OO_Exercises
{
    public class SpecialNeedsTeacher : Teacher
    {
        public SpecialNeedsTeacher()
        {

        }

        public SpecialNeedsTeacher(int pStaffID, string pFName, string pLName, string pGender) : base (pStaffID, pFName, pLName, pGender)
        {
            TeachBehaviour = new TeachSpecialNeeds();
        }
    }
}
