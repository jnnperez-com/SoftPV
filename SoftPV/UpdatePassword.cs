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
    public partial class UpdatePassword : Form
    {
        public int id { get; set; }
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void btnGempl_Click(object sender, EventArgs e)
        {
            UserBAL user = new UserBAL();
            user.id = this.id;
            user.pass1 = txtpasword1.Text;
            user.pass2 = txtpasword2.Text;
            if (user.ChangePassword() == true)
            {
                MessageBox.Show("Password Cambiado");
                this.Close();
            }
            else {
                MessageBox.Show(msError.ErrorMessage);
            }
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnCempl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
