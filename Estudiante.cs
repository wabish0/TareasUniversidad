using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    internal class Estudiante : MienbroDeLaComunidad
    {
        public int IdEstudiante {  get; set; }
        public string CentroEstudio {  get; set; }
        public int Curso {  get; set; }
    }
}
