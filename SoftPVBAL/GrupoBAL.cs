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
    public class GrupoBAL
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<int> permissions { get; set; }
        public GrupoBAL() { }
        
        public static bool AddGrupo(string Nombre, List<int> Permisos)
        {
            GrupoEntity _GrupoEntity = new GrupoEntity();
            _GrupoEntity.permissions = Permisos;
            _GrupoEntity.name = Nombre;            

            GrupoAPI _GrupoAPI = new GrupoAPI();
            return _GrupoAPI.AddGrupo(_GrupoEntity);
        }
        public static bool UpdateGrupo(int Id, string Nombre, List<int> Permisos)
        {
            GrupoEntity _GrupoEntity = new GrupoEntity();
            _GrupoEntity.id = Id;
            _GrupoEntity.permissions = Permisos;
            _GrupoEntity.name = Nombre;

            GrupoAPI _GrupoAPI = new GrupoAPI();
            return _GrupoAPI.UpdateGrupo(_GrupoEntity);
        }
        public static DataTable GetAllGrupos()
        {
            GrupoAPI _GrupoAPI = new GrupoAPI();
            return _GrupoAPI.GetAllGrupos();
        }
        public static GrupoEntity GetOneGrupo(int Id)
        {
            GrupoAPI _GrupoAPI = new GrupoAPI();
            return _GrupoAPI.GetOneGrupo(Id);
        }
        public static bool CheckMeGrupo()
        {
            GrupoAPI _grupo = new GrupoAPI();
            return _grupo.CkeckMeGrupo();
        }
        public bool AddGrupo()
        {
            return AddGrupo(this.name,this.permissions);
        }
        public bool UpdateGrupo()
        {
            return UpdateGrupo(this.id,this.name, this.permissions);
        }
        public void GetOneGrupo()
        {
            GrupoEntity grupo = new GrupoEntity();
            grupo = GetOneGrupo(this.id);
            if( grupo.id == 0)
            {
                this.id = 0;
                return;
            }
            this.id = grupo.id;
            this.name = grupo.name;
            this.permissions = grupo.permissions;
            
        }

    }
}
