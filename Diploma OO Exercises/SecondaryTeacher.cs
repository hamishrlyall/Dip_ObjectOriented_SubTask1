using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma_OO_Exercises
{
    public class SecondaryTeacher : Teacher
    {
        public SecondaryTeacher()
        {

        }

        public SecondaryTeacher(int pStaffID, string pFName, string pLName, string pGender) : base(pStaffID, pFName, pLName, pGender)
        {
            TeachBehaviour = new TeachHighSchool();
        }

        public override string GetOccupation()
        {
            return "Secondary Teacher";
        }
    }
}
