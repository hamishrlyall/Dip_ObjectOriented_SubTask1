using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma_OO_Exercises
{
    public abstract class Teacher : Person
    {
        private int StaffID { get; set; }
        private ITeach TeachBehaviour;

        public Teacher()
        {

        }

        public Teacher (int pStaffID, string pFName, string pLName, string pGender) : base(pFName, pLName, pGender)
        {
            StaffID = pStaffID;
        }

        public override string GetOccupation()
        {
            return "Teacher";
        }

        public override string Work()
        {
            return TeachBehaviour.Teach();
        }

    }
}
