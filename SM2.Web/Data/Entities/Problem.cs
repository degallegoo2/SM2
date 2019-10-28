using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class Problem
    {
        [Key]
        public int Id { get; set; }

        public int  clase_solicitud { get; set; }

        public DateTime Date_Register { get; set; }

        public int rep { get; set; }

        public int status { get; set; }

    }
}
