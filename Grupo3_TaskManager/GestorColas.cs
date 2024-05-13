using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3_TaskManager
{
    internal class GestorColas
    {
        private static Queue<Procesos> colaProcesos = new Queue<Procesos>();

        public static void AgregarProceso(Procesos proceso)
        {
            colaProcesos.Enqueue(proceso);
        }

        public static Procesos EliminarProceso()
        {
            return colaProcesos.Dequeue();
        }

        public static int ContarProcesos()
        {
            return colaProcesos.Count;
        }
    }
}
