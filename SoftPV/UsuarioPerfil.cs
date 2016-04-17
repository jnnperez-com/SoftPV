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
    public partial class UsuarioPerfil : Form
    {
        public string username { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public bool is_superuser { get; set; }
        public bool is_staff { get; set; }
        public bool is_active { get; set; }
        public DateTime date_joined { get; set; }
        public string group { get; set; }

        public UsuarioPerfil()
        {
            InitializeComponent();
        }

        private void UsuarioPerfil_Load(object sender, EventArgs e)
        {
            checkActivo.Checked = this.is_active;
            checkAdmin.Checked = this.is_staff;
            checkSuperUser.Checked = this.is_superuser;
            txtUsuario.Text = this.username;
          txtNombre.Text= this.first_name;
            txtApellido.Text = this.last_name;
            txtCorreo.Text = this.email;
            txtPerfil.Text = this.group;
            txtFecha.Text = this.date_joined.ToString();
        }
    }
}
