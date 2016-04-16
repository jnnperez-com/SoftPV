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
    public partial class Empleados : Form
    {
        public bool is_superuser = false;
        public bool is_staff = false;
        public bool is_active = false;
        public List<int> groups = new List<int>();

        public Empleados()
        {
            InitializeComponent();
        }

        //metodo para craer formulario hijos en el panel contendor llamado panelCon
        private void AddFormInPanel(object formHijo)
        {
            if (this.panelCon.Controls.Count > 0)
                this.panelCon.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelCon.Controls.Add(fh);
            this.panelCon.Tag = fh;
            fh.Show();
        }

        private void btnNuevoEmpl_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnMempl_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEempl_Click(object sender, EventArgs e)
        {
        
        }

        private void btnRempl_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void imgpass_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Permisos per = new Permisos();
            per.ShowDialog();
            this.is_active = per.is_active;
            this.is_staff = per.is_staff;
            this.groups = per.groups;
            this.is_superuser = per.is_superuser;
            per.Close();
        }

        private void btnGempl_Click(object sender, EventArgs e)
        {
            UserBAL user = new UserBAL();
            user.username = txtUsername.Text;
            user.first_name = txtnombre.Text;
            user.last_name = txtapellido.Text;
            user.email = txtcorreo.Text;
            user.groups = this.groups;
            user.is_active = this.is_active;
            user.is_staff = this.is_staff;
            user.is_superuser = this.is_superuser;

            if (user.AddUser() == true)
            {
                MessageBox.Show("Se guardado usuario");
            }
            else { MessageBox.Show(msError.ErrorMessage); }
            
        }
    }
}
