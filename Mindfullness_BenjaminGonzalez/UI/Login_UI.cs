using Mindfullness.UI;
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

namespace Mindfullness
{
    public partial class Login_UI : Form
    {
        public Login_UI()
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show("¿Estas seguro de cerrar el programa?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MindfullnessEntities mind= new MindfullnessEntities())
            {
                var admins = from d in mind.Administradores
                             where d.nombre == textUsuario.Text &&
                             d.contrasena == textPass.Text
                             select d;
                if (admins.Count() > 0)
                {
                    this.Hide();
                    Gestion_UI gestion = new Gestion_UI();
                    gestion.Show();
                    
                }

                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAdm_UI adm = new AddAdm_UI();
            adm.Show();
        }

       

        
    }
}
