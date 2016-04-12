using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftPV.Entities
{
    public class ProveedorEntity
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombreEmpresa { get; set; }
        public string direccion { get; set; }
        public string tel { get; set; }
        public string cel { get; set; }
        public string descripcion { get; set; }
        public string correo { get; set; }
        public int user { get; set; }
    }
}
