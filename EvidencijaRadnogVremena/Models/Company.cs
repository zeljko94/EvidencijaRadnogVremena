using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvidencijaRadnogVremena.Models
{
    public class Company
    {
        #region Properties
        public long CompanyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public long TownId { get; set; }
        public long ParentId { get; set; }
        public bool IsAdminCompany { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
        public bool IsDeleted { get; set; }
        #endregion
    }
}