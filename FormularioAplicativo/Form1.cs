using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioAplicativo
{
    public partial class Form1 : Form
    {
        public ListaPersona listaPersona = new ListaPersona();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblapellido_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = mtxtNombre.Text;
            persona.Apellido = mtxtApellido.Text;
            persona.Cedula = Convert.ToInt32(mtxtCedula.Text);
            persona.Edad = Convert.ToInt32(mtxtEdad.Text);
            persona.Genero = Genero();
            listaPersona.AnadirPersona(persona);
            dgvPersona.DataSource = listaPersona.Personas;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public string Genero()
        {
            string gen;
            if(rbmasculina.Checked)
            {
                gen = "Masculino";
            }
            else
            {
                if (rbfemenino.Checked)
                {
                    gen = "Femenino";
                }
                else
                {
                    gen = " Genero no ingresado";
                }
            }
            return gen;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
