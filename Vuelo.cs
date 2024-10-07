using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos
{
    internal class Vuelo
    {
        public int Vuelo_ID {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Origen {  get; set; }
        public string Destino { get; set; }
        public string Asiento { get; set; }
        public int Fila { get; set; }
        public DateTime Fecha_Vuelta { get; set; }
        public DateTime Fecha_Ida { get; set; }
    }
}
