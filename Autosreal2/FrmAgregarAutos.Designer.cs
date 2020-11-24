
using System;

namespace Autosreal2
{
    partial class FrmAgregarAutos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ModelotextBox = new System.Windows.Forms.TextBox();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.AniodefabricacionTextBox = new System.Windows.Forms.TextBox();
            this.PatenteTextBox = new System.Windows.Forms.TextBox();
            this.okbutton1 = new System.Windows.Forms.Button();
            this.Cancelbutton2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SiRadioButton = new System.Windows.Forms.RadioButton();
            this.NoradioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Combustible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año de fabricacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Patente";
            // 
            // ModelotextBox
            // 
            this.ModelotextBox.Location = new System.Drawing.Point(523, 30);
            this.ModelotextBox.Name = "ModelotextBox";
            this.ModelotextBox.Size = new System.Drawing.Size(125, 20);
            this.ModelotextBox.TabIndex = 4;
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.AcceptsTab = true;
            this.MarcaTextBox.Location = new System.Drawing.Point(-1, 30);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(125, 20);
            this.MarcaTextBox.TabIndex = 0;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(130, 30);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(125, 20);
            this.ColorTextBox.TabIndex = 1;
            // 
            // AniodefabricacionTextBox
            // 
            this.AniodefabricacionTextBox.Location = new System.Drawing.Point(392, 30);
            this.AniodefabricacionTextBox.Name = "AniodefabricacionTextBox";
            this.AniodefabricacionTextBox.Size = new System.Drawing.Size(125, 20);
            this.AniodefabricacionTextBox.TabIndex = 3;
            // 
            // PatenteTextBox
            // 
            this.PatenteTextBox.Location = new System.Drawing.Point(654, 30);
            this.PatenteTextBox.Name = "PatenteTextBox";
            this.PatenteTextBox.Size = new System.Drawing.Size(125, 20);
            this.PatenteTextBox.TabIndex = 5;
            // 
            // okbutton1
            // 
            this.okbutton1.Location = new System.Drawing.Point(33, 394);
            this.okbutton1.Name = "okbutton1";
            this.okbutton1.Size = new System.Drawing.Size(75, 23);
            this.okbutton1.TabIndex = 12;
            this.okbutton1.Text = "Ok";
            this.okbutton1.UseVisualStyleBackColor = true;
            this.okbutton1.Click += new System.EventHandler(this.okbutton1_Click_1);
            // 
            // Cancelbutton2
            // 
            this.Cancelbutton2.Location = new System.Drawing.Point(677, 405);
            this.Cancelbutton2.Name = "Cancelbutton2";
            this.Cancelbutton2.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton2.TabIndex = 13;
            this.Cancelbutton2.Text = "Cancel";
            this.Cancelbutton2.UseVisualStyleBackColor = true;
            this.Cancelbutton2.Click += new System.EventHandler(this.Cancelbutton2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SiRadioButton
            // 
            this.SiRadioButton.AutoSize = true;
            this.SiRadioButton.Checked = true;
            this.SiRadioButton.Location = new System.Drawing.Point(261, 30);
            this.SiRadioButton.Name = "SiRadioButton";
            this.SiRadioButton.Size = new System.Drawing.Size(34, 17);
            this.SiRadioButton.TabIndex = 14;
            this.SiRadioButton.TabStop = true;
            this.SiRadioButton.Text = "Si";
            this.SiRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoradioButton
            // 
            this.NoradioButton.AutoSize = true;
            this.NoradioButton.Location = new System.Drawing.Point(323, 31);
            this.NoradioButton.Name = "NoradioButton";
            this.NoradioButton.Size = new System.Drawing.Size(39, 17);
            this.NoradioButton.TabIndex = 15;
            this.NoradioButton.Text = "No";
            this.NoradioButton.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoradioButton);
            this.Controls.Add(this.SiRadioButton);
            this.Controls.Add(this.Cancelbutton2);
            this.Controls.Add(this.okbutton1);
            this.Controls.Add(this.PatenteTextBox);
            this.Controls.Add(this.AniodefabricacionTextBox);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.MarcaTextBox);
            this.Controls.Add(this.ModelotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarAutos";
            this.Text = "Autos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ModelotextBox;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox AniodefabricacionTextBox;
        private System.Windows.Forms.TextBox PatenteTextBox;
        private System.Windows.Forms.Button okbutton1;
        private System.Windows.Forms.Button Cancelbutton2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton NoradioButton;
        private System.Windows.Forms.RadioButton SiRadioButton;
    }
}

