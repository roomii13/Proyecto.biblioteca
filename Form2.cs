using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Romina.Celis.prog
{
    public partial class librosform : Form
    {
        public librosform()
        {
            InitializeComponent();
        }

        private void librosform_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\biblioteca\libros.txt";

            StreamWriter writ = File.AppendText(ruta);
            string nombre, autor;
            autor = Convert.ToString(autortxtbox.Text);
            writ.WriteLine("AUTOR DEL LIBRO: " + autor);
            nombre = Convert.ToString(librotxtbox.Text);
            writ.WriteLine("LIBRO : " + nombre);
            writ.Close();
            MessageBox.Show("SE HA REGISTRADO EL LIBRO Y SU AUTOR CORRECTAMENTE");


            autortxtbox.Text = "";
            librotxtbox.Text = "";



        }

        private void btnsalir2_Click(object sender, EventArgs e)
        {
          MessageBox.Show("¿Seguro desea salir?", "Cerrar", MessageBoxButtons.YesNo);
          this.Close();


        }
    }
}
