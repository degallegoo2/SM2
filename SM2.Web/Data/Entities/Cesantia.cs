using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class Cesantia
    {
        [Required(ErrorMessage = "The Rep_id is required")]
        [Key]
        public int Id { get; set; }

        public float Value { get; set; }

        public int typeCesantia { get; set; }

        public TypeCesantia TypeCesantias { get; set; }
    }
}
