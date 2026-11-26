using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManager
{
    public class Intern : Employee
    {
        public Intern(string name, int baseSalary) : base(name, baseSalary)
        {

        }

        public override int MonthlyCost()
        {
            return AddContribution(BaseSalary);
        }
    }

    
}
