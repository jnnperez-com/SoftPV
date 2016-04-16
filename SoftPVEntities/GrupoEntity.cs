using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftPV.Entities
{
   public  class GrupoEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<int> permissions { get; set; }
    }
}
