using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class Rep
    {   
        
        [Required(ErrorMessage = "The Rep_id is required")]
        [Key]
        public int rep_id { get; set; }
        
        [MaxLength(100)]
        public string nombre { get; set; }
        [MaxLength(50)]
        public string email { get; set; }
        public int activo { get; set; }
        public int tipo { get; set; }
        public int cedula { get; set; }
        public int empresa { get; set; }
       
    }


}
