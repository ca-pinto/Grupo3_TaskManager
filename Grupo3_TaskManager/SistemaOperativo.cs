using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3_TaskManager
{
    public  class SistemaOperativo
    {
        public int Quantum { get; set; }
        
        public SistemaOperativo(int quantum) { 
            Quantum = quantum;
            
        }

        public int GetQuantum() { 
            return Quantum;
        }
    }
}
