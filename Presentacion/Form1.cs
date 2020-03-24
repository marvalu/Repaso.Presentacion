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
    }
}
