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
    public partial class Producto : Form
    {
        //variable global en esta clse
        string RutaIMG="";
        public Producto()
        {
            InitializeComponent();
        }
        //metodo para crear formularios hijose
        private void AddFormInPanel(object formHijo)
        {
            this.panelPro.Controls.Clear();
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelPro.Controls.Add(fh);
            this.panelPro.Tag = fh;
            fh.Show();
        }

        //Boton de Nuevo al hacer click en ella
        private void btnNproducto_Click(object sender, EventArgs e)
        {
            this.panelNProducto.Visible = true;
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            cboxProveedor.DataSource = ProveedorBAL.GetAllProveedore();
            cboxProveedor.ValueMember = "Id";
            cboxProveedor.DisplayMember = "nombreEmpresa";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
               
                RutaIMG = openFileDialog1.FileName.ToString();
                lblImgen.Text= RutaIMG;
            }
        }

        private void GuardarproN_Click(object sender, EventArgs e)
        {
            ArticuloBAL _ArticuloBAL = new ArticuloBAL();
            _ArticuloBAL.codigo = txtCodigoArt.Text;
            _ArticuloBAL.nombre = txtNombreArt.Text;
            if (RutaIMG != "")
            { _ArticuloBAL.img = openFileDialog1.FileName.ToString(); }
           
            _ArticuloBAL.presentacion = txtPresentacionArt.Text;
           
            double valor1 ;
            bool estado1 = double.TryParse(txtPrecioProv.Text, out valor1);
            if (estado1)
            { _ArticuloBAL.precioPro = valor1; }

            double valor2;
            bool estado2 = double.TryParse(txtPrecioProv.Text, out valor2);
            if (estado2)
            { _ArticuloBAL.precioPub = valor2; }
            int valor3;
            bool estado3 = Int32.TryParse(txtPrecioProv.Text, out valor3);
            if (estado3)
            { _ArticuloBAL.existenciaMIN = valor3; }
            _ArticuloBAL.descripcion = txtDescripcionArt.Text;         
            _ArticuloBAL.proveedor = Int32.Parse(cboxProveedor.SelectedValue.ToString());
            var checkedButton = this.groupMedica.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            _ArticuloBAL.medida =  checkedButton.Text;
            if (_ArticuloBAL.AddArticulo() == true)
            {
                MessageBox.Show("Mensaje");
            }
            else { MessageBox.Show(msError.ErrorMessage); }
        }
    }
}
