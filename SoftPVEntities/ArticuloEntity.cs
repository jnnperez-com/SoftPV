using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftPV.Entities
{
    public class ArticuloEntity
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string img { get; set; }
        public string presentacion { get; set; }
        public string medida { get; set; }
        public double precioPro { get; set; }
        public double precioPub { get; set; }
        public string descripcion { get; set; }
        public string datecreated { get; set; }
        public int existenciaMIN { get; set; }
        public string dateupdate { get; set; }        
        public int proveedor { get; set; }
        public int user_id { get; set; }
    }
}
