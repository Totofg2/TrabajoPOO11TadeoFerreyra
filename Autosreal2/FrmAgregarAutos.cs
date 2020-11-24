using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosreal2
{
    public partial class FrmAgregarAutos : Form
    {
        public FrmAgregarAutos()
        {
            InitializeComponent();
        }

        private void Cancelbutton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private Datos datos;

        internal Datos Datos { get; private set; }

        private void okbutton1_Click_1(object sender, EventArgs e)
        {
            if (validardatos()) 
            {
                if (datos==null)
                {
                    datos = new Datos();
                }
                datos.Color = ColorTextBox.Text;
                datos.Patente = PatenteTextBox.Text;
                datos.Combustible = SiRadioButton.Checked ? Combustible.Si : Combustible.No;
                datos.Aniodefabricacion = AniodefabricacionTextBox.Text;
                datos.Modelo = ModelotextBox.Text;
                datos.Marca = MarcaTextBox.Text;
                DialogResult = DialogResult.OK;

            }
        }

        internal Datos GetDatos()
        {
            return datos;
        }

        private bool validardatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            
            if (string.IsNullOrEmpty(ColorTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ColorTextBox, "El color es obligatorio");


            }
            if (string.IsNullOrEmpty(PatenteTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(PatenteTextBox, "La patente es necesaria");

            }
            return valido;
            




        }

        internal void SetAuto(Datos datos)
        {
            Datos = datos;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (datos != null)
            {
                PatenteTextBox.Text = Datos.Patente;
            }
        }
    }     

 }

