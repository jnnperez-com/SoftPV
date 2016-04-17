namespace SoftPV
{
    partial class UpdatePassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtpasword2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpasword1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgpass = new System.Windows.Forms.PictureBox();
            this.btnCempl = new System.Windows.Forms.Button();
            this.btnGempl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpass)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 84;
            this.label4.Text = "Cnfirmar";
            // 
            // txtpasword2
            // 
            this.txtpasword2.Location = new System.Drawing.Point(109, 69);
            this.txtpasword2.MaxLength = 12;
            this.txtpasword2.Multiline = true;
            this.txtpasword2.Name = "txtpasword2";
            this.txtpasword2.Size = new System.Drawing.Size(275, 38);
            this.txtpasword2.TabIndex = 83;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 18);
            this.label13.TabIndex = 80;
            this.label13.Text = "Contraseña";
            // 
            // txtpasword1
            // 
            this.txtpasword1.Location = new System.Drawing.Point(109, 27);
            this.txtpasword1.MaxLength = 12;
            this.txtpasword1.Multiline = true;
            this.txtpasword1.Name = "txtpasword1";
            this.txtpasword1.Size = new System.Drawing.Size(275, 38);
            this.txtpasword1.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::SoftPV.Properties.Resources.imgtxtpass;
            this.pictureBox1.Location = new System.Drawing.Point(348, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // imgpass
            // 
            this.imgpass.BackColor = System.Drawing.Color.White;
            this.imgpass.Image = global::SoftPV.Properties.Resources.imgtxtpass;
            this.imgpass.Location = new System.Drawing.Point(348, 27);
            this.imgpass.Name = "imgpass";
            this.imgpass.Size = new System.Drawing.Size(36, 36);
            this.imgpass.TabIndex = 79;
            this.imgpass.TabStop = false;
            // 
            // btnCempl
            // 
            this.btnCempl.Image = global::SoftPV.Properties.Resources.cancelar2;
            this.btnCempl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCempl.Location = new System.Drawing.Point(390, 69);
            this.btnCempl.Name = "btnCempl";
            this.btnCempl.Size = new System.Drawing.Size(143, 40);
            this.btnCempl.TabIndex = 86;
            this.btnCempl.Text = "Cancelar";
            this.btnCempl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCempl.UseVisualStyleBackColor = true;
            this.btnCempl.Click += new System.EventHandler(this.btnCempl_Click);
            // 
            // btnGempl
            // 
            this.btnGempl.Image = global::SoftPV.Properties.Resources.guardar;
            this.btnGempl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGempl.Location = new System.Drawing.Point(390, 25);
            this.btnGempl.Name = "btnGempl";
            this.btnGempl.Size = new System.Drawing.Size(143, 40);
            this.btnGempl.TabIndex = 85;
            this.btnGempl.Text = "Guardar";
            this.btnGempl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGempl.UseVisualStyleBackColor = true;
            this.btnGempl.Click += new System.EventHandler(this.btnGempl_Click);
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 131);
            this.Controls.Add(this.btnCempl);
            this.Controls.Add(this.btnGempl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtpasword2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.imgpass);
            this.Controls.Add(this.txtpasword1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePassword";
            this.Load += new System.EventHandler(this.UpdatePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtpasword2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox imgpass;
        private System.Windows.Forms.TextBox txtpasword1;
        private System.Windows.Forms.Button btnCempl;
        private System.Windows.Forms.Button btnGempl;
    }
}