using System;
using System.Collections.Generic;

namespace Universitario.Models
{
    public partial class Estudiantes
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool? Estatus { get; set; }
        public string Carrera { get; set; }
    }
}
