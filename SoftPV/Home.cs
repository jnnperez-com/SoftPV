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

using System.Runtime.InteropServices;
namespace SoftPV
{
    public partial class Home : Form
    {
       
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Home()
        {
            InitializeComponent();
        }
            

        private void Home_Load(object sender, EventArgs e)
        {
            CargarDATOS_me();
        }

        #region MÉTODOS DE MINIMIZAR, MAXIMIZAR, CERRAR, AYUDA
        //Eventos form cerrar maximizar -+x
        private void picxbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        #endregion

        private void btnVenta_Click(object sender, EventArgs e)
        {
            //llama como formulario hijo al formulario venta
            AddFormInPanel(new SoftPV.Venta());
        }       

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Producto());
        }

        #region MÉTODOS
        private void CargarDATOS_me()
        {
            UserBAL _UserBal = new UserBAL();
            _UserBal.Yo();
            tsUsername.Text = _UserBal.username;
            tsFullname.Text = _UserBal.get_full_name;
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

        #endregion

        #region FUNCIONES

        #endregion

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                this.btnVenta.PerformClick(); //genera evento click
                this.btnVenta.Focus();
                return true;    //indica la pulación del teclado
            }
            if (keyData == Keys.F2)
            {
                this.btnProductos.PerformClick(); //genera evento click
                this.btnProductos.Focus();
                return true;    //indica la pulación del teclado
            }

            // llama a la clase base
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void menu6_Click(object sender, EventArgs e)
        {
            //llama como formulario hijo al formulario venta
            AddFormInPanel(new SoftPV.Herramientas());
        }
    }
}
