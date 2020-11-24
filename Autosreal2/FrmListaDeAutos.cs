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
    public partial class FrmListaDeAutos : Form
    {
        public FrmListaDeAutos()
        {
            InitializeComponent();
        }

        public void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmAgregarAutos frm = new FrmAgregarAutos() { Text = "Agregar auto" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK) 
            {
                Datos datos = frm.GetDatos();
                repositorio.Agregar(datos);
                var r = ContruirFila();
                SetearFila(r, datos);
                AgregarFila(r);
                MostrarCantidadDeAutos();
            
            }

        }

        private void AgregarFila(DataGridViewRow r)
        {
            dataGridView1.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Datos datos)
        {
            r.Cells[colPatente.Index].Value = datos.Patente;
            r.Cells[colColor.Index].Value = datos.Color;
                r.Cells[colCombustible.Index].Value = datos.Combustible;
            r.Cells[colMarca.Index].Value = datos.Marca;
            r.Cells[colModelo.Index].Value = datos.Modelo;
            r.Cells[colAniodefabricacion.Index].Value = datos.Aniodefabricacion;
            r.Tag = datos;
        }

        
        private DataGridViewRow ContruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGridView1);
            return r;
        }


        private RepositorioAutos repositorio;
        public void SalirtoolStripButton4_Click(object sender, EventArgs e)
        {
            repositorio.GuardarDatosEnArchivo();
            Application.Exit();
        }


        private List<Datos> lista;
        private void FrmListaDeAutos_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioAutos();
            if (repositorio.GetCantidad()>0)
            {
                lista = repositorio.GetLista();
                MostrarDatosEnGrilla();
            }
            MostrarCantidadDeAutos();
        }

        private void MostrarCantidadDeAutos()
        {
            CantidadTextBox.Text=repositorio.GetCantidad().ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            dataGridView1.Rows.Clear();
            foreach (var datos in lista)
            {
                var r = ContruirFila();
                SetearFila(r, datos);
                AgregarFila(r);
            }
        }

        private void AscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenadaAscendente();
            MostrarDatosEnGrilla();
        }

        private void DesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenadaDescendente();
            MostrarDatosEnGrilla();
        }

        private void ActualizarStripButton6_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea eliminar este auto?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {





                var iFila = dataGridView1.SelectedRows[0].Index;

                dataGridView1.Rows.RemoveAt(iFila);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {


                var r = dataGridView1.SelectedRows[0];
                Datos datos =(Datos) r.Tag;
                FrmAgregarAutos frm = new FrmAgregarAutos();
                frm.Text = "Editar un auto";
                frm.SetAuto(datos);
                DialogResult dr = frm.ShowDialog(this);
            }
        }

        
    }
}
