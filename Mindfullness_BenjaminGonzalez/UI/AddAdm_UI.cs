using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mindfullness.UI
{
    public partial class AddAdm_UI : Form
    {
        public AddAdm_UI()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas seguro de cerrar el programa?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddAdm_Load(object sender, EventArgs e)
        {

        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_UI login = new Login_UI();
            login.Show();
        }

        private void botonAdd_Click(object sender, EventArgs e)
        {
            using (MindfullnessEntities mind = new MindfullnessEntities())
            {
                Administradores adm = new Administradores
                {
                    
                    nombre = textNombre.Text,
                    apellido = textApellido.Text,
                    contrasena = textPass.Text,
                    cargo = textCargo.Text,
                    correo = textCorreo.Text,
                    edad= Int32.Parse(textEdad.Text)
                    
                };

                string mensaje = "Estas seguro de agregar a: " + textNombre.Text + " " + textApellido.Text + " como admnistrador";
                var result = MessageBox.Show(mensaje, "Agregar administrador", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    mind.Administradores.Add(adm);
                    mind.SaveChanges();

                    MessageBox.Show("Se ha registrado con exito");
                }
               


            }
            textNombre.Clear();
            textApellido.Clear();
            textPass.Clear();
            textCorreo.Clear();
            textEdad.Clear();
            textCargo.Clear();
        }

        private void gradiente1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
