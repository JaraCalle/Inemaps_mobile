using System;
using System.Collections.Generic;
using System.Text;

namespace VAMOS
{
    public class Dates
    {

        public string Name { get; set; }
        public string Ubicacion { get; set; }
        public string Url { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
