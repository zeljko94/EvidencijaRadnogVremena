using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvidencijaRadnogVremena.Models
{
    public class Person
    {
        public long PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public long CompanyId { get; set; }
        public long TownId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
        public string FamilyMembers { get; set; }
        public string MarriageStatus { get; set; }
        public string SpouseName { get; set; }
        public string AboutSpouse { get; set; }
        public string AboutMe { get; set; }
        public string KidsNames { get; set; }
        public string AboutKids { get; set; }
        public string Education { get; set; }
        public string Department { get; set; }
        public string WorkAddress { get; set; }
        public string Activity { get; set; }




       

    }
}