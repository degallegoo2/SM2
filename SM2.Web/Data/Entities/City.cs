using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class City
    {
        
        public int Id { get; set; }

        public string nameCity { get; set; }

        public ICollection<Transfer> Transfers { get; set; }
    }
}
