namespace SoftPV
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNproducto = new System.Windows.Forms.Button();
            this.btnEproducto = new System.Windows.Forms.Button();
            this.btnRproductos = new System.Windows.Forms.Button();
            this.btnMproducto = new System.Windows.Forms.Button();
            this.panelPro = new System.Windows.Forms.Panel();
            this.panelNProducto = new System.Windows.Forms.Panel();
            this.txtPresentacionArt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImgen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.Label();
            this.cboxProveedor = new System.Windows.Forms.ComboBox();
            this.radiom = new System.Windows.Forms.RadioButton();
            this.radiokg = new System.Windows.Forms.RadioButton();
            this.radiocu = new System.Windows.Forms.RadioButton();
            this.txtDescripcionArt = new System.Windows.Forms.RichTextBox();
            this.cancelarproN = new System.Windows.Forms.Button();
            this.txtCodigoArt = new System.Windows.Forms.TextBox();
            this.GuardarproN = new System.Windows.Forms.Button();
            this.btnNPpro = new System.Windows.Forms.Button();
            this.txtPrecioPub = new System.Windows.Forms.TextBox();
            this.txtPrecioProv = new System.Windows.Forms.TextBox();
            this.lbprovedoor = new System.Windows.Forms.Label();
            this.txtExistenciaMin = new System.Windows.Forms.TextBox();
            this.lbprocod = new System.Windows.Forms.Label();
            this.lbdescripcion = new System.Windows.Forms.Label();
            this.txtNombreArt = new System.Windows.Forms.TextBox();
            this.lbcontenido = new System.Windows.Forms.Label();
            this.lbexistencia = new System.Windows.Forms.Label();
            this.lbprecioprovee = new System.Windows.Forms.Label();
            this.lbpreciopublic = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupMedica = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panelPro.SuspendLayout();
            this.panelNProducto.SuspendLayout();
            this.groupMedica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNproducto
            // 
            this.btnNproducto.Image = global::SoftPV.Properties.Resources.nuevo;
            this.btnNproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNproducto.Location = new System.Drawing.Point(3, 14);
            this.btnNproducto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNproducto.Name = "btnNproducto";
            this.btnNproducto.Size = new System.Drawing.Size(143, 40);
            this.btnNproducto.TabIndex = 0;
            this.btnNproducto.Text = "Nuevo";
            this.btnNproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNproducto.UseVisualStyleBackColor = true;
            this.btnNproducto.Click += new System.EventHandler(this.btnNproducto_Click);
            // 
            // btnEproducto
            // 
            this.btnEproducto.Image = global::SoftPV.Properties.Resources.eliminar;
            this.btnEproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEproducto.Location = new System.Drawing.Point(3, 114);
            this.btnEproducto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEproducto.Name = "btnEproducto";
            this.btnEproducto.Size = new System.Drawing.Size(143, 40);
            this.btnEproducto.TabIndex = 2;
            this.btnEproducto.Text = "Eliminar";
            this.btnEproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEproducto.UseVisualStyleBackColor = true;
            // 
            // btnRproductos
            // 
            this.btnRproductos.Image = global::SoftPV.Properties.Resources.reporte;
            this.btnRproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRproductos.Location = new System.Drawing.Point(3, 164);
            this.btnRproductos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRproductos.Name = "btnRproductos";
            this.btnRproductos.Size = new System.Drawing.Size(143, 40);
            this.btnRproductos.TabIndex = 3;
            this.btnRproductos.Text = "Reporte";
            this.btnRproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRproductos.UseVisualStyleBackColor = true;
            // 
            // btnMproducto
            // 
            this.btnMproducto.Image = global::SoftPV.Properties.Resources.modificar;
            this.btnMproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMproducto.Location = new System.Drawing.Point(3, 64);
            this.btnMproducto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMproducto.Name = "btnMproducto";
            this.btnMproducto.Size = new System.Drawing.Size(143, 40);
            this.btnMproducto.TabIndex = 1;
            this.btnMproducto.Text = "Modificar";
            this.btnMproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMproducto.UseVisualStyleBackColor = true;
            // 
            // panelPro
            // 
            this.panelPro.Controls.Add(this.panelNProducto);
            this.panelPro.Location = new System.Drawing.Point(155, 14);
            this.panelPro.Name = "panelPro";
            this.panelPro.Size = new System.Drawing.Size(1103, 666);
            this.panelPro.TabIndex = 4;
            // 
            // panelNProducto
            // 
            this.panelNProducto.Controls.Add(this.groupMedica);
            this.panelNProducto.Controls.Add(this.txtPresentacionArt);
            this.panelNProducto.Controls.Add(this.label1);
            this.panelNProducto.Controls.Add(this.lblImgen);
            this.panelNProducto.Controls.Add(this.button1);
            this.panelNProducto.Controls.Add(this.r);
            this.panelNProducto.Controls.Add(this.cboxProveedor);
            this.panelNProducto.Controls.Add(this.txtDescripcionArt);
            this.panelNProducto.Controls.Add(this.cancelarproN);
            this.panelNProducto.Controls.Add(this.txtCodigoArt);
            this.panelNProducto.Controls.Add(this.GuardarproN);
            this.panelNProducto.Controls.Add(this.btnNPpro);
            this.panelNProducto.Controls.Add(this.txtPrecioPub);
            this.panelNProducto.Controls.Add(this.txtPrecioProv);
            this.panelNProducto.Controls.Add(this.lbprovedoor);
            this.panelNProducto.Controls.Add(this.txtExistenciaMin);
            this.panelNProducto.Controls.Add(this.lbprocod);
            this.panelNProducto.Controls.Add(this.lbdescripcion);
            this.panelNProducto.Controls.Add(this.txtNombreArt);
            this.panelNProducto.Controls.Add(this.lbcontenido);
            this.panelNProducto.Controls.Add(this.lbexistencia);
            this.panelNProducto.Controls.Add(this.lbprecioprovee);
            this.panelNProducto.Controls.Add(this.lbpreciopublic);
            this.panelNProducto.Location = new System.Drawing.Point(0, 0);
            this.panelNProducto.Name = "panelNProducto";
            this.panelNProducto.Size = new System.Drawing.Size(1098, 594);
            this.panelNProducto.TabIndex = 22;
            this.panelNProducto.Visible = false;
            // 
            // txtPresentacionArt
            // 
            this.txtPresentacionArt.Location = new System.Drawing.Point(524, 2);
            this.txtPresentacionArt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPresentacionArt.Multiline = true;
            this.txtPresentacionArt.Name = "txtPresentacionArt";
            this.txtPresentacionArt.Size = new System.Drawing.Size(233, 38);
            this.txtPresentacionArt.TabIndex = 33;
            this.txtPresentacionArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Presentación:";
            // 
            // lblImgen
            // 
            this.lblImgen.AutoSize = true;
            this.lblImgen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgen.Location = new System.Drawing.Point(152, 207);
            this.lblImgen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImgen.Name = "lblImgen";
            this.lblImgen.Size = new System.Drawing.Size(49, 12);
            this.lblImgen.TabIndex = 32;
            this.lblImgen.Text = "Imagen:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Location = new System.Drawing.Point(69, 179);
            this.r.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(75, 20);
            this.r.TabIndex = 30;
            this.r.Text = "Imagen:";
            // 
            // cboxProveedor
            // 
            this.cboxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxProveedor.FormattingEnabled = true;
            this.cboxProveedor.Location = new System.Drawing.Point(154, 57);
            this.cboxProveedor.Name = "cboxProveedor";
            this.cboxProveedor.Size = new System.Drawing.Size(233, 28);
            this.cboxProveedor.TabIndex = 29;
            // 
            // radiom
            // 
            this.radiom.AutoSize = true;
            this.radiom.Location = new System.Drawing.Point(91, 95);
            this.radiom.Name = "radiom";
            this.radiom.Size = new System.Drawing.Size(42, 24);
            this.radiom.TabIndex = 28;
            this.radiom.Text = "m";
            this.radiom.UseVisualStyleBackColor = true;
            // 
            // radiokg
            // 
            this.radiokg.AutoSize = true;
            this.radiokg.Location = new System.Drawing.Point(91, 65);
            this.radiokg.Name = "radiokg";
            this.radiokg.Size = new System.Drawing.Size(48, 24);
            this.radiokg.TabIndex = 27;
            this.radiokg.Text = "kg";
            this.radiokg.UseVisualStyleBackColor = true;
            // 
            // radiocu
            // 
            this.radiocu.AutoSize = true;
            this.radiocu.Checked = true;
            this.radiocu.Location = new System.Drawing.Point(91, 35);
            this.radiocu.Name = "radiocu";
            this.radiocu.Size = new System.Drawing.Size(52, 24);
            this.radiocu.TabIndex = 26;
            this.radiocu.TabStop = true;
            this.radiocu.Text = "c/u";
            this.radiocu.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionArt
            // 
            this.txtDescripcionArt.Location = new System.Drawing.Point(154, 241);
            this.txtDescripcionArt.MaxLength = 255;
            this.txtDescripcionArt.Name = "txtDescripcionArt";
            this.txtDescripcionArt.Size = new System.Drawing.Size(233, 127);
            this.txtDescripcionArt.TabIndex = 4;
            this.txtDescripcionArt.Text = "";
            // 
            // cancelarproN
            // 
            this.cancelarproN.Image = global::SoftPV.Properties.Resources.cancelar2;
            this.cancelarproN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarproN.Location = new System.Drawing.Point(769, 184);
            this.cancelarproN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cancelarproN.Name = "cancelarproN";
            this.cancelarproN.Size = new System.Drawing.Size(143, 40);
            this.cancelarproN.TabIndex = 20;
            this.cancelarproN.Text = "Cancelar";
            this.cancelarproN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarproN.UseVisualStyleBackColor = true;
            // 
            // txtCodigoArt
            // 
            this.txtCodigoArt.Location = new System.Drawing.Point(154, 2);
            this.txtCodigoArt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCodigoArt.MaxLength = 20;
            this.txtCodigoArt.Multiline = true;
            this.txtCodigoArt.Name = "txtCodigoArt";
            this.txtCodigoArt.Size = new System.Drawing.Size(233, 38);
            this.txtCodigoArt.TabIndex = 1;
            // 
            // GuardarproN
            // 
            this.GuardarproN.Image = global::SoftPV.Properties.Resources.guardar;
            this.GuardarproN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarproN.Location = new System.Drawing.Point(769, 134);
            this.GuardarproN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.GuardarproN.Name = "GuardarproN";
            this.GuardarproN.Size = new System.Drawing.Size(143, 40);
            this.GuardarproN.TabIndex = 8;
            this.GuardarproN.Text = "Guardar";
            this.GuardarproN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarproN.UseVisualStyleBackColor = true;
            this.GuardarproN.Click += new System.EventHandler(this.GuardarproN_Click);
            // 
            // btnNPpro
            // 
            this.btnNPpro.Location = new System.Drawing.Point(35, 33);
            this.btnNPpro.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNPpro.Name = "btnNPpro";
            this.btnNPpro.Size = new System.Drawing.Size(0, 0);
            this.btnNPpro.TabIndex = 0;
            this.btnNPpro.Text = "Nuevo";
            this.btnNPpro.UseVisualStyleBackColor = true;
            // 
            // txtPrecioPub
            // 
            this.txtPrecioPub.Location = new System.Drawing.Point(524, 90);
            this.txtPrecioPub.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPrecioPub.Multiline = true;
            this.txtPrecioPub.Name = "txtPrecioPub";
            this.txtPrecioPub.Size = new System.Drawing.Size(233, 38);
            this.txtPrecioPub.TabIndex = 6;
            this.txtPrecioPub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecioProv
            // 
            this.txtPrecioProv.Location = new System.Drawing.Point(524, 44);
            this.txtPrecioProv.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPrecioProv.Multiline = true;
            this.txtPrecioProv.Name = "txtPrecioProv";
            this.txtPrecioProv.Size = new System.Drawing.Size(233, 38);
            this.txtPrecioProv.TabIndex = 5;
            this.txtPrecioProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbprovedoor
            // 
            this.lbprovedoor.AutoSize = true;
            this.lbprovedoor.Location = new System.Drawing.Point(54, 62);
            this.lbprovedoor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbprovedoor.Name = "lbprovedoor";
            this.lbprovedoor.Size = new System.Drawing.Size(99, 20);
            this.lbprovedoor.TabIndex = 5;
            this.lbprovedoor.Text = "Proveedor:";
            // 
            // txtExistenciaMin
            // 
            this.txtExistenciaMin.Location = new System.Drawing.Point(524, 138);
            this.txtExistenciaMin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtExistenciaMin.MaxLength = 40;
            this.txtExistenciaMin.Multiline = true;
            this.txtExistenciaMin.Name = "txtExistenciaMin";
            this.txtExistenciaMin.Size = new System.Drawing.Size(233, 38);
            this.txtExistenciaMin.TabIndex = 7;
            this.txtExistenciaMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbprocod
            // 
            this.lbprocod.AutoSize = true;
            this.lbprocod.Location = new System.Drawing.Point(0, 13);
            this.lbprocod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbprocod.Name = "lbprocod";
            this.lbprocod.Size = new System.Drawing.Size(153, 20);
            this.lbprocod.TabIndex = 6;
            this.lbprocod.Text = "Código Producto:";
            // 
            // lbdescripcion
            // 
            this.lbdescripcion.AutoSize = true;
            this.lbdescripcion.Location = new System.Drawing.Point(39, 244);
            this.lbdescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbdescripcion.Name = "lbdescripcion";
            this.lbdescripcion.Size = new System.Drawing.Size(114, 20);
            this.lbdescripcion.TabIndex = 7;
            this.lbdescripcion.Text = "Descripción:";
            // 
            // txtNombreArt
            // 
            this.txtNombreArt.Location = new System.Drawing.Point(154, 107);
            this.txtNombreArt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNombreArt.MaxLength = 200;
            this.txtNombreArt.Multiline = true;
            this.txtNombreArt.Name = "txtNombreArt";
            this.txtNombreArt.Size = new System.Drawing.Size(233, 38);
            this.txtNombreArt.TabIndex = 3;
            // 
            // lbcontenido
            // 
            this.lbcontenido.AutoSize = true;
            this.lbcontenido.Location = new System.Drawing.Point(69, 114);
            this.lbcontenido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbcontenido.Name = "lbcontenido";
            this.lbcontenido.Size = new System.Drawing.Size(84, 20);
            this.lbcontenido.TabIndex = 8;
            this.lbcontenido.Text = "Nombre: ";
            // 
            // lbexistencia
            // 
            this.lbexistencia.AutoSize = true;
            this.lbexistencia.Location = new System.Drawing.Point(350, 150);
            this.lbexistencia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbexistencia.Name = "lbexistencia";
            this.lbexistencia.Size = new System.Drawing.Size(162, 20);
            this.lbexistencia.TabIndex = 9;
            this.lbexistencia.Text = "Existencia Minima:";
            // 
            // lbprecioprovee
            // 
            this.lbprecioprovee.AutoSize = true;
            this.lbprecioprovee.Location = new System.Drawing.Point(404, 47);
            this.lbprecioprovee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbprecioprovee.Name = "lbprecioprovee";
            this.lbprecioprovee.Size = new System.Drawing.Size(108, 20);
            this.lbprecioprovee.TabIndex = 10;
            this.lbprecioprovee.Text = "Precio Prov:";
            // 
            // lbpreciopublic
            // 
            this.lbpreciopublic.AutoSize = true;
            this.lbpreciopublic.Location = new System.Drawing.Point(399, 104);
            this.lbpreciopublic.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbpreciopublic.Name = "lbpreciopublic";
            this.lbpreciopublic.Size = new System.Drawing.Size(113, 20);
            this.lbpreciopublic.TabIndex = 11;
            this.lbpreciopublic.Text = "Precio Publi:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupMedica
            // 
            this.groupMedica.Controls.Add(this.radioButton1);
            this.groupMedica.Controls.Add(this.radiocu);
            this.groupMedica.Controls.Add(this.radiokg);
            this.groupMedica.Controls.Add(this.radiom);
            this.groupMedica.Location = new System.Drawing.Point(524, 184);
            this.groupMedica.Name = "groupMedica";
            this.groupMedica.Size = new System.Drawing.Size(233, 158);
            this.groupMedica.TabIndex = 35;
            this.groupMedica.TabStop = false;
            this.groupMedica.Text = "Medida";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(91, 125);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 24);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.Text = "L";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 714);
            this.Controls.Add(this.panelPro);
            this.Controls.Add(this.btnRproductos);
            this.Controls.Add(this.btnEproducto);
            this.Controls.Add(this.btnMproducto);
            this.Controls.Add(this.btnNproducto);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Producto";
            this.Text = "nProducto";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.panelPro.ResumeLayout(false);
            this.panelNProducto.ResumeLayout(false);
            this.panelNProducto.PerformLayout();
            this.groupMedica.ResumeLayout(false);
            this.groupMedica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNproducto;
        private System.Windows.Forms.Button btnMproducto;
        private System.Windows.Forms.Button btnEproducto;
        private System.Windows.Forms.Button btnRproductos;
        private System.Windows.Forms.Panel panelPro;
        private System.Windows.Forms.Panel panelNProducto;
        private System.Windows.Forms.RadioButton radiom;
        private System.Windows.Forms.RadioButton radiokg;
        private System.Windows.Forms.RadioButton radiocu;
        private System.Windows.Forms.RichTextBox txtDescripcionArt;
        private System.Windows.Forms.Button cancelarproN;
        private System.Windows.Forms.TextBox txtCodigoArt;
        private System.Windows.Forms.Button GuardarproN;
        private System.Windows.Forms.Button btnNPpro;
        private System.Windows.Forms.TextBox txtPrecioPub;
        private System.Windows.Forms.TextBox txtPrecioProv;
        private System.Windows.Forms.Label lbprovedoor;
        private System.Windows.Forms.TextBox txtExistenciaMin;
        private System.Windows.Forms.Label lbprocod;
        private System.Windows.Forms.Label lbdescripcion;
        private System.Windows.Forms.TextBox txtNombreArt;
        private System.Windows.Forms.Label lbcontenido;
        private System.Windows.Forms.Label lbexistencia;
        private System.Windows.Forms.Label lbprecioprovee;
        private System.Windows.Forms.Label lbpreciopublic;
        private System.Windows.Forms.ComboBox cboxProveedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblImgen;
        private System.Windows.Forms.TextBox txtPresentacionArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupMedica;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}