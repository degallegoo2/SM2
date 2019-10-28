using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        public string Nomnbre { get; set; }
    }
}
