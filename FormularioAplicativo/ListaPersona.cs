using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioAplicativo
{
     public class ListaPersona
    {
        public List<Persona> Personas { set; get; }

        public ListaPersona()
        {
            Personas = new List<Persona>();
        }

        public void AnadirPersona(Persona persona)
        {
            Personas.Add(persona);
        }
    }
}
