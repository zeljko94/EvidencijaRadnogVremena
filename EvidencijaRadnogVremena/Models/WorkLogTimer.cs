using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvidencijaRadnogVremena.Models
{
    public class WorkLogTimer
    {
        public long WorkLogTimerId { get; set; }
        public DateTime DateAndTime { get; set; }
        public long EmployeeId { get; set; }
    }
}