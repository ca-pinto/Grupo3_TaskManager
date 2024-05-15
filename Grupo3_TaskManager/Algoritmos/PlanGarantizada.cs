using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3_TaskManager.Algoritmos
{
    public class PlanGarantizada{

        private DataGridView datagridProcesos;
        private SistemaOperativo _sistemaOp;
        public PlanGarantizada(SistemaOperativo so) { 
            _sistemaOp = so;
        }

        public int distribucionQuantum(int quantum) {
            return quantum / GestorColas.ContarProcesos();
        }

        public void Ejecutar() {
            foreach (Procesos proceso in GestorColas.ObtenerProcesosOrdenadosPorTiempoLlegada()) {
                var procesoActual = GestorColas.EliminarProceso();

                if (procesoActual.TiempoCpu > 0) {
                    procesoActual.Estado = "Ejecución";
                    

                    if (procesoActual.TiempoCpu <= distribucionQuantum(_sistemaOp.Quantum)){
                        procesoActual.TiempoCpu = 0;
                        procesoActual.Estado = "Finalizado";

                    } else
                    {
                        procesoActual.TiempoCpu -= _sistemaOp.Quantum;
                        procesoActual.Estado = "Listo";


                        GestorColas.AgregarProceso(procesoActual);
                    }
                }

                
            }
        }
    }
}
