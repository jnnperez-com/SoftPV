using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftPV.Entities;
using SoftPV.API;
using System.Data;

namespace SoftPV.BAL
{
    public class PermisoBAL
    {
        public int id { get; set; }
        public string codename { get; set; }
        public int content_type { get; set; }
        public string name { get; set; }

        public PermisoBAL() { }
        public static DataTable GetAllPermisos()
        {
            PermisoAPI _PermisoAPI = new PermisoAPI();
            return _PermisoAPI.GetAllPermisos();
        }

        public static List<PermisoEntity> GetAllPermisosList()
        {
            PermisoAPI _PermisoAPI = new PermisoAPI();
            return _PermisoAPI.GetAllPermisosList();
        }
        public static bool CheckMePermiso()
        {
            PermisoAPI _permiso = new PermisoAPI();
            return _permiso.CkeckMePermisos();
        }
    }
}
