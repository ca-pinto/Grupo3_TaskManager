using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3_TaskManager
{
    internal class GestorColas
    {
        public static Queue<Procesos> ColaProcesos { get; } = new Queue<Procesos>();

        public static void AgregarProceso(Procesos proceso)
        {
            ColaProcesos.Enqueue(proceso);
        }

        public static Procesos EliminarProceso()
        {
            return ColaProcesos.Dequeue();
        }

        public static int ContarProcesos()
        {
            return ColaProcesos.Count;
        }

        public static Queue<Procesos> ObtenerColaProcesos()
        {
            return ColaProcesos;
        }


    }
}
