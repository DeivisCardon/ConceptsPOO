using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("==========");

Employee employee1 = new SalaryEmployee()
{
    Id = 1,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
};

Employee employee2 = new CommissionEmployee()
{
    Id = 1,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    CommissionPercentage = 0.03F,
    Sales = 320000000M
};

Console.WriteLine(employee2);