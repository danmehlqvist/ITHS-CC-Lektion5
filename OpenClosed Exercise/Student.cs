using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_Exercise
{
    public class Student
    {
        private const int STANDARD_ALLOWANCE = 10;

        public string EmailAddress { get; private set; }
        public int MonthlyEbookAllowance { get; private set; }

        public Student(string emailAddress, Package package)
        {
            EmailAddress = emailAddress;

            if (package == Package.Standard)
            {
                MonthlyEbookAllowance = STANDARD_ALLOWANCE;
            }
            else if (package == Package.Premium)
            {
                MonthlyEbookAllowance = STANDARD_ALLOWANCE * 2;
            }
            else
            {
                MonthlyEbookAllowance = 30;
            }
        }

        public override string ToString()
        {
            return $"The student with email {EmailAddress} has a monthly allowance of {MonthlyEbookAllowance}";
        }
    }
}
