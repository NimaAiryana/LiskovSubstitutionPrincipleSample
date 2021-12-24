using LiskovSubstitutionPrincipleSample;

var employees = new List<Employee>()
{
    new Employee(),
    new Manager(),
    new Manager(),
    new Employee()
};

foreach (var employee in employees)
{
    employee.Print();

    // write other codes ...
}

Console.ReadKey();