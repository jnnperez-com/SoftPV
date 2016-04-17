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
    public class ArticuloBAL
    {
        #region ATRIBUTOS
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
        #endregion
        public ArticuloBAL() { }
        public static bool AddArticulo(string Codigo, string Nombre, string Img, string Presentacion, string Medica, double PrecioProve, double PrecioPu, string Descripcion, int ExistenciaMin, int Proveedor)
        {
            ArticuloEntity _ArticuloEntity = new ArticuloEntity();
            _ArticuloEntity.codigo = Codigo;
            _ArticuloEntity.nombre = Nombre;
            _ArticuloEntity.img = Img;
            _ArticuloEntity.presentacion = Presentacion;
            _ArticuloEntity.medida = Medica;
            _ArticuloEntity.precioPro = PrecioProve;
            _ArticuloEntity.precioPub = PrecioPu;
            _ArticuloEntity.descripcion = Descripcion;
            _ArticuloEntity.existenciaMIN = ExistenciaMin;
            _ArticuloEntity.proveedor = Proveedor;

            ArticuloAPI _ArticuloAPI = new ArticuloAPI();

            return _ArticuloAPI.AddArticulo(_ArticuloEntity);
        }
        public static DataTable GetAllArticulo()
        {
            ArticuloAPI _articulo = new ArticuloAPI();
            return _articulo.GetAllArticulos();
        }
        public static bool CheckMeArticulo()
        {
            ArticuloAPI articulo = new ArticuloAPI();
            return articulo.CkeckMeArticulo();
        }
        public bool AddArticulo()
        {
            return AddArticulo(this.codigo, this.nombre, this.img, this.presentacion, this.medida, this.precioPro, this.precioPub, this.descripcion, this.existenciaMIN, this.proveedor);
        }
    }
}
