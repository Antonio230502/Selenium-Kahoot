namespace PracticaKahoot
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario1 = new System.Windows.Forms.TextBox();
            this.txtUsuario3 = new System.Windows.Forms.TextBox();
            this.txtUsuario2 = new System.Windows.Forms.TextBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblNombre3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoJuego = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumeroUsuarios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario1
            // 
            this.txtUsuario1.Location = new System.Drawing.Point(537, 85);
            this.txtUsuario1.MaxLength = 15;
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.Size = new System.Drawing.Size(144, 20);
            this.txtUsuario1.TabIndex = 3;
            this.txtUsuario1.TextChanged += new System.EventHandler(this.txtCodigoJuego_TextChanged);
            // 
            // txtUsuario3
            // 
            this.txtUsuario3.Enabled = false;
            this.txtUsuario3.Location = new System.Drawing.Point(537, 181);
            this.txtUsuario3.MaxLength = 15;
            this.txtUsuario3.Name = "txtUsuario3";
            this.txtUsuario3.Size = new System.Drawing.Size(144, 20);
            this.txtUsuario3.TabIndex = 5;
            this.txtUsuario3.TextChanged += new System.EventHandler(this.txtCodigoJuego_TextChanged);
            // 
            // txtUsuario2
            // 
            this.txtUsuario2.Enabled = false;
            this.txtUsuario2.Location = new System.Drawing.Point(537, 132);
            this.txtUsuario2.MaxLength = 15;
            this.txtUsuario2.Name = "txtUsuario2";
            this.txtUsuario2.Size = new System.Drawing.Size(144, 20);
            this.txtUsuario2.TabIndex = 4;
            this.txtUsuario2.TextChanged += new System.EventHandler(this.txtCodigoJuego_TextChanged);
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(425, 88);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(93, 13);
            this.lblNombre1.TabIndex = 4;
            this.lblNombre1.Text = "Nombre usuario 1:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Enabled = false;
            this.lblNombre2.Location = new System.Drawing.Point(425, 139);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(90, 13);
            this.lblNombre2.TabIndex = 5;
            this.lblNombre2.Text = "Nombre usuario 2";
            // 
            // lblNombre3
            // 
            this.lblNombre3.AutoSize = true;
            this.lblNombre3.Enabled = false;
            this.lblNombre3.Location = new System.Drawing.Point(425, 188);
            this.lblNombre3.Name = "lblNombre3";
            this.lblNombre3.Size = new System.Drawing.Size(90, 13);
            this.lblNombre3.TabIndex = 6;
            this.lblNombre3.Text = "Nombre usuario 3";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese el código del juego Kahoot (7 digitos):";
            // 
            // txtCodigoJuego
            // 
            this.txtCodigoJuego.Location = new System.Drawing.Point(207, 93);
            this.txtCodigoJuego.MaxLength = 7;
            this.txtCodigoJuego.Name = "txtCodigoJuego";
            this.txtCodigoJuego.Size = new System.Drawing.Size(145, 20);
            this.txtCodigoJuego.TabIndex = 1;
            this.txtCodigoJuego.TextChanged += new System.EventHandler(this.txtCodigoJuego_TextChanged);
            this.txtCodigoJuego.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoJuego_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "¿Cuántos usuarios va a ingresar?";
            // 
            // cbNumeroUsuarios
            // 
            this.cbNumeroUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroUsuarios.FormattingEnabled = true;
            this.cbNumeroUsuarios.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbNumeroUsuarios.Location = new System.Drawing.Point(207, 142);
            this.cbNumeroUsuarios.Name = "cbNumeroUsuarios";
            this.cbNumeroUsuarios.Size = new System.Drawing.Size(145, 21);
            this.cbNumeroUsuarios.TabIndex = 2;
            this.cbNumeroUsuarios.SelectedIndexChanged += new System.EventHandler(this.txtCodigoJuego_TextChanged);
            this.cbNumeroUsuarios.TextChanged += new System.EventHandler(this.cbNumeroUsuarios_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Práctica \"ataque\" a Kahoot ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(620, 26);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(312, 229);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(118, 28);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(732, 283);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNumeroUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoJuego);
            this.Controls.Add(this.lblNombre3);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.txtUsuario3);
            this.Controls.Add(this.txtUsuario2);
            this.Controls.Add(this.txtUsuario1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario1;
        private System.Windows.Forms.TextBox txtUsuario3;
        private System.Windows.Forms.TextBox txtUsuario2;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblNombre3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoJuego;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNumeroUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEnviar;
    }
}

