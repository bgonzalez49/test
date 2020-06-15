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
    public partial class Gestion_UI : Form
    {
        public Gestion_UI()
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

        public void mostrarLista()
        {
            using (MindfullnessEntities mind = new MindfullnessEntities())
            {
                IQueryable<Administradores> adm = from d in mind.Administradores
                                                  select d;
                List<Administradores> lista = adm.ToList();
                tablaBD.DataSource = lista;


            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas seguro de cerrar el programa?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_UI login = new Login_UI();
            login.Show();
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            mostrarLista();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            string dato = textID.Text;
            int id_num = Int32.Parse(dato);

            string mensaje = "Estas seguro de eliminar este registro";
          
            
                using (MindfullnessEntities mind = new MindfullnessEntities())
                {
                    

                    try
                    {
                        Administradores query = (from d in mind.Administradores
                                                 where d.id == id_num
                                                 select d).First();
                    var result = MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {

                        mind.Administradores.Remove(query);
                        mind.SaveChanges();
                        MessageBox.Show("Registro eliminado exitosamente");
                        mostrarLista();
                        }
                    }
                    catch (InvalidOperationException Ex)
                    {
                        MessageBox.Show("Registro no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("Ha fallado" + Ex);
                }

                

            }
        }
        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonUpd_Click(object sender, EventArgs e)
        {
           Update_UI adm = new Update_UI();
           adm.Show();
        }

        private void tablaBD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
