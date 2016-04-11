namespace SoftPV
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsUsername = new System.Windows.Forms.ToolStripLabel();
            this.picayuda = new System.Windows.Forms.PictureBox();
            this.menu6 = new System.Windows.Forms.Button();
            this.menu5 = new System.Windows.Forms.Button();
            this.menu4 = new System.Windows.Forms.Button();
            this.menu3 = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.picmensob = new System.Windows.Forms.PictureBox();
            this.picmasb = new System.Windows.Forms.PictureBox();
            this.picxbut = new System.Windows.Forms.PictureBox();
            this.btnVenta = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tsFullname = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picayuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmensob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmasb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxbut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(108, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Tiempo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUsername,
            this.tsFullname});
            this.toolStrip1.Location = new System.Drawing.Point(13, 558);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(173, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsUsername
            // 
            this.tsUsername.Name = "tsUsername";
            this.tsUsername.Size = new System.Drawing.Size(110, 22);
            this.tsUsername.Text = "Usuario del Sistema";
            // 
            // picayuda
            // 
            this.picayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picayuda.BackgroundImage = global::SoftPV.Properties.Resources.ayudan;
            this.picayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picayuda.Location = new System.Drawing.Point(984, 2);
            this.picayuda.Name = "picayuda";
            this.picayuda.Size = new System.Drawing.Size(26, 26);
            this.picayuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picayuda.TabIndex = 18;
            this.picayuda.TabStop = false;
            this.picayuda.Click += new System.EventHandler(this.picayuda_Click);
            this.picayuda.MouseLeave += new System.EventHandler(this.picayuda_MouseLeave);
            this.picayuda.MouseHover += new System.EventHandler(this.picayuda_MouseHover);
            // 
            // menu6
            // 
            this.menu6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menu6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu6.Image = global::SoftPV.Properties.Resources.config;
            this.menu6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu6.Location = new System.Drawing.Point(925, 62);
            this.menu6.Name = "menu6";
            this.menu6.Size = new System.Drawing.Size(178, 60);
            this.menu6.TabIndex = 17;
            this.menu6.Text = "Herramientas";
            this.menu6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu6.UseVisualStyleBackColor = true;
            // 
            // menu5
            // 
            this.menu5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menu5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu5.Image = global::SoftPV.Properties.Resources.f5invetario1;
            this.menu5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu5.Location = new System.Drawing.Point(741, 62);
            this.menu5.Name = "menu5";
            this.menu5.Size = new System.Drawing.Size(178, 60);
            this.menu5.TabIndex = 16;
            this.menu5.Text = "Inventario";
            this.menu5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu5.UseVisualStyleBackColor = true;
            // 
            // menu4
            // 
            this.menu4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menu4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu4.Image = global::SoftPV.Properties.Resources.f4corte1;
            this.menu4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu4.Location = new System.Drawing.Point(557, 62);
            this.menu4.Name = "menu4";
            this.menu4.Size = new System.Drawing.Size(178, 60);
            this.menu4.TabIndex = 14;
            this.menu4.Text = "Corte";
            this.menu4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu4.UseVisualStyleBackColor = true;
            // 
            // menu3
            // 
            this.menu3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menu3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu3.Image = global::SoftPV.Properties.Resources.f3pedidos1;
            this.menu3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu3.Location = new System.Drawing.Point(373, 62);
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(178, 60);
            this.menu3.TabIndex = 13;
            this.menu3.Text = "Pedidos";
            this.menu3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu3.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = global::SoftPV.Properties.Resources.f2producto1;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(189, 62);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(178, 60);
            this.btnProductos.TabIndex = 12;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // picmensob
            // 
            this.picmensob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picmensob.BackgroundImage = global::SoftPV.Properties.Resources.meb;
            this.picmensob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picmensob.Location = new System.Drawing.Point(1016, 2);
            this.picmensob.Name = "picmensob";
            this.picmensob.Size = new System.Drawing.Size(26, 26);
            this.picmensob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmensob.TabIndex = 11;
            this.picmensob.TabStop = false;
            this.picmensob.Click += new System.EventHandler(this.picmensob_Click);
            this.picmensob.MouseLeave += new System.EventHandler(this.picmensob_MouseLeave);
            this.picmensob.MouseHover += new System.EventHandler(this.picmensob_MouseHover);
            // 
            // picmasb
            // 
            this.picmasb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picmasb.BackgroundImage = global::SoftPV.Properties.Resources.mb;
            this.picmasb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picmasb.Location = new System.Drawing.Point(1048, 2);
            this.picmasb.Name = "picmasb";
            this.picmasb.Size = new System.Drawing.Size(26, 26);
            this.picmasb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmasb.TabIndex = 10;
            this.picmasb.TabStop = false;
            this.picmasb.Click += new System.EventHandler(this.picmasb_Click);
            this.picmasb.MouseLeave += new System.EventHandler(this.picmasb_MouseLeave);
            this.picmasb.MouseHover += new System.EventHandler(this.picmasb_MouseHover);
            // 
            // picxbut
            // 
            this.picxbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picxbut.BackgroundImage = global::SoftPV.Properties.Resources.xb;
            this.picxbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picxbut.Location = new System.Drawing.Point(1080, 2);
            this.picxbut.Name = "picxbut";
            this.picxbut.Size = new System.Drawing.Size(26, 26);
            this.picxbut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picxbut.TabIndex = 9;
            this.picxbut.TabStop = false;
            this.picxbut.Click += new System.EventHandler(this.picxbut_Click);
            this.picxbut.MouseLeave += new System.EventHandler(this.picxbut_MouseLeave);
            this.picxbut.MouseHover += new System.EventHandler(this.picxbut_MouseHover);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnVenta.Image")));
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.Location = new System.Drawing.Point(5, 62);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(178, 60);
            this.btnVenta.TabIndex = 6;
            this.btnVenta.Text = "Venta";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SoftPV.Properties.Resources.logopv;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.Location = new System.Drawing.Point(5, 128);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1098, 413);
            this.panelContenedor.TabIndex = 19;
            // 
            // tsFullname
            // 
            this.tsFullname.Name = "tsFullname";
            this.tsFullname.Size = new System.Drawing.Size(51, 22);
            this.tsFullname.Text = "Nombre";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 595);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.picayuda);
            this.Controls.Add(this.menu6);
            this.Controls.Add(this.menu5);
            this.Controls.Add(this.menu4);
            this.Controls.Add(this.menu3);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.picmensob);
            this.Controls.Add(this.picmasb);
            this.Controls.Add(this.picxbut);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picayuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmensob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmasb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxbut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsUsername;
        private System.Windows.Forms.PictureBox picxbut;
        private System.Windows.Forms.PictureBox picmasb;
        private System.Windows.Forms.PictureBox picmensob;
        private System.Windows.Forms.Button menu6;
        private System.Windows.Forms.Button menu5;
        private System.Windows.Forms.Button menu4;
        private System.Windows.Forms.Button menu3;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox picayuda;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStripLabel tsFullname;
    }
}