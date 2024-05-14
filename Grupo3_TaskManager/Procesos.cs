using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3_TaskManager
{
    public class Procesos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TiempoLlegada { get; set; }
        public int TiempoCpu { get; set; }
        public int Prioridad { get; set; }
        public string Estado { get; set; }
        public bool Terminado { get; set; }
        public string Algoritmo { get; set; }
        public int? Sorteo { get; set; } // Sorteo es opcional


        public Procesos(int id, string nombre, int tiempoLlegada, int tiempoCpu, int prioridad, string estado, bool terminado, string algoritmo, int? sorteo = null)
        {
            Id = id;
            Nombre = nombre;
            TiempoLlegada = tiempoLlegada;
            TiempoCpu = tiempoCpu;
            Prioridad = prioridad;
            Estado = estado;
            Terminado = terminado;
            Algoritmo = algoritmo;
            Sorteo = sorteo;
        }


    }
}
