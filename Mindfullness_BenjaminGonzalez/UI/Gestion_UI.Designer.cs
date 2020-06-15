namespace Mindfullness.UI
{
    partial class Gestion_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_UI));
            this.botonUpd = new System.Windows.Forms.Button();
            this.botonMostrar = new System.Windows.Forms.Button();
            this.gradiente1 = new Mindfullness.Gradiente();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonInicio = new System.Windows.Forms.Button();
            this.tablaBD = new System.Windows.Forms.DataGridView();
            this.textID = new System.Windows.Forms.TextBox();
            this.gradiente1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBD)).BeginInit();
            this.SuspendLayout();
            // 
            // botonUpd
            // 
            this.botonUpd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botonUpd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.botonUpd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.botonUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonUpd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonUpd.Location = new System.Drawing.Point(442, 388);
            this.botonUpd.Name = "botonUpd";
            this.botonUpd.Size = new System.Drawing.Size(119, 23);
            this.botonUpd.TabIndex = 52;
            this.botonUpd.Text = "Actualizar";
            this.botonUpd.UseVisualStyleBackColor = true;
            this.botonUpd.Click += new System.EventHandler(this.botonUpd_Click);
            // 
            // botonMostrar
            // 
            this.botonMostrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botonMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.botonMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.botonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMostrar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonMostrar.Location = new System.Drawing.Point(51, 388);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(119, 23);
            this.botonMostrar.TabIndex = 43;
            this.botonMostrar.Text = "Mostrar";
            this.botonMostrar.UseVisualStyleBackColor = true;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // gradiente1
            // 
            this.gradiente1.ColorBottom = System.Drawing.Color.MintCream;
            this.gradiente1.ColorTop = System.Drawing.Color.CornflowerBlue;
            this.gradiente1.Controls.Add(this.pictureClose);
            this.gradiente1.Controls.Add(this.label4);
            this.gradiente1.Controls.Add(this.label3);
            this.gradiente1.Controls.Add(this.pictureBox1);
            this.gradiente1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradiente1.Location = new System.Drawing.Point(0, 0);
            this.gradiente1.Name = "gradiente1";
            this.gradiente1.Size = new System.Drawing.Size(784, 67);
            this.gradiente1.TabIndex = 38;
            this.gradiente1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // pictureClose
            // 
            this.pictureClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureClose.BackgroundImage")));
            this.pictureClose.Location = new System.Drawing.Point(723, 6);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(42, 39);
            this.pictureClose.TabIndex = 3;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(231, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mantiene un registro de los administradores";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(231, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "GESTION ADMINISTRADORES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 47);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // botonEliminar
            // 
            this.botonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.botonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.botonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonEliminar.Location = new System.Drawing.Point(195, 388);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(119, 23);
            this.botonEliminar.TabIndex = 53;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonInicio
            // 
            this.botonInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botonInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.botonInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.botonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonInicio.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonInicio.Location = new System.Drawing.Point(582, 388);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(119, 23);
            this.botonInicio.TabIndex = 54;
            this.botonInicio.Text = "Inicio";
            this.botonInicio.UseVisualStyleBackColor = true;
            this.botonInicio.Click += new System.EventHandler(this.button4_Click);
            // 
            // tablaBD
            // 
            this.tablaBD.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tablaBD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaBD.Location = new System.Drawing.Point(147, 88);
            this.tablaBD.Name = "tablaBD";
            this.tablaBD.Size = new System.Drawing.Size(522, 241);
            this.tablaBD.TabIndex = 55;
            this.tablaBD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaBD_CellContentClick);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(335, 388);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(35, 23);
            this.textID.TabIndex = 56;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // Gestion_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.tablaBD);
            this.Controls.Add(this.botonInicio);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonUpd);
            this.Controls.Add(this.botonMostrar);
            this.Controls.Add(this.gradiente1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_UI";
            this.Text = "Gestion_UIcs";
            this.gradiente1.ResumeLayout(false);
            this.gradiente1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonUpd;
        private System.Windows.Forms.Button botonMostrar;
        private Gradiente gradiente1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonInicio;
        private System.Windows.Forms.DataGridView tablaBD;
        private System.Windows.Forms.TextBox textID;
    }
}