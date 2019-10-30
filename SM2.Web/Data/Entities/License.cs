using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class License
    {
        [Required(ErrorMessage = "The Rep_id is required")]
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime initialDate { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime initialDateLocal => initialDate.ToLocalTime();

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime finalDate { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime finalDateLocal => finalDate.ToLocalTime();

        public int typeDisability { get; set; }

        public TypeLicense TypeLicenses { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
