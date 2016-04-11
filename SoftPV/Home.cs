using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftPV
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        

        private void Home_Load(object sender, EventArgs e)
        {

        }

        //Eventos form cerrar maximizar -+x
        private void picxbut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picxbut_MouseHover(object sender, EventArgs e)
        {
            picxbut.Size = new Size(32, 32);
        }
        private void picxbut_MouseLeave(object sender, EventArgs e)
        {
            picxbut.BackgroundImageLayout = ImageLayout.Stretch;
            picxbut.Size = new Size(26, 26);
        }

        private void picmasb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void picmasb_MouseHover(object sender, EventArgs e)
        {
            picmasb.Size = new Size(32, 32);
        }
        private void picmasb_MouseLeave(object sender, EventArgs e)
        {
            picmasb.BackgroundImageLayout = ImageLayout.Stretch;
            picmasb.Size = new Size(26, 26);
        }
        private void picmensob_Click(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }
            else 
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        private void picmensob_MouseHover(object sender, EventArgs e)
        {
            picmensob.Size = new Size(32, 32);
        }
        private void picmensob_MouseLeave(object sender, EventArgs e)
        {
            picmensob.BackgroundImageLayout = ImageLayout.Stretch;
            picmensob.Size = new Size(26, 26);
        }

        private void picayuda_Click(object sender, EventArgs e)
        {

        }
        private void picayuda_MouseHover(object sender, EventArgs e)
        {
            picayuda.Size = new Size(32, 32);
        }
        private void picayuda_MouseLeave(object sender, EventArgs e)
        {
            picayuda.BackgroundImageLayout = ImageLayout.Stretch;
            picayuda.Size = new Size(26, 26);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            //llama como formulario hijo al formulario venta
            AddFormInPanel(new SoftPV.Venta());
        }

        //metodo para para crear formularios hijos en el panelContenedor
        private void AddFormInPanel(object formHijo)
        {
            this.panelContenedor.Controls.Clear();
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Producto());
        }
    }
}
