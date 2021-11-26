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
    public partial class usuarioform : Form
    {
        public usuarioform()
        {
            InitializeComponent();
        }

        private void btnregistrar2_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\biblioteca\usuarios.txt";

            StreamWriter writ = File.AppendText(ruta);
            string nombre, direccion,telefono;
            nombre = Convert.ToString(nomyaptxtbox1.Text);
            writ.WriteLine("NOMBRE: " + nombre);
            direccion = Convert.ToString(diretxtbox.Text);
            writ.WriteLine("DIRECCION : " + direccion);
            telefono = Convert.ToString(telfonotxtbox.Text);
            writ.WriteLine("TELEFONO : " + telefono);
            writ.Close();
            MessageBox.Show("SE HA REGISTRADO EL USUARIO CORRECTAMENTE");


            nomyaptxtbox1.Text = "";
            diretxtbox.Text = "";
            telfonotxtbox.Text = "";

        }

        private void btnsalir2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro desea salir?", "Cerrar", MessageBoxButtons.YesNo);
            this.Close();


        }
    }
}
