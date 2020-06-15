namespace Mindfullness
{
    partial class Login_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_UI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.botonLogin = new System.Windows.Forms.Button();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.gradiente1 = new Mindfullness.Gradiente();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradiente1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // textUsuario
            // 
            this.textUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textUsuario.Location = new System.Drawing.Point(238, 315);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(192, 20);
            this.textUsuario.TabIndex = 3;
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPass.Location = new System.Drawing.Point(238, 357);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '●';
            this.textPass.Size = new System.Drawing.Size(192, 20);
            this.textPass.TabIndex = 4;
            this.textPass.UseSystemPasswordChar = true;
            // 
            // botonLogin
            // 
            this.botonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.botonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.botonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonLogin.Location = new System.Drawing.Point(187, 419);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(183, 23);
            this.botonLogin.TabIndex = 5;
            this.botonLogin.Text = "Iniciar sesión";
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.button1_Click);
           
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botonRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.botonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.botonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonRegistrar.Location = new System.Drawing.Point(187, 457);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(183, 23);
            this.botonRegistrar.TabIndex = 6;
            this.botonRegistrar.Text = "Registrar administrador";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // gradiente1
            // 
            this.gradiente1.ColorBottom = System.Drawing.Color.MintCream;
            this.gradiente1.ColorTop = System.Drawing.Color.CornflowerBlue;
            this.gradiente1.Controls.Add(this.pictureClose);
            this.gradiente1.Controls.Add(this.pictureBox1);
            this.gradiente1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradiente1.Location = new System.Drawing.Point(0, 0);
            this.gradiente1.Name = "gradiente1";
            this.gradiente1.Size = new System.Drawing.Size(565, 272);
            this.gradiente1.TabIndex = 0;
            this.gradiente1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // pictureClose
            // 
            this.pictureClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureClose.BackgroundImage")));
            this.pictureClose.Location = new System.Drawing.Point(523, 0);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(42, 39);
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(139, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 203);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(565, 513);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradiente1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gradiente1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gradiente gradiente1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Button botonRegistrar;
    }
}

