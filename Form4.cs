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
    public partial class inventarioform : Form
    {
        public inventarioform()
        {
            InitializeComponent();
        }

        private void btnsalir3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro desea salir?", "Cerrar", MessageBoxButtons.YesNo);
            this.Close();
        }

        private void invenrichtxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnregsitrados_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\biblioteca\libros.txt";

            StreamReader leer = new StreamReader(ruta);

            leer = File.OpenText(ruta);


            while (!leer.EndOfStream)
            {
                invenrichtxtbox.AppendText(leer.ReadLine() + "\n");
            }

            leer.Close();
        }

        private void btnusuarioreg_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\biblioteca\usuarios.txt";

            StreamReader leer = new StreamReader(ruta);

            leer = File.OpenText(ruta);


            while (!leer.EndOfStream)
            {
                invenrichtxtbox.AppendText(leer.ReadLine() + "\n");
            }

            leer.Close();
        }
    }
}
