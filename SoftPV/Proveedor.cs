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
    public partial class Proveedor : Form
    {
        

        public Proveedor()
        {
            InitializeComponent();
        }


        //metodo para craer formulario hijos en el panel contendor llamado paneCproveedor
        public  void AddFormInPanel(object formHijo)
        {
            if (this.paneCproveedor.Controls.Count > 0)
                this.paneCproveedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.paneCproveedor.Controls.Add(fh);
            this.paneCproveedor.Tag = fh;
            fh.Show();
        }//panel 

        
      
        private void Proveedor_Load(object sender, EventArgs e)
        {
            this.btnNproveedor.Focus();
            this.btnNproveedor.ForeColor = Color.Gray;
            this.paneCproveedor.Visible = true;
        }
        //boton para abrir la ventana agregar nuevo proveedor
       private void btnNproveedor_Click(object sender, EventArgs e)
        {
           
            paneCproveedor.Visible = true;
            this.paneListProveedor.Visible = false;


        }//agregar
       
        //boton para abrir la ventana Modificar nuevo proveedor
        private void btnMproveedor_Click(object sender, EventArgs e)
       {
                          
        }//modificar

        private void btnRproveedor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.paneCproveedor.Visible = false;
            this.paneListProveedor.Visible = true;
            this.dataGridView1.DataSource = ProveedorBAL.GetAllProveedore();
            Cursor.Current = Cursors.Default;
        }

        private void btnEproveedor_Click(object sender, EventArgs e)
        {
            this.paneCproveedor.Visible = false;
            this.paneListProveedor.Visible = false;

        }

        private void btnGuardarProvedor_Click(object sender, EventArgs e)
        {

            ProveedorBAL _ProveedorBAL = new ProveedorBAL();
            _ProveedorBAL.codigo = txtCodigoProvedor.Text;
            _ProveedorBAL.nombreEmpresa = txtEmpresa.Text;
            _ProveedorBAL.direccion = txtDireccion.Text;
            _ProveedorBAL.tel = txtTel.Text;
            _ProveedorBAL.cel = txtCel.Text;
            _ProveedorBAL.descripcion = txtDescripcion.Text;
            _ProveedorBAL.correo = txtCorre.Text;
            if (_ProveedorBAL.AddProveedor() == true)
            {
                Limpiartxt();
            }
            else { MessageBox.Show(msError.ErrorMessage); }

        }

        private void Limpiartxt()
        {
            txtCodigoProvedor.Text = "";
            txtEmpresa.Text = "";
            txtDireccion.Text ="";
             txtTel.Text ="";
             txtCel.Text="";
           txtDescripcion.Text="";
             txtCorre.Text ="";
        }

        private void btnCproveedor_Click(object sender, EventArgs e)
        {
            this.btnCproveedor.Image = global::SoftPV.Properties.Resources.cancelar1;
            Limpiartxt();
            this.btnCproveedor.Image = global::SoftPV.Properties.Resources.cancelar2;
        }
    }
}
