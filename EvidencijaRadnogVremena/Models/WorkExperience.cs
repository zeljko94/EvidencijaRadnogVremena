using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvidencijaRadnogVremena.Models
{
    public class WorkExperience
    {
        public long WorkExperienceId { get; set; }
        public long PersonId { get; set; }
        public string Description { get; set; }
    }
}