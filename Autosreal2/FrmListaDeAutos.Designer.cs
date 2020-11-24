
namespace Autosreal2
{
    partial class FrmListaDeAutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaDeAutos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAniodefabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Ordenarstrp = new System.Windows.Forms.ToolStripDropDownButton();
            this.AscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirtoolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatente,
            this.colMarca,
            this.colCombustible,
            this.colModelo,
            this.colAniodefabricacion,
            this.colColor});
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 416);
            this.dataGridView1.TabIndex = 13;
            // 
            // colPatente
            // 
            this.colPatente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPatente.HeaderText = "Patente";
            this.colPatente.Name = "colPatente";
            // 
            // colMarca
            // 
            this.colMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            // 
            // colCombustible
            // 
            this.colCombustible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCombustible.HeaderText = "Combustible";
            this.colCombustible.Name = "colCombustible";
            // 
            // colModelo
            // 
            this.colModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            // 
            // colAniodefabricacion
            // 
            this.colAniodefabricacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAniodefabricacion.HeaderText = "Año de fabricacion";
            this.colAniodefabricacion.Name = "colAniodefabricacion";
            // 
            // colColor
            // 
            this.colColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.Ordenarstrp,
            this.ActualizarStripButton6,
            this.toolStripSeparator2,
            this.SalirtoolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(825, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton2.Text = "Borrar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton3.Text = "Editar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Ordenarstrp
            // 
            this.Ordenarstrp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AscToolStripMenuItem,
            this.DesToolStripMenuItem});
            this.Ordenarstrp.Image = ((System.Drawing.Image)(resources.GetObject("Ordenarstrp.Image")));
            this.Ordenarstrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ordenarstrp.Name = "Ordenarstrp";
            this.Ordenarstrp.Size = new System.Drawing.Size(79, 22);
            this.Ordenarstrp.Text = "Ordenar";
            // 
            // AscToolStripMenuItem
            // 
            this.AscToolStripMenuItem.Name = "AscToolStripMenuItem";
            this.AscToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AscToolStripMenuItem.Text = "O.Ascedente";
            this.AscToolStripMenuItem.Click += new System.EventHandler(this.AscToolStripMenuItem_Click);
            // 
            // DesToolStripMenuItem
            // 
            this.DesToolStripMenuItem.Name = "DesToolStripMenuItem";
            this.DesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DesToolStripMenuItem.Text = "O.Desc";
            this.DesToolStripMenuItem.Click += new System.EventHandler(this.DesToolStripMenuItem_Click);
            // 
            // ActualizarStripButton6
            // 
            this.ActualizarStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("ActualizarStripButton6.Image")));
            this.ActualizarStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarStripButton6.Name = "ActualizarStripButton6";
            this.ActualizarStripButton6.Size = new System.Drawing.Size(79, 22);
            this.ActualizarStripButton6.Text = "Actualizar";
            this.ActualizarStripButton6.Click += new System.EventHandler(this.ActualizarStripButton6_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SalirtoolStripButton4
            // 
            this.SalirtoolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("SalirtoolStripButton4.Image")));
            this.SalirtoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirtoolStripButton4.Name = "SalirtoolStripButton4";
            this.SalirtoolStripButton4.Size = new System.Drawing.Size(49, 22);
            this.SalirtoolStripButton4.Text = "Salir";
            this.SalirtoolStripButton4.Click += new System.EventHandler(this.SalirtoolStripButton4_Click);
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Location = new System.Drawing.Point(15, 463);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(99, 13);
            this.CantidadLabel.TabIndex = 14;
            this.CantidadLabel.Text = "Cantidad De Autos:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(121, 463);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadTextBox.TabIndex = 15;
            // 
            // FrmListaDeAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 489);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmListaDeAutos";
            this.Text = "Lista De Autos";
            this.Load += new System.EventHandler(this.FrmListaDeAutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ActualizarStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirtoolStripButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAniodefabricacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.ToolStripDropDownButton Ordenarstrp;
        private System.Windows.Forms.ToolStripMenuItem AscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DesToolStripMenuItem;
    }
}