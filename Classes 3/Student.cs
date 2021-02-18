using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_3
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }


        /// <summary>
        /// Default/empty ctor
        /// </summary>
        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
            GPA = 0;
            Address = new Address();
        }


        /// <summary>
        /// Overloaded ctor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="major"></param>
        /// <param name="gpa"></param>
        public Student(string firstName, string lastName, string major, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            GPA = gpa;
            Address = new Address();
        }

        public string CalculateDistinction()
        {


            if (GPA >= 3.40 && GPA <= 3.59)
            {
                return ("Cum Laude");
            }
            else if (GPA >= 3.60 && GPA <= 3.79)
            {
                return ("Magna Cum Laude");
            }
            else if (GPA >= 3.80)
            {
                return ("Summa Cum Laude");
            }
            else
            {
                return ("no special distinction");
            }

            /*string hi = "hi";
            return hi;*/
        }

        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address = new Address(streetNumber, streetName, state, city, zipcode);


        }

        override public string ToString()
        {

            return (FirstName + " " + LastName + ", " + Major + ", " + CalculateDistinction());
            // GPA.ToString("N1")
        }
    }
}
