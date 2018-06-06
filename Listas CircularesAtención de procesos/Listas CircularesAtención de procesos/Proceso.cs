using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_CircularesAtención_de_procesos
{
    class Proceso
    {
        public int ciclos { get; set; }
        public Proceso siguiente { get; set; }
        public Proceso anterior { get; set; }

        static Random rand = new Random();

        public Proceso()
        {
            ciclos = rand.Next(4, 15);
            siguiente = null;
            anterior = null;
        }
    }
}

