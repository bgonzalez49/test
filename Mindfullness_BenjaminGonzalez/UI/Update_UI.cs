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
    public partial class Update_UI : Form
    {
        public Update_UI()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gradiente1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas seguro de cerrar esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            string nombre_upd = textNombre.Text;
            string apellido_upd = textApellido.Text;
            string pass_upd = textPass.Text;
            string cargo_upd = textCargo.Text;
            string correo_upd = textCorreo.Text;
            int edad_upd = Int32.Parse(textEdad.Text);

            string mensaje = "Estas seguro de actualizar los datos de: " + textNombre.Text + " " + textApellido.Text;
            var result = MessageBox.Show(mensaje, "Actualizar datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                using (MindfullnessEntities mind = new MindfullnessEntities())
                {
                    var query = (from d in mind.Administradores
                                 where d.nombre == nombre_upd
                                 select d).First();

                    query.nombre = nombre_upd;
                    query.apellido = apellido_upd;
                    query.contrasena = pass_upd;
                    query.cargo = cargo_upd;
                    query.edad = edad_upd;
                    query.correo = correo_upd;

                    mind.SaveChanges();

                }

                MessageBox.Show("Datos actualizados correctamente");
            }

                textNombre.Clear();
                textApellido.Clear();
                textPass.Clear();
                textCargo.Clear();
                textCorreo.Clear();
                textEdad.Clear();

                

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int id = Int32.Parse(textBox1.Text);            

                using (MindfullnessEntities mind = new MindfullnessEntities())
                {
                    
                    try
                        {
                            var query = (from d in mind.Administradores
                                 where d.id == id
                                 select d).First();

                            textNombre.Text = query.nombre;
                            textApellido.Text = query.apellido;
                            textPass.Text = query.contrasena;
                            textCorreo.Text = query.correo;
                            textEdad.Text = query.edad.ToString();
                            textCargo.Text = query.cargo;
                        }
                    catch (Exception Ex)
                        {   
                    
                             MessageBox.Show("Registro no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                            Console.WriteLine("Ha fallado" + Ex);
                                 
                        }


                }


        }
    }
}
