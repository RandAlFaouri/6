using ConsoleApp3;

class program
{
    static void Main(string[] args)
    {
        Employee[] emps = new Employee[2];
        Console.Write("TAX");
        Employee.TAX=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("First Employee:");
        Employee e1 = new Employee();
        Console.Write("First Name:");
        e1.FName = Console.ReadLine();
        Console.Write("Last Name:");
        e1.LName = Console.ReadLine();
        Console.Write("wage: ");
        e1.wage = Convert.ToDouble(Console.ReadLine());
        Console.Write("LoggedHours:   "); 
        e1.LoggedHours = Convert.ToDouble(Console.ReadLine());
        emps[0] = e1;
        // var netSalary = e1.wage * e1.LoggedHours - (e1.wage * e1.LoggedHours * Employee.TAX);
        /* Console.WriteLine($"First Name {e1.FName}");
         Console.WriteLine($"Last Name {e1.LName}");
         Console.WriteLine($"Wage  {e1.wage}");
         Console.WriteLine($"Logged Hours {e1.LoggedHours}");
         Console.WriteLine($"Net Salary  {netSalary}");*/
        Console.WriteLine("\nSecond Employee:");
        Employee e2 = new Employee();
    
        Console.Write("First Name:");
        e2.FName = Console.ReadLine();
        Console.Write("Last Name:");
        e2.LName = Console.ReadLine();
        Console.Write("wage: ");
        e2.wage = Convert.ToDouble(Console.ReadLine());
        Console.Write("LoggedHours:   ");
        e2.LoggedHours  = Convert.ToDouble(Console.ReadLine());
        emps[1]=e2;
        foreach (var emp in emps)
        {
            var salary = emp.wage * emp.LoggedHours;
            var taxAmount = salary*Employee.TAX;
            var netSalary = salary - taxAmount;
        Console.WriteLine($"\nFirst Name {emp.FName}");
        Console.WriteLine($"Last Name {emp.LName}");
        Console.WriteLine($"Wage  {emp.wage}");
        Console.WriteLine($"Logged Hours {emp.LoggedHours}");
            Console.WriteLine("-----------");
            Console.WriteLine($"Salary: ${ salary}");
            Console.WriteLine($"Deductable Tax ({Employee.TAX*100}%) Amount: ${taxAmount}");
            Console.WriteLine($"Net Salary  {netSalary}\n");
        }
       // var netSalary1 = e2.wage * e2.LoggedHours - (e2.wage * e2.LoggedHours * Employee.TAX);
      /*  Console.WriteLine($"First Name {e2.FName}");
        Console.WriteLine($"Last Name {e2.LName}");
        Console.WriteLine($"Wage  {e2.wage}");
        Console.WriteLine($"Logged Hours {e2.LoggedHours}");
        Console.WriteLine($"Net Salary  {netSalary1}");*/
        Console.Read();
    }
}