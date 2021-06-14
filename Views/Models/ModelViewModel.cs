using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ModelViewModel
    {
        public int id { get; set; }

        public string brand  { get; set; }
        public string  name { get; set; }

        public string tipo { get; set; }
        public string color { get; set; }

        public string motor { get; set; }

        public DateTime fecha_creo { get; set; }

    }
}
