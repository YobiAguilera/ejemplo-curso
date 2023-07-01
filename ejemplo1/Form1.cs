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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);  // esto sirve para agregar elementos.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboColor.Items.Add("Rojo");
            comboColor.Items.Add("Verde");
            comboColor.Items.Add("Negro");
            comboColor.Items.Add("Gris");
            comboColor.Items.Add("Rosado");
            comboColor.Items.Add("Turquesa");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            // operador ternario: es como un if en una sola linea. Funciona Así: 
            string chocolate = chbChocolate.Checked == true ? "Le gusta el chocolate." : "No le gusta el chocolate";
            string tipo;
            if (rbtWizard.Checked)
                tipo = "Wizard";
            else if (rbtMuggle.Checked)
                tipo = "Muggle";
            else
                tipo = "Squibs";

            string colorFavorito = comboColor.SelectedItem.ToString();
            string numeroFavorito = numNumeroFav.Value.ToString();

            string mensaje = chocolate + " Esta persona es " + tipo + ". Su color favorito es: " + colorFavorito + ". Su número favorito es el: " + numeroFavorito + ".";
            MessageBox.Show("Nombre: " + nombre + ". Fecha nacimiento: " + fecha + ". " + mensaje);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias por responder el cuestionario. Hasta pronto.");
        }
    }
}
