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
    public class ProveedorBAL
    {
        #region CAMPOS
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombreEmpresa { get; set; }
        public string direccion { get; set; }
        public string tel { get; set; }
        public string cel { get; set; }
        public string descripcion { get; set; }
        public string correo { get; set; }
        public int user { get; set; }

        #endregion

        public ProveedorBAL() { }
        public ProveedorBAL(int Id, string Codigo, string NomEmpresa, string Direccion, string Tel, string Cel, string Descripcion, string Correo, int User) {
            this.id = Id;
            this.codigo = Codigo;
            this.nombreEmpresa = NomEmpresa;
            this.direccion = Direccion;
            this.tel = Tel;
            this.cel = Cel;
            this.descripcion = Descripcion;
            this.correo = Correo;
            this.user = User;
        }
        public static bool AddProveedor(string Codigo, string NomEmpresa, string Direccion, string Tel, string Cel, string Descripcion, string Correo) {
            ProveedorEntity _ProveedorEntity = new ProveedorEntity();
            _ProveedorEntity.codigo = Codigo;
            _ProveedorEntity.nombreEmpresa = NomEmpresa;
            _ProveedorEntity.direccion = Direccion;
            _ProveedorEntity.tel = Tel;
            _ProveedorEntity.cel = Cel;
            _ProveedorEntity.descripcion = Descripcion;
            _ProveedorEntity.correo = Correo;

            ProveedorAPI _ProveedorAPI = new ProveedorAPI();

            return _ProveedorAPI.AddProveedor(_ProveedorEntity);
        }
        public static DataTable GetAllProveedore()
        {
            ProveedorAPI _provedor = new ProveedorAPI();
           return _provedor.GetAllProveedores();
        }
        public bool AddProveedor()
        {
            return AddProveedor(this.codigo, this.nombreEmpresa, this.direccion, this.tel, this.cel, this.descripcion, this.correo);
        }

    }
}
