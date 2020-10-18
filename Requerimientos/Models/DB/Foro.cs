using System;
using System.Collections.Generic;

namespace Requerimientos.Models.BD
{
    public partial class Foro
    {
        public Foro()
        {
            Mensaje = new HashSet<Mensaje>();
        }

        public int IdForo { get; set; }
        public string Title { get; set; }
        public string Descripcion { get; set; }
        public int IdRequest { get; set; }

        public virtual Request IdRequestNavigation { get; set; }
        public virtual ICollection<Mensaje> Mensaje { get; set; }
    }
}
