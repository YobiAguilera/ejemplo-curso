using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {   // de esta forma mostramos la ventana de perfil persona desde el frmprincipal
            // Este foreach sirve para abrir el formulario solo una vez 
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe una ventana abierta");
                    return;
                }
                    //getType devuelve el tipo de objeto que es 
            }


            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();

            // ventana.ShowDialog(); sirve para que aparezca la ventana pero no te deja volver a la
            // anterior hasta que termines lo que tengas que hacer en la ventana. 
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe una ventana abierta");
                    return;
                }
                    
            }
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
