using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftPV.BAL;
using SoftPV.Entities;

namespace SoftPV
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

       

        private void Login_Load(object sender, EventArgs e)
        {
            //eventos para los combobox username y  password
            this.txtUsername.Enter += new EventHandler(txtUsername_Enter);
            this.txtUsername.Leave += new EventHandler(txtUsername_Leave);
            txtUsername_SetText();
            this.txtPassword.Enter += new EventHandler(txtPassword_Enter);
            this.txtPassword.Leave += new EventHandler(txtPassword_Leave);
            txtPassword_SetText();
            this.ActiveControl = pictureBox1; //activa el control pic 
        }


        //Eventos de adornos
        private void picLogin_MouseHover(object sender, EventArgs e)
        {
            picLogin.Size = new Size(190, 57);
        }
        private void picLogin_MouseLeave(object sender, EventArgs e)
        {
            picLogin.BackgroundImageLayout = ImageLayout.Stretch;
            picLogin.Size = new Size(185, 47);
        }
        protected void txtUsername_SetText()
        {
            this.txtUsername.Text = "Usuario";
            txtUsername.ForeColor = Color.Gray;
        }
        protected void txtPassword_SetText()
        {
            this.txtPassword.Text = "Contraseña";
            txtPassword.ForeColor = Color.Gray;
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.ForeColor == Color.Black)
                return;
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Black;
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
                txtUsername_SetText();
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.ForeColor == Color.Black)
                return;
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
                txtPassword_SetText();
        }

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://jperez.soy");
            Process.Start(sInfo);
        }

        private void picLogin_Click(object sender, EventArgs e)
        {
            //checa si esta vacia el textbox
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Escriba su Nombre de Usuario");
                return;
            }
            //checa si esta vacia el textbox
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Escriba su Contraseña");
                return;
            }
            UserBAL _UserBal = new UserBAL();
            _UserBal.username = txtUsername.Text;
            _UserBal.password = txtPassword.Text;
            if (_UserBal.IsLoginUs() == true)
            {
                if (UserBAL.CheckMeUser() == true)
                {
                    Home _Home = new Home();
                    _Home.Show();
                }
                else { MessageBox.Show(msError.ErrorMessage); }
                
                
            }
            else { MessageBox.Show(msError.ErrorMessage); }


        }
    }

}
