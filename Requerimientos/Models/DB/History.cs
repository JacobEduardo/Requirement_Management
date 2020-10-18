using System;
using System.Collections.Generic;

namespace Requerimientos.Models.BD
{
    public partial class History
    {
        public int IdHistory { get; set; }
        public DateTime CreateDate { get; set; }
        public int IdEvent { get; set; }
        public string EventMessage { get; set; }
        public int IdRequest { get; set; }
        public int IdTecnicoArl { get; set; }

        public virtual Event IdEventNavigation { get; set; }
        public virtual Request IdRequestNavigation { get; set; }
        public virtual TecnicoArl IdTecnicoArlNavigation { get; set; }
    }
}
