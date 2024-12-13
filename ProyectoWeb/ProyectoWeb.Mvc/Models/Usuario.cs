using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.Mvc.Models
{
    public class Usuario
    {
  
            public int Id { get; set; }

            [Required(ErrorMessage = "Se requiere un nombre")]
            public string Nombre { get; set; } = string.Empty;

            [Required(ErrorMessage = "Se requiere un correo")]
            [EmailAddress]
            public string Correo { get; set; } = string.Empty;

            [Required(ErrorMessage = "Se requiere una contraseña")]
            [DataType(DataType.Password)]
            public string Contrasenna { get; set; } = string.Empty;

            public string ConfirmarContrasenna { get; set; } = string.Empty;

        }


    }
