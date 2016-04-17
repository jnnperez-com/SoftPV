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
        public int id { get; set; }
        public bool is_superuser = false;
        public bool is_staff = false;
        public bool is_active = false;
        public List<int> groups = new List<int>();
        private string AddOrUpdate;
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
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (!PermisoBAL.CheckMePermiso()) { MessageBox.Show(msError.ErrorMessage + " EN Permiso"); return; }
            if (!GrupoBAL.CheckMeGrupo()) { MessageBox.Show(msError.ErrorMessage + " EN Grupo"); return; }
            
            Permisos per = new Permisos();
            if (AddOrUpdate == "Update") {
                per.AddOrUpdate = "Update";
                per.is_active = this.is_active;
                per.is_staff = this.is_staff;
                per.is_superuser = this.is_superuser;
                per.groups = this.groups;
                per.ShowDialog();
                this.is_active = per.is_active;
                this.is_staff = per.is_staff;
                this.groups = per.groups;
                this.is_superuser = per.is_superuser;
                return;
            }
            per.ShowDialog();
            this.is_active = per.is_active;
            this.is_staff = per.is_staff;
            this.groups = per.groups;
            this.is_superuser = per.is_superuser;
            per.Close();
        }

        private void btnGempl_Click(object sender, EventArgs e)
        {
            if (AddOrUpdate == "Add")
            {
                UserBAL user = new UserBAL();
                user.username = txtUsername.Text;
                if (txtpasword1.Text == txtpasword2.Text)
                { user.password = txtpasword1.Text; }
                else { MessageBox.Show("No Coinciden las Cotraseñas"); }

                user.first_name = txtnombre.Text;
                user.last_name = txtapellido.Text;
                user.email = txtcorreo.Text;
                user.groups = this.groups;
                user.is_active = this.is_active;
                user.is_staff = this.is_staff;
                user.is_superuser = this.is_superuser;

                if (user.AddUser() == true)
                {
                    Limpiartextbox();
                    MessageBox.Show("Se guardado usuario");
                }
                else { MessageBox.Show(msError.ErrorMessage); }
                return;
            }
            if (AddOrUpdate == "Update")
            {
                UserBAL user = new UserBAL();
                user.id = this.id;
                user.username = txtUsername.Text;
                if (txtpasword1.Text == txtpasword2.Text)
                { user.password = txtpasword1.Text; }
                else { MessageBox.Show("No Coinciden las Cotraseñas"); }

                user.first_name = txtnombre.Text;
                user.last_name = txtapellido.Text;
                user.email = txtcorreo.Text;
                user.groups = this.groups;
                user.is_active = this.is_active;
                user.is_staff = this.is_staff;
                user.is_superuser = this.is_superuser;

                if (user.UpdateUser() == true)
                {
                    Limpiartextbox();
                   
                    MessageBox.Show("Cambios Guardado con Exito!!");
                    this.panelCon.Visible = false;
                }
                else { MessageBox.Show(msError.ErrorMessage); }
                return;
            }

        }



        private void btnCempl_Click(object sender, EventArgs e)
        {
            Limpiartextbox();
        }
        private void Limpiartextbox()
        {
            foreach (Control C in this.panelCon.Controls)
            {
                if (C is TextBox)
                {
                    C.Text = null;
                }
            }
        }

        private void btnRempl_Click(object sender, EventArgs e)
        {
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.DataSource = UserBAL.GetAllUsers();
            lblNumeroList.Text =  dataGridViewUsers.Rows.Count.ToString();
            this.panelListUser.Visible = true;
            this.panelCon.Visible = false;
        }

        private void btnNempl_Click(object sender, EventArgs e)
        {
            
            this.dataGridViewUsers.DataSource = null;

            this.panelListUser.Visible = false;
            this.panelCon.Visible = true;
            Limpiartextbox();
            this.btnUpdatePassword.Visible = false;
            AddOrUpdate = "Add";
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsers.Rows.Count > 0)
            {
               

                int nFila = e.RowIndex;
                if (nFila == -1) { MessageBox.Show("Seleciona una Fila de datos"); }
                else
                {
                    DataGridViewCell cellSelectedId = dataGridViewUsers.Rows[nFila].Cells["id"]; //seleciona el nombre de la fila
                    ShowProfileSelected(Int32.Parse(cellSelectedId.Value.ToString()));

                }
            }
            else { MessageBox.Show("No hay registros de entradas"); }
        }

        private void ShowProfileSelected(int Id) {
            UserBAL user = new UserBAL();
            user.id = Id;
            user.GetOneUser();
            if (user.id > 0)
            {
                UsuarioPerfil frmUsuario = new UsuarioPerfil();
                frmUsuario.Text = user.get_full_name;
                frmUsuario.username = user.username;
                frmUsuario.first_name = user.first_name;
                frmUsuario.last_name = user.last_name;
                frmUsuario.email = user.email;
                List<int> grupo = new List<int>();
                grupo = user.groups;
                frmUsuario.group = "";
                if (grupo.Count > 0)
                {
                    foreach (int number in grupo)
                    {
                        GrupoBAL grupobal = new GrupoBAL();
                        grupobal.id = number;
                        grupobal.GetOneGrupo();
                        frmUsuario.group = frmUsuario.group +" "+ grupobal.name;

                    }
                }
                //frmUsuario.groups = user.groups;
                frmUsuario.is_superuser = user.is_superuser;
                frmUsuario.is_staff = user.is_staff;
                frmUsuario.is_active = user.is_active;
                
                frmUsuario.date_joined = DateTime.Parse(user.date_joined);
                frmUsuario.ShowDialog();
                frmUsuario.Close();
            }

        }
        private void ShowUpdateSelected(int Id)
        {
           
            this.txtpasword1.Enabled = false;
            this.txtpasword2.Enabled = false;
            this.btnUpdatePassword.Visible = true;
            UserBAL user = new UserBAL();
            this.id = Id;
            user.id = this.id;
            user.GetOneUser();
            if (user.id > 0)
            {                
               
                txtUsername.Text = user.username;
                txtnombre.Text = user.first_name;
                txtapellido.Text = user.last_name;
                txtcorreo.Text = user.email;
                List<int> grupo = new List<int>();
                grupo = user.groups;
                this.groups = grupo;                
                this.is_superuser = user.is_superuser;
                this.is_staff = user.is_staff;
                this.is_active = user.is_active;
               
            }

        }

        private void btnMempl_Click(object sender, EventArgs e)
        {
            this.panelListUser.Visible = false;
            this.panelCon.Visible = true;
            AddOrUpdate = "Update";
            if (dataGridViewUsers.Rows.Count > 0)
            {


                int nFila = dataGridViewUsers.CurrentRow.Index;
                if (nFila == -1) { MessageBox.Show("Seleciona una Fila de datos"); }
                else
                {
                    DataGridViewCell cellSelectedId = dataGridViewUsers.Rows[nFila].Cells["id"]; //seleciona el nombre de la fila
                    ShowUpdateSelected(Int32.Parse(cellSelectedId.Value.ToString()));

                }
            }
            else { MessageBox.Show("Selecione el usuario A Modificar"); }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            UpdatePassword frmupdate = new UpdatePassword();
            frmupdate.id = this.id;
            frmupdate.ShowDialog();
            frmupdate.Close();
        }
    }
}
