using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManager
{
    public abstract class Employee
    {
        private string _name;
        private int _baseSalary;
        private bool _paid;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BaseSalary
        {
            get { return _baseSalary; }
            set { _baseSalary = value; }
        }
        public bool Paid
        {
            get { return _paid; }
            set { _paid = value; }
        }

        public Employee(string name, int baseSalary)
        {
            _name = name;
            _baseSalary = baseSalary;
            _paid = false;
        }

        protected int AddContribution(int salary)
        {
            return salary + salary * 13 / 100;
        }
        public abstract int MonthlyCost();
        public string HasBeenPaidText()
        {
            if (_paid == true)
            {
                return "Kifizetve";
                
            }
            else
            {
                return ("Nincs kifizetve");
            }
        }
        public virtual string Describe()
        {
            return $"{Name}, {MonthlyCost()} Ft/hó, {HasBeenPaidText()}";
        }
    }
}
