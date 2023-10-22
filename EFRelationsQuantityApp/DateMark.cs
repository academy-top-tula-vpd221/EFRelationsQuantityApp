using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationsQuantityApp
{
    public class DateMark
    {
        public int EmployeeId { set; get; }
        public Employee? Employee { set; get; }

        public int ProjectId { set; get; }
        public Project? Project { set; get; }

        public DateTime Mark {  set; get; }
    }
}
