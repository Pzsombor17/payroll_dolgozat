using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManager
{
    public class FullTimeEmployee : Employee, IBonusEligible 
    {
        private bool _hasNightShift;
        public bool HasNightShift
        {
            get { return _hasNightShift; }
            set { _hasNightShift = value; }
        }
        public FullTimeEmployee(string name, int baseSalary, bool hasNightShift) : base(name, baseSalary)
        {
            _hasNightShift = hasNightShift;
        }
        public override int MonthlyCost()
        {
            int newBaseSalaey = BaseSalary;
            if (_hasNightShift)
            {
                newBaseSalaey += 40000;
                return AddContribution(newBaseSalaey);
            }
            else
            {
                return AddContribution(BaseSalary);
            }
        }
        public int Bonus()
        {
            return HasNightShift ? 7000 : 5000;
        }
    }
    
    
}
