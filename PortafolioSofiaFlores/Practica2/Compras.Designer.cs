namespace Practica2
{
    partial class Compras
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
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.grpDescuentos = new System.Windows.Forms.GroupBox();
            this.rdodescu5 = new System.Windows.Forms.RadioButton();
            this.rdodescu4 = new System.Windows.Forms.RadioButton();
            this.rdodescu3 = new System.Windows.Forms.RadioButton();
            this.rdodescu2 = new System.Windows.Forms.RadioButton();
            this.rdodescu1 = new System.Windows.Forms.RadioButton();
            this.grpDescuentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(12, 27);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(73, 20);
            this.lblcantidad.TabIndex = 0;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(12, 85);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(53, 20);
            this.lblprecio.TabIndex = 1;
            this.lblprecio.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(112, 27);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(119, 26);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(112, 79);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(119, 26);
            this.txtPrecio.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncalcular.Location = new System.Drawing.Point(84, 137);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(116, 37);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Location = new System.Drawing.Point(12, 215);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(87, 20);
            this.lbldescuento.TabIndex = 5;
            this.lbldescuento.Text = "Descuento";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(12, 278);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(44, 20);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "Total";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(112, 215);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(100, 26);
            this.txtDescuento.TabIndex = 7;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(112, 278);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 26);
            this.txttotal.TabIndex = 8;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnlimpiar.Location = new System.Drawing.Point(16, 355);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 39);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsalir.Location = new System.Drawing.Point(146, 355);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(100, 39);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // grpDescuentos
            // 
            this.grpDescuentos.Controls.Add(this.rdodescu5);
            this.grpDescuentos.Controls.Add(this.rdodescu4);
            this.grpDescuentos.Controls.Add(this.rdodescu3);
            this.grpDescuentos.Controls.Add(this.rdodescu2);
            this.grpDescuentos.Controls.Add(this.rdodescu1);
            this.grpDescuentos.Location = new System.Drawing.Point(298, 37);
            this.grpDescuentos.Name = "grpDescuentos";
            this.grpDescuentos.Size = new System.Drawing.Size(145, 261);
            this.grpDescuentos.TabIndex = 11;
            this.grpDescuentos.TabStop = false;
            this.grpDescuentos.Text = "Descuentos";
            // 
            // rdodescu5
            // 
            this.rdodescu5.AutoSize = true;
            this.rdodescu5.Location = new System.Drawing.Point(16, 210);
            this.rdodescu5.Name = "rdodescu5";
            this.rdodescu5.Size = new System.Drawing.Size(66, 24);
            this.rdodescu5.TabIndex = 4;
            this.rdodescu5.TabStop = true;
            this.rdodescu5.Text = "20%";
            this.rdodescu5.UseVisualStyleBackColor = true;
            // 
            // rdodescu4
            // 
            this.rdodescu4.AutoSize = true;
            this.rdodescu4.Location = new System.Drawing.Point(15, 166);
            this.rdodescu4.Name = "rdodescu4";
            this.rdodescu4.Size = new System.Drawing.Size(66, 24);
            this.rdodescu4.TabIndex = 3;
            this.rdodescu4.TabStop = true;
            this.rdodescu4.Text = "15%";
            this.rdodescu4.UseVisualStyleBackColor = true;
            // 
            // rdodescu3
            // 
            this.rdodescu3.AutoSize = true;
            this.rdodescu3.Location = new System.Drawing.Point(18, 126);
            this.rdodescu3.Name = "rdodescu3";
            this.rdodescu3.Size = new System.Drawing.Size(66, 24);
            this.rdodescu3.TabIndex = 2;
            this.rdodescu3.TabStop = true;
            this.rdodescu3.Text = "10%";
            this.rdodescu3.UseVisualStyleBackColor = true;
            // 
            // rdodescu2
            // 
            this.rdodescu2.AutoSize = true;
            this.rdodescu2.Location = new System.Drawing.Point(17, 80);
            this.rdodescu2.Name = "rdodescu2";
            this.rdodescu2.Size = new System.Drawing.Size(57, 24);
            this.rdodescu2.TabIndex = 1;
            this.rdodescu2.TabStop = true;
            this.rdodescu2.Text = "5%";
            this.rdodescu2.UseVisualStyleBackColor = true;
            // 
            // rdodescu1
            // 
            this.rdodescu1.AutoSize = true;
            this.rdodescu1.Location = new System.Drawing.Point(19, 38);
            this.rdodescu1.Name = "rdodescu1";
            this.rdodescu1.Size = new System.Drawing.Size(57, 24);
            this.rdodescu1.TabIndex = 0;
            this.rdodescu1.TabStop = true;
            this.rdodescu1.Text = "0%";
            this.rdodescu1.UseVisualStyleBackColor = true;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(467, 445);
            this.Controls.Add(this.grpDescuentos);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbldescuento);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblcantidad);
            this.Name = "Compras";
            this.Text = "Compras";
            this.grpDescuentos.ResumeLayout(false);
            this.grpDescuentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.GroupBox grpDescuentos;
        private System.Windows.Forms.RadioButton rdodescu5;
        private System.Windows.Forms.RadioButton rdodescu4;
        private System.Windows.Forms.RadioButton rdodescu3;
        private System.Windows.Forms.RadioButton rdodescu2;
        private System.Windows.Forms.RadioButton rdodescu1;
    }
}