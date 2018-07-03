using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LoginTableau.ViewModel
{
    public class UsuarioLoginViewModel
    {
        [Required]
        [MinLength(3), MaxLength(40)]
        [DisplayName("Usuario")]
        public string nombre_usuario { get; set; }

        [Required]
        [DisplayName("Contraseña")]
        public string contraseña { get; set; }
    }
}