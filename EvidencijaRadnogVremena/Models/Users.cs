using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvidencijaRadnogVremena.Models
{
    public class Users
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long EmployeeId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
        public long CompanyId { get; set; }
        public string Privileges { get; set; }

    }
}