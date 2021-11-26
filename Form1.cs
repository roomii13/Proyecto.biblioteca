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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            
            librosform formulario = new librosform();
            formulario.Show();
            


        }

        private void btnsalir1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro desea salir?", "Cerrar", MessageBoxButtons.YesNo);
            this.Close();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            usuarioform formulario = new usuarioform();
            formulario.Show();
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            inventarioform formulario = new inventarioform();
            formulario.Show();

        }
    }
}
