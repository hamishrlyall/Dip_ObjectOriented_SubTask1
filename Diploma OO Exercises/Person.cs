using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma_OO_Exercises
{
    public abstract class Person
    {
        //attributes
        private string Fname { get; set; }
        private string Gender;
        private string Lname { get; set; }

        //constructors
        public Person()
        {

        }

        public Person(string pFName, string pLName, string pGender)
        {
            Fname = pFName;
            Lname = pLName;
            if (Gender != "M" && Gender != "F")
            {
                throw new Exception("Invalid Gender Passed to Person Constructor");
            }


        }

        public Person(string pGender)
        {

            if (Gender == "M") { Fname = "John"; Lname = "Doe"; }
            else if (Gender == "F") { Fname = "Jane"; Lname = "Doe"; }
            else throw new Exception("Invalid Gender Passed to Person Constructor");
        }

        //methods
        public string GetGender()
        {
            return Gender;
        }

        public virtual string GetOccupation()
        {
            return "Unemployed";
        }

        public abstract string Work();

    }
}
