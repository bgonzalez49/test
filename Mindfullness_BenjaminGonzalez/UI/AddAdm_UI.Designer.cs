namespace Mindfullness.UI
{
    partial class AddAdm_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdm_UI));
            this.botonAdd = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradiente1 = new Mindfullness.Gradiente();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textCargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.botonLogin = new System.Windows.Forms.Button();
            this.gradiente1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAdd
            // 
            this.botonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.botonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.botonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAdd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonAdd.Location = new System.Drawing.Point(264, 427);
            this.botonAdd.Name = "botonAdd";
            this.botonAdd.Size = new System.Drawing.Size(183, 23);
            this.botonAdd.TabIndex = 13;
            this.botonAdd.Text = "Agregar administrador";
            this.botonAdd.UseVisualStyleBackColor = true;
            this.botonAdd.Click += new System.EventHandler(this.botonAdd_Click);
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPass.Location = new System.Drawing.Point(208, 313);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '●';
            this.textPass.Size = new System.Drawing.Size(192, 20);
            this.textPass.TabIndex = 11;
            this.textPass.UseSystemPasswordChar = true;
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textNombre.Location = new System.Drawing.Point(208, 268);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(192, 20);
            this.textNombre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingrese Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre administrador:";
            // 
            // gradiente1
            // 
            this.gradiente1.ColorBottom = System.Drawing.Color.MintCream;
            this.gradiente1.ColorTop = System.Drawing.Color.CornflowerBlue;
            this.gradiente1.Controls.Add(this.label4);
            this.gradiente1.Controls.Add(this.label3);
            this.gradiente1.Controls.Add(this.pictureClose);
            this.gradiente1.Controls.Add(this.pictureBox1);
            this.gradiente1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradiente1.Location = new System.Drawing.Point(0, 0);
            this.gradiente1.Name = "gradiente1";
            this.gradiente1.Size = new System.Drawing.Size(891, 233);
            this.gradiente1.TabIndex = 7;
            this.gradiente1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradiente1_Paint);
            this.gradiente1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(301, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(286, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(497, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "GESTION DE ADMINISTRADORES MINDFULLNESS";
            // 
            // pictureClose
            // 
            this.pictureClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureClose.BackgroundImage")));
            this.pictureClose.Location = new System.Drawing.Point(846, 0);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(42, 39);
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textEdad
            // 
            this.textEdad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textEdad.Location = new System.Drawing.Point(633, 356);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(192, 20);
            this.textEdad.TabIndex = 17;
            // 
            // textCargo
            // 
            this.textCargo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textCargo.Location = new System.Drawing.Point(208, 353);
            this.textCargo.Name = "textCargo";
            this.textCargo.Size = new System.Drawing.Size(192, 20);
            this.textCargo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Edad administrador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ingrese cargo:";
            // 
            // textCorreo
            // 
            this.textCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textCorreo.Location = new System.Drawing.Point(633, 313);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(192, 20);
            this.textCorreo.TabIndex = 21;
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textApellido.Location = new System.Drawing.Point(633, 269);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(192, 20);
            this.textApellido.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Correo electrónico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Apellido administrador:";
            // 
            // botonLogin
            // 
            this.botonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.botonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.botonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonLogin.Location = new System.Drawing.Point(542, 427);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(183, 23);
            this.botonLogin.TabIndex = 22;
            this.botonLogin.Text = "Inicio";
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // AddAdm_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(891, 501);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textCargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.botonAdd);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradiente1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAdm_UI";
            this.Text = "AddAdm";
            this.Load += new System.EventHandler(this.AddAdm_Load);
            this.gradiente1.ResumeLayout(false);
            this.gradiente1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAdd;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Gradiente gradiente1;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button botonLogin;
    }
}