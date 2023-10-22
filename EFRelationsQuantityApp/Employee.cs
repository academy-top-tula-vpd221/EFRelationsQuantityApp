using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationsQuantityApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int? ProfileId { get; set; }
        public EmployeeProfile? Profile { get; set; }

        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public List<Project>? Projects { get; set; } = new();
        public List<DateMark> DateMarks { get; set; } = new();

    }
}
