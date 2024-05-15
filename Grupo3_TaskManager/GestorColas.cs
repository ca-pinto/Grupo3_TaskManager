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

        public static void OrdenarPorPrioridad()
        {
            var listaOrdenada = ColaProcesos.OrderByDescending(p => p.Prioridad).ToList();
            ActualizarCola(listaOrdenada);
        }

        public static void OrdenarPorTiempoCpu()
        {
            var listaOrdenada = ColaProcesos.OrderBy(p => p.TiempoCpu).ToList();
            ActualizarCola(listaOrdenada);
        }

        public static void OrdenarPorTiempoLlegada()
        {
            var listaOrdenada = ColaProcesos.OrderBy(p => p.TiempoLlegada).ToList();
            ActualizarCola(listaOrdenada);
        }

        public static Procesos ObtenerProcesoPorId(int id)
        {
            return ColaProcesos.FirstOrDefault(p => p.Id == id);
        }

        public static void ActualizarCola(List<Procesos> listaOrdenada)
        {
            ColaProcesos.Clear();
            foreach (var proceso in listaOrdenada)
            {
                ColaProcesos.Enqueue(proceso);
            }
        }
    }
}
