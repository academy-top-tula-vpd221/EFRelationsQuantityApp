using EFRelationsQuantityApp;
using Microsoft.EntityFrameworkCore;

using (ApplicationContext context = new())
{
    //await context.Database.EnsureDeletedAsync();
    //await context.Database.EnsureCreatedAsync();

    //Company yandex = new() { Title = "Yandex" };
    //Company ozon = new() { Title = "Ozon" };

    //Employee bob = new() { Name = "Bob", Company = yandex };
    //Employee joe = new() { Name = "Joe", Company = ozon };
    //Employee tom = new() { Name = "Tom", Company = yandex };
    //Employee sam = new() { Name = "Sam", Company = ozon };

    //context.Employees.AddRange(bob, joe, tom, sam);

    //EmployeeProfile bobProfile = new() { Employee = bob, Login = "bobby", Password = "qwerty" };
    //EmployeeProfile joeProfile = new() { Employee = joe, Login = "jonny", Password = "12345" };

    //context.EmployeeProfiles.AddRange(bobProfile, joeProfile);

    //Project browser = new() { Title = "Browser develops" };
    ////browser.Employees.AddRange(new[] { joe, tom });
    //browser.DateMarks.Add(new DateMark() { Employee = joe, Mark = DateTime.Now.AddDays(-50) });
    //browser.DateMarks.Add(new DateMark() { Employee = tom });

    //Project game = new Project() { Title = "Strategy game" };

    //context.Projects.AddRange(game, browser);

    //sam.Projects.Add(game);
    //bob.DateMarks.Add(new DateMark() { Project = game, Mark = DateTime.Now.AddDays(-120) });


    //await context.SaveChangesAsync();
}

//using (ApplicationContext context = new())
//{
//    var projects = context.Projects.Include(p => p.Employees).ToList();
//    foreach(var p in projects)
//    {
//        Console.WriteLine($"Project {p.Title}");
//        foreach(var dm in p.DateMarks)
//            Console.WriteLine($"\tEmployee: {dm.Employee.Name} Date: {dm.Mark.ToShortDateString()}");
//        Console.WriteLine();
//    }
//}


//using (ApplicationContext context = new())
//{
//    var company = context.Companies.FirstOrDefault();
//    if (company != null)
//        context.Companies.Remove(company);

//    context.SaveChanges();
//}