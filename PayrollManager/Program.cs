namespace PayrollManager;

class Program
{
    static void Main(string[] args)
    {
        Payroll payroll = new Payroll();
        Intern Bence = new Intern("Tóth Bence", 300000);
        FullTimeEmployee Anna = new FullTimeEmployee("Kiss Anna",600000,false);
        FullTimeEmployee Péter = new FullTimeEmployee("Nagy Péter",600000,true);
        TeamLead Eva = new TeamLead("Szabó Éva",800000,4);
        payroll.AddEmployee(Bence);
        payroll.AddForBonus(Anna);
        payroll.AddForBonus(Péter);
        payroll.AddForBonus(Eva);

        Console.WriteLine(payroll.Pay("Tóth Bence"));
        Console.WriteLine(payroll.Pay("Kiss Anna"));
        Console.WriteLine(payroll.Pay("Nagy Péter"));
        Console.WriteLine(payroll.Pay("Szabó Éva"));

        Console.WriteLine(payroll.Pay("Tóth Bence"));
        Console.WriteLine(payroll.Pay("Kovács Ádám"));

        Console.WriteLine(Bence.Describe());
        Console.WriteLine(Anna.Describe());
        Console.WriteLine(Péter.Describe());
        Console.WriteLine(Eva.Describe());

        Console.WriteLine(payroll.TotalPaidOut());
        Console.WriteLine(payroll.TotalBonus());
    }
}
