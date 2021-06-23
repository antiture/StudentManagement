using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethode
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMjor, double aGpa)
        {
            name = aName;
            major = aMjor;
            gpa = aGpa;

            Console.WriteLine("creating Student" + aName + " " + aMjor + " " + aGpa);
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
