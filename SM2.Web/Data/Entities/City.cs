using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class City
    {
        [Required(ErrorMessage = "The Rep_id is required")]
        [Key]
        public int Id { get; set; }

        public string nameCity { get; set; }

        public City Cities { get; set; }
    }
}
