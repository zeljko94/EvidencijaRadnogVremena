using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvidencijaRadnogVremena.Models
{
    public class WorkLogTimerStatus
    {
        public long WorkLogTimerStatusId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Reason { get; set; }
        public long WorkLogTimerId { get; set; }
    }
}