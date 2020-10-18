using System;
using System.Collections.Generic;

namespace Requerimientos.Models.BD
{
    public partial class Mensaje
    {
        public int IdMensaje { get; set; }
        public string Body { get; set; }
        public int IdForo { get; set; }
        public int IdTecnicoArl { get; set; }

        public virtual Foro IdForoNavigation { get; set; }
        public virtual TecnicoArl IdTecnicoArlNavigation { get; set; }
    }
}
