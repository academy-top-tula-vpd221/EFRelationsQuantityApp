using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationsQuantityApp
{
    public class EmployeeProfile
    {
        public int Id { get; set; }

        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;

        //public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
    }
}
