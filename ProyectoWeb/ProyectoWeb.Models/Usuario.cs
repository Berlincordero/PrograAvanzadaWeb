using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
    public class Usuario
    {
        public long Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Se requiere un correo")]
        [EmailAddress]
        public string Correo { get; set; } = string.Empty;

        public bool UsaClaveTemp { get; set; }
        public DateTime Vigencia { get; set; }
        public string Token { get; set; } = string.Empty;

        [Required(ErrorMessage = "Se requiere una contraseña")]
        [DataType(DataType.Password)]
        public string Contrasenna { get; set; } = string.Empty;
    }


}