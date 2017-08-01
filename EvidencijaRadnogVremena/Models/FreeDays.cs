using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvidencijaRadnogVremena.Models
{
    public class FreeDays
    {
        public long FreeDaysId { get; set; }
        public int NumberOfFreeDays { get; set; }
        public int NumberOfFreeDaysLeft { get; set; }
        public int Year { get; set; }
        public long EmployeeId { get; set; }
    }
}