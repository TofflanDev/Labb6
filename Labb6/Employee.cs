using System;
using System.Collections.Generic;
using System.Text;

namespace Labb6
{
    internal class Employee
    {
        private int myID;
        private string myName;
        public string Gender { get; }
        private double mySalary;

        public Employee(int aID, string aName, string aGender, double aSalary)
        {
            myID = aID;
            myName = aName;
            Gender = aGender;
            mySalary = aSalary;

        }

        public override string ToString()
        {
            return $"Employee: {myID}, {myName}, {Gender}, {mySalary} ";
        }


    }
}
