using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data.Entities
{
    public class Rep
    {   
        [Required]
        public int proyecto { get; set; }
        [Required(ErrorMessage = "The Rep_id is required")]
        [Key]
        public int rep_id { get; set; }
        [MaxLength(50)]
        public string ruid { get; set; }
        [MaxLength(100)]
        public string rname { get; set; }
        [MaxLength(50)]
        public string remail { get; set; }
        public int ractivo { get; set; }
        public int rtipo { get; set; }
        public int pais { get; set; }
        public int rcedula { get; set; }
        public int rempresa { get; set; }
        [MaxLength(20)]
        public string rcodigo { get; set; }
        [MaxLength(20)]
        public string rextension { get; set; }
        public int rdependencia { get; set; }
        public int rsede { get; set; }
        public int rceco { get; set; }
        [MaxLength(20)]
        public string rorden_interna { get; set; }
        public int gestiona_tiquetes { get; set; }
        public int gerente { get; set; }
        public int rcargo { get; set; }
        public int directivo { get; set; }
        public int tipo_regimen_salarial { get; set; }
        [MaxLength(100)]
        public string url_foto { get; set; }
        public int resp_th { get; set; }
        public int resp_aviatur { get; set; }
        public int resp_formacion { get; set; }
        public int resp_traslados { get; set; }
        public int resp_prestamos { get; set; }
        public int relacion_laboral { get; set; }
        public int resp_plan_e_e { get; set; }

    }


}
