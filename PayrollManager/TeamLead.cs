using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManager
{
    public class TeamLead : Employee,IBonusEligible
    {
        private int _teamSize;
        public int TeamSize
        {
            get { return _teamSize; }
            set { _teamSize = value; }
        }
        public TeamLead(string name, int baseSalary, int teamSize) : base(name, baseSalary)
        {
            _teamSize = teamSize;
        }
        public override int MonthlyCost()
        {
            int newBaseSalary = BaseSalary + (_teamSize * 25000);
            return AddContribution(newBaseSalary);
        }
        public override string Describe()
        {
            return base.Describe() + $", {_teamSize} fős csapat";
        }
        public int Bonus()
        {
            return _teamSize * 30000;
        }
    }
}
