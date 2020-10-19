using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Requerimientos.Models
{
    public class History
    {
        public int IdHistory { get; set; }
        public int IdEvent { get; set; }
        public string EventMessage { get; set; }
        public int IdRequest { get; set; }
        public int IdTecnicoArl { get; set; }
        public string eventname { get; set; }
        public string requerimiento_titulo { get; set; }
        public string requerimiento_body { get; set; }
        public string requerimiento_forter { get; set; }
        public string tecnicoARL { get; set; }

    }
}
