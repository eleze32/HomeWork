using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Datos
{
    public partial class UsuarioMetadata
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string RepetirEmail { get; set; }
        public string numCelular { get; set; }
        public string contrasenia { get; set; }
        public string RepetirContrasenia { get; set; }
    }
}
