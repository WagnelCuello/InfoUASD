using System;
using System.ComponentModel.DataAnnotations;


namespace InfoUASD.Models.Models
{
    public class User
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50)]
        [MinLength(3, ErrorMessage = "Debe tener un minimo de 3 caracteres")]
        [Display(Name = "Nombres")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(50)]
        [MinLength(3, ErrorMessage = "Debe tener un minimo de 3 caracteres")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "El email no es correcto")]
        [StringLength(90)]
        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }

        [EmailAddress(ErrorMessage = "Ingrese un nombre de usuario")]
        [StringLength(20)]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Ingrese una contraseña")]
        [StringLength(50)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(15)]
        [MinLength(10)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El Rol es requerido")]
        [StringLength(20)]
        [Display(Name = "Rol")]
        public string Rol { get; set; }

        [Display(Name = "Fecha")]
        public Nullable<DateTime> Date { get; set; }

        [Required(ErrorMessage = "El Estado es Requerido")]
        [StringLength(10)]
        [Display(Name = "Estado")]
        public string Status { get; set; }
    }
}
