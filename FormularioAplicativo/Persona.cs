using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioAplicativo
{
    public class Persona
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int Cedula { set; get; }
        public int Edad { set; get; }
        public string Genero { set; get; }

        public Persona ()
        {

        }

        public Persona (string nombre, string apellido,int cedula, int edad,string genero)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Edad= edad;
            Genero = genero;
        }

    }
}
