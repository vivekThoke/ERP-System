using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Domain.Common;

namespace ERP.Domain.Entities
{
    public class User : BaseEntity
    {
        public string ?Email { get; set; }
        public string ?PasswordHash { get; set; }
        public string ?FullName { get; set; }
        public string ?Role { get; set; } // Admin, Manager, Employee
    }
}
