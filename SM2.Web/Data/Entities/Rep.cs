using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class Rep
    {
       
        public int Id { get; set; }
        public User User { get; set; }
        public int tipo { get; set; }
        public int empresa { get; set; }


        public ICollection<Cesantia> Cesantias { get; set; }
        public ICollection<Transfer> Transfers { get; set; }
        public ICollection<Disability> Disabilities { get; set; }
        public ICollection<License> Licenses { get; set; }
        public ICollection<Loan> Loans { get; set; }

    }


}
