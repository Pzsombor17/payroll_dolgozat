using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManager
{
    public class Payroll
    {
        private List<Employee> employees;
        private List<IBonusEligible> bonusList;

        public Payroll()
        {
            employees = new List<Employee>();
            bonusList = new List<IBonusEligible>();
        }

        public void AddEmployee(Employee employee)
        {
           employees.Add(employee);
        }
        public void AddForBonus(IBonusEligible item)
        {
             bonusList.Add(item);
        }
        public int TotalPaidOut()
        {
            int sum = 0;
            foreach(Employee emp in employees)
            {
                if (emp.Paid) sum += emp.MonthlyCost();
                
                     
            }
            return sum;

        }
        public int TotalBonus()
        {
            int sum = 0;
            foreach (IBonusEligible b in bonusList)
            {
                sum += b.Bonus();
            }
            return sum;
        }
        public bool Pay(string name)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Name == name && emp.Paid == false)
                {
                     emp.Paid = true;
                    return true;
                }
                
            }
            return false;
        }
    }
}
