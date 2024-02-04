
using ChallengeApp_21;

Employee employee1 = new Employee("Mariola", "Brzęczyszczykiewicz", 28); 
Employee employee2 = new Employee("Eustachy", "Wiercioch", 32);
Employee employee3 = new Employee("Teodor", "Walogóra", 47);

employee1.AddPoint(3);
employee1.AddPoint(0);
employee1.AddPoint(7);
employee1.AddPoint(0);
employee1.AddPoint(2);

employee2.AddPoint(2);
employee2.AddPoint(8);
employee2.AddPoint(1);
employee2.AddPoint(5);
employee2.AddPoint(2);

employee3.AddPoint(9);
employee3.AddPoint(10);
employee3.AddPoint(4);
employee3.AddPoint(10);
employee3.AddPoint(3);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult=employee;
        maxResult = employee.Result;

    }

}


Console.WriteLine("Employee with max result : " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + employeeWithMaxResult.Age + " year " + " his result " + maxResult);





