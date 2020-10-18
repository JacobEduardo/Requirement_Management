using System;
using System.Collections.Generic;

namespace Requerimientos.Models.BD
{
    public partial class Request
    {
        public Request()
        {
            Foro = new HashSet<Foro>();
            History = new HashSet<History>();
        }

        public int IdRequest { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Foster { get; set; }

        public virtual ICollection<Foro> Foro { get; set; }
        public virtual ICollection<History> History { get; set; }
    }
}
