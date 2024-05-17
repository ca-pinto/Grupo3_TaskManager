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

        public static void EliminarProcesoPorId(int procesoId)
        {
            ColaProcesos.Where(p => p.Id != procesoId);
        }

        public static void EliminarProceso(Procesos proceso)
        {
            var procesos = ColaProcesos.Where(p => p.Id != proceso.Id).ToList();
            ActualizarCola(procesos);
        }

        public static int ContarProcesos()
        {
            return ColaProcesos.Count;
        }

        public static Queue<Procesos> ObtenerColaProcesos()
        {
            return ColaProcesos;
        }
        public static List<Procesos> OrdenarPorPrioridad()
        {
            var listaOrdenada = ColaProcesos.OrderByDescending(p => p.Prioridad).ToList();
            return listaOrdenada;
        }

        public static List<Procesos> OrdenarPorTiempoCpu()
        {
            return ColaProcesos.OrderBy(p => p.TiempoCpu).ToList();
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

        public static List<int> ObtenerIdsProcesos()
        {
            return ColaProcesos.Select(p => p.Id).ToList();
        }

        public static List<Procesos> ObtenerProcesosOrdenadosPorTiempoLlegada()
        {
            return ColaProcesos.OrderBy(p => p.TiempoLlegada).ToList();
        }

    }
}
