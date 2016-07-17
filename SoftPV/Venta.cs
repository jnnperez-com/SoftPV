using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftPV.BAL;
using SoftPV.Entities;

namespace SoftPV
{
    public partial class Venta : Form
    {
        #region COLORES y estilos
        //corores generales botones y color de letra
        int col1 = 094;
        int col2 = 153;
        int col3 = 033;

        //corores generales fondo
        int col21 = 234;
        int col22 = 255;
        int col23 = 209;

        private void CargarLoadEstilos() {
            
            //color de fonfo 
            this.BackColor = System.Drawing.Color.FromArgb(col21, col22, col23);
            //color de las letras
            ForeColor = Color.FromArgb(col1, col2, col3);
            //colores de los texbox 
            this.txtcodigo.ForeColor = Color.FromArgb(col1, col2, col3);
            this.txtcantidad.ForeColor = Color.FromArgb(col1, col2, col3);
            this.txtimporte.ForeColor = Color.FromArgb(col1, col2, col3);
            //estilo de la tabla 
            this.dgVenta.BackgroundColor = Color.FromArgb(col21, col22, col23);
            dgVenta.EnableHeadersVisualStyles = false;
            dgVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(col1, col2, col3);
            dgVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(col21, col22, col23);
            this.dgVenta.BorderStyle = BorderStyle.Fixed3D;
            dgVenta.AutoGenerateColumns = false;
            dgVenta.RowHeadersVisible = false;
            //texto campo cantida default con valor de 1 txtcantidad

            txtcantidad.Text = "1";

            txtnotanum.Text = numNota.ToString();
        }
        #endregion
        //variable nota num
        int numNota =0;
        DataTable dtListArt = new DataTable();  
              
        public Venta()
        {
            InitializeComponent();
             
            

        }
              
        private void Venta_Load(object sender, EventArgs e)
        {
            CargarLoadEstilos();

            //Crear Columnas de la tabla
            dtListArt.Columns.Add("id", typeof(int));
            dtListArt.Columns.Add("codigo", typeof(string));
            dtListArt.Columns.Add("nombre", typeof(string));
            dtListArt.Columns.Add("precio", typeof(double));
            dtListArt.Columns.Add("cantidad", typeof(double));
            dtListArt.Columns.Add("importe", typeof(double));
           

        }
        
        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtcantidad.Text.Length; i++)
            {
                if (txtcantidad.Text[i] == '.')
                { IsDec = true; }

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            { e.Handled = false; }
            else if (e.KeyChar == 46)
            { e.Handled = (IsDec) ? true : false; }
            else
            { e.Handled = true; }
        }

        private void btnAgregarpro_Click(object sender, EventArgs e)
        {
            AddRowdtArticulo();
          
        }
        
        private void AddRowdtArticulo()//nena la tabal venta
        {
            if (string.IsNullOrWhiteSpace(txtcodigo.Text))
            {
                MessageBox.Show("Escriba el Código del Producto");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtcantidad.Text))
            {
                MessageBox.Show("Escriba la Cantidad que desea Vender");
                return;
            }

            ArticuloBAL articulo = new ArticuloBAL();
            articulo.codigo = txtcodigo.Text;
            articulo.GetCodeArticulo();
            if (articulo.id > 0)
            {
                DataRow dr = dtListArt.NewRow();
                dr["id"] = articulo.id;
                dr["codigo"] = articulo.codigo;
                dr["nombre"] = articulo.nombre;
                dr["precio"] = Precio(articulo.precioPro, articulo.precioPub);
                dr["cantidad"] = txtcantidad.Text;
                dr["importe"] = Importe(articulo.precioPro, articulo.precioPub, Double.Parse(txtcantidad.Text.ToString()));

                dtListArt.Rows.Add(dr);
                dgVenta.DataSource = dtListArt;
               txtimporte.Text = dtListArt.AsEnumerable().Sum(x => x.Field<double>("importe")).ToString();
            }
            else { MessageBox.Show("No se encontro ningún producto"); }
            
        }

        private double Importe(double PrecioPro, double PrecioPub, double Cantidad)
        {
            RadioButton checkedButton = this.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            double c;
            if (checkedButton.Name == "rbtnclieeventual")
            {
                 
                c = Math.Round(PrecioPub * Cantidad, 2);
                return c;
            }
            else {
                c = Math.Round(PrecioPro * Cantidad, 2);
                return c ; }
           
        }
        private double Precio(double PrecioPro, double PrecioPub)
        {
            RadioButton checkedButton = this.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton.Name == "rbtnclieeventual")
            {
                return PrecioPub ;
            }
            else { return PrecioPro; }

        }
        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
