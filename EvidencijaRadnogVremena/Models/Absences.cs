using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvidencijaRadnogVremena.Models
{
    public class Absences
    {
        public long AbsenceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Reason { get; set; }
        public long EmployeeId { get; set; }
    }
}