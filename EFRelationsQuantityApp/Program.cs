using EFRelationsQuantityApp;

using (ApplicationContext context = new())
{
    await context.Database.EnsureDeletedAsync();
    await context.Database.EnsureCreatedAsync();

    Company yandex = new() { Title = "Yandex" };
    Company ozon = new() { Title = "Ozon" };

    Employee bob = new() { Name = "Bob", Company = yandex };
    Employee joe = new() { Name = "Joe", Company = ozon };
    Employee tom = new() { Name = "Tom", Company = yandex };
    Employee sam = new() { Name = "Sam", Company = ozon };

    context.Employees.AddRange(bob, joe, tom, sam);

    EmployeeProfile bobProfile = new() { Employee = bob, Login = "bobby", Password = "qwerty" };
    EmployeeProfile joeProfile = new() { Employee = joe, Login = "jonny", Password = "12345" };

    context.EmployeeProfiles.AddRange(bobProfile, joeProfile);

    Project browser = new() { Title = "Browser develops" };
    browser.Employees.AddRange(new[] { joe, tom });

    Project game = new Project() { Title = "Strategy game" };
    sam.Projects.AddRange(new[] { browser, game });


    await context.SaveChangesAsync();
}

//using (ApplicationContext context = new())
//{
//    var company = context.Companies.FirstOrDefault();
//    if (company != null)
//        context.Companies.Remove(company);

//    context.SaveChanges();
//}