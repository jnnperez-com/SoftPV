using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftPV.Entities
{
   public class UserEntity
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public List<object> groups { get; set; }
        public List<object> user_permissions { get; set; }
        public bool is_superuser { get; set; }
        public bool is_staff { get; set; }
        public bool is_active { get; set; }
        public string date_joined { get; set; }
        public string get_full_name { get; set; }
    }
}
