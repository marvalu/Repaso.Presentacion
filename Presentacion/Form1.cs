using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repaso.Entidades;
using Repaso.LogicaNegocios;


namespace Presentacion
{

 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Operaciones logica1 = new Operaciones();
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Persona persona = new Persona(int.Parse(IDText.Text), NombreText.Text, ApellidoText.Text, CedText.Text);

             
                
                logica1.CrearPersonas(persona);
              //  return persona;

            }
            catch (Exception)
            {

                MessageBox.Show("Algun tipo de dato no coincide FAVOR DE VALIDA CORRECTAMENTE");
               // return null;
            }
        
           
           
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    NombreText.Text = "";
        //    ApellidoText.Text = "";
        //   IDText.Text = "";
        //    CedText.Text = "";

        //}

        private void button6_Click_1(object sender, EventArgs e)
        {
            NombreText.Text = "";
            ApellidoText.Text = "";
            IDText.Text = "";
            CedText.Text = "";
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("los paramentros ubicados en las casillas de nombre y apellido van a ser modificados por el ID sumiminstrado");

                /*Persona persona= */logica1.modificar(int.Parse(IDText.Text), NombreText.Text, ApellidoText.Text, CedText.Text);



              //  MessageBox.Show("Modificado correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("ID era nulo o no existia");
            }


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                logica1.Eliminar(int.Parse(IDText.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("No se propociono un ID Valido");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repasoDataSet.Persona' table. You can move, or remove it, as needed.
            this.personaTableAdapter.Fill(this.repasoDataSet.Persona);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = logica1.Actualizar();
            dataGridView1.Refresh();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona = (logica1.Buscar(int.Parse(IDText.Text)));
        }
    }
}
