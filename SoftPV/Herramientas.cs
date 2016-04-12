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

namespace SoftPV
{
    public partial class Herramientas : Form
    {
        //corores generales botones y color de letra
        int col1 = 094;
        int col2 = 153;
        int col3 = 033;

        //corores generales fondo
        int col21 = 234;
        int col22 = 255;
        int col23 = 209;

        public int HUsProveedores { get; set; }
        public int HUsClientes { get; set; }
        public int HUsEmpleados { get; set; }
        public int HUConfiguracion { get; set; }
       

        
        public Herramientas()
        {
            InitializeComponent();
            
        }

        private void AddFormInPanel(object formHijo)
        {
           this.panelherra.Controls.Clear();
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelherra.Controls.Add(fh);
            this.panelherra.Tag = fh;
            fh.Show();
        }
        private void Herramientas_Load(object sender, EventArgs e)
        {
            
            //color de fonfo 
            this.BackColor = System.Drawing.Color.FromArgb(col21, col22, col23);
            //color de las letras
            ForeColor = Color.FromArgb(col1, col2, col3);
           
            
        }

        private void btnmod8_Click(object sender, EventArgs e)
        {
          
        }

        private void btnmod7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnmod6_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new SoftPV.Proveedor());
        }

        private void btnmod9_Click(object sender, EventArgs e)
        {
           
        }
        
        
    }
}
