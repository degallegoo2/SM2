using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class History
    {
        [Key]
        public int Id { get; set; }

        public int Id_Request { get; set; }

        public int state_request { get; set; }

        public DateTime Registration_date { get; set; }

        public ICollection<Cesantia> Cesantias { get; set; }
        public ICollection<Disability> Disabilities { get; set; }
        public ICollection<License> Licenses { get; set; }
        public ICollection<Loan> Loans { get; set; }
        public ICollection<Transfer> Transfers { get; set; }
    }
}
