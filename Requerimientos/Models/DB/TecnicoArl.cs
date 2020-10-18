using System;
using System.Collections.Generic;

namespace Requerimientos.Models.BD
{
    public partial class TecnicoArl
    {
        public TecnicoArl()
        {
            History = new HashSet<History>();
            Mensaje = new HashSet<Mensaje>();
        }

        public int IdTecnicoArl { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }

        public virtual ICollection<History> History { get; set; }
        public virtual ICollection<Mensaje> Mensaje { get; set; }
    }
}
