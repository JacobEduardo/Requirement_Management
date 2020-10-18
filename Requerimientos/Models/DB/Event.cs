using System;
using System.Collections.Generic;

namespace Requerimientos.Models.BD
{
    public partial class Event
    {
        public Event()
        {
            History = new HashSet<History>();
        }

        public int IdEvent { get; set; }
        public string Name { get; set; }

        public virtual ICollection<History> History { get; set; }
    }
}
