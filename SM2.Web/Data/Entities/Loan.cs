using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class Loan
    {
        [Required(ErrorMessage = "The Rep_id is required")]
        [Key]
        public int Id { get; set; }
        public int TypeLoan { get; set; }

        public float ValorLoan { get; set; }


        public TypeLoan TypeLoans { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
