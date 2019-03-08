using System;
using System.ComponentModel.DataAnnotations;

namespace InfoUASD.Models.Models
{
    public class Info
    {
        [Key]
        [Display(Name = "Codigo")]
        public int InfoID { get; set; }

        [Required(ErrorMessage = "Codigo Usuario requerido")]
        [Display(Name = "CodUsuario")]
        public int UserID { get; set; }

        [StringLength(2000)]
        [Display(Name = "Informacion")]
        public string Inf { get; set; }

        [StringLength(50)]
        [Display(Name = "Imagen")]
        public string Image { get; set; }

        [StringLength(7)]
        [Display(Name = "Estado")]
        public string Status { get; set; }

        [Display(Name = "Fecha")]
        public Nullable<DateTime> Date { get; set; }

        [Display(Name = "Usuario")]
        public virtual User User { get; set; }
    }
}
