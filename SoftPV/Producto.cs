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
    public partial class Producto : Form
    {
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
            
        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }
    }
}
