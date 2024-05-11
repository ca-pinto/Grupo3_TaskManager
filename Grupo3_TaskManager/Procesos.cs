using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3_TaskManager
{
    public class Procesos
    {
        public int id;
        public string nombre;
        public int tiempoLlegada;
        public int tiempoCpu;
        public int prioridad;
        public string estado;
        public bool terminado;
        public int sorteo;

        public Procesos(int id, string nombre, int tiempoLlegada, int tiempoCpu, int prioridad, string estado, bool terminado, int sorteo)
        {

        }
    }
}
