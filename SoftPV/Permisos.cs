using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftPV.Entities;
using SoftPV.BAL;
using System.Collections;

namespace SoftPV
{
    public partial class Permisos : Form
    {
        public bool is_superuser { get; set; }
        public bool is_staff { get; set; }
        public bool is_active { get; set; }
        public List<int> groups { get; set; }
        DataTable ListaPermisos;
        bool Isload = false;
        bool IsNuevo = false;
        public Permisos()
        {
            InitializeComponent();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            Isload = true;
            cboxGrupos.DataSource = GrupoBAL.GetAllGrupos();
            cboxGrupos.ValueMember = "Id";
            cboxGrupos.DisplayMember = "name";


            CargarListbox();
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "name";
            listBox2.ValueMember = "id";
            listBox2.DisplayMember = "name";
            Desactivarpermisos();
            Isload = false;
            cboxGrupos.SelectedIndex = cboxGrupos.Items.Count - 1;

        }


        private void MoverTodosLosItems(ListBox source, ListBox destination)
        {
           
            foreach (PermisoEntity item in source.Items)
            {
                listBox2.ValueMember = "id";
                listBox2.DisplayMember = "name";
                destination.Items.Add(item);

            }            

            for (int i = 0; i < source.Items.Count;)
            {
                source.Items.Remove(source.Items[i]);
            }


        }

        private void Moverselecionados(ListBox source, ListBox destination)
        {
            if (source.Items.Count == 0) { return; }
            if (source.SelectedItem == null) { return; }

            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                listBox2.ValueMember = "id";
                listBox2.DisplayMember = "name";
                destination.Items.Add(item);

            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Moverselecionados(listBox1, listBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoverTodosLosItems(listBox1, listBox2);
        }

        private void CargarListbox()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            DataTable dt = PermisoBAL.GetAllPermisos();

            GrupoBAL grupo = new GrupoBAL();
            grupo.id = Int32.Parse(cboxGrupos.SelectedValue.ToString());
            grupo.GetOneGrupo();
            
            
            //int items2 = dt3.Rows.Count;
            ListaPermisos = PermisoBAL.GetAllPermisos();
            foreach (DataRow row in ListaPermisos.Rows)
            {
                PermisoEntity _permiso = new PermisoEntity();
                _permiso.id = Int32.Parse(row["id"].ToString());
                _permiso.name = row["name"].ToString();
              bool exis =    grupo.permissions.Any(x => x==_permiso.id);
                if (exis == true)
                {
                    listBox2.Items.Add(_permiso);
                }
                else { listBox1.Items.Add(_permiso); }
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Moverselecionados(listBox2, listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoverTodosLosItems(listBox2, listBox1);
        }

        private void btnMproducto_Click(object sender, EventArgs e)
        {
            txtPerfil.Text = cboxGrupos.Text;
            cboxGrupos.Enabled = false;
            Activarpermisos();
            IsNuevo = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CargarDatos();
            
            this.Close();
        }
        private void Desactivarpermisos()
        {
            this.txtPerfil.Enabled = false;
            this.GuardarproN.Enabled = false;
            this.cancelarproN.Enabled = false;           
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
        }
        private void Activarpermisos()
        {
            this.txtPerfil.Enabled = true;
            this.GuardarproN.Enabled = true;
            this.cancelarproN.Enabled = true;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
        }

        private void btnNproducto_Click(object sender, EventArgs e)
        {
            MoverTodosLosItems(listBox2, listBox1);
            Activarpermisos();
            IsNuevo = true;
        }

        private void GuardarproN_Click(object sender, EventArgs e)
        {
            if (IsNuevo == true)
            {
                AgregarGrupo();
            }
            else { EditarGrupo(); cboxGrupos.SelectedIndex = cboxGrupos.Items.Count - 1; }
            cboxGrupos.Enabled = true;
        }

        private void cancelarproN_Click(object sender, EventArgs e)
        {
            Desactivarpermisos();
            IsNuevo = false;
            cboxGrupos.Enabled = true;
        }

        private void groupMedica_Enter(object sender, EventArgs e)
        {

        }

        private void txtPerfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Isload)
            {
                CargarListbox();
            }
        }

        private void AgregarGrupo()
        {

            GrupoBAL grupo = new GrupoBAL();
            grupo.name = txtPerfil.Text;
            List<int> lista = new List<int>();
            foreach (PermisoEntity item in listBox2.Items)
            {
                lista.Add(item.id);
            }
            grupo.permissions = lista;
            if (grupo.AddGrupo() == true)
            {
                CargarListbox();
                txtPerfil.Text = "";
                MessageBox.Show("Se Agrego el nuevo Grupo");
                Isload = true;
                cboxGrupos.DataSource = GrupoBAL.GetAllGrupos();
                Isload = false;
                Desactivarpermisos();
            }
            else { MessageBox.Show(msError.ErrorMessage); }

            IsNuevo = false;

        }
        private void EditarGrupo()
        {

            GrupoBAL grupo = new GrupoBAL();
            grupo.id = Int32.Parse(cboxGrupos.SelectedValue.ToString());
            grupo.name = txtPerfil.Text;
            List<int> lista = new List<int>();
            foreach (PermisoEntity item in listBox2.Items)
            {
                lista.Add(item.id);
            }
            grupo.permissions = lista;
            if (grupo.UpdateGrupo() == true)
            {
                CargarListbox();
                txtPerfil.Text = "";
                MessageBox.Show("Se MOdifico corectamente");
                Isload = true;
                cboxGrupos.DataSource = GrupoBAL.GetAllGrupos();
                Isload = false;
                Desactivarpermisos();
            }
            else { MessageBox.Show(msError.ErrorMessage); }

            IsNuevo = false;

        }

        private void CargarDatos()
        {
            if (checkActivo.Checked == true)
            {
                this.is_active = true;
            }
            else { this.is_active = false; }
            if (checkAdmin.Checked == true)
            {
                this.is_staff = true;
            }
            else { this.is_staff = false; }
            if (checkSuperUser.Checked == true)
            {
                this.is_superuser = true;
            }
            else { this.is_superuser = false; }
            List<int> listagrupo = new List<int>();
            listagrupo.Add(Int32.Parse(cboxGrupos.SelectedValue.ToString()));
            this.groups = listagrupo;
        }
    }

    
}
