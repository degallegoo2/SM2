using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class Type_Request
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
