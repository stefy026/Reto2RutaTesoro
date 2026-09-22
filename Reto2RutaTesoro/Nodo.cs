using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2RutaTesoro
{
    public class Nodo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pista { get; set; }
        public int Peligro { get; set; }

        public Nodo? Siguiente { get; set; }

        public Nodo(int id, string nombre, string pista, int peligro)
        {
            Id = id;
            Nombre = nombre;
            Pista = pista;
            Peligro = peligro;
            Siguiente = null;
        }
    }
}