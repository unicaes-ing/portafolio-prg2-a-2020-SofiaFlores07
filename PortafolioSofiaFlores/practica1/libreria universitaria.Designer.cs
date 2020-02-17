namespace practica1
{
    partial class libreria_universitaria
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lalSubtotal = new System.Windows.Forms.Label();
            this.cboLibros = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(284, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 38);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(155, 409);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(88, 38);
            this.btnNueva.TabIndex = 28;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(26, 409);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 38);
            this.btnCalcular.TabIndex = 27;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(194, 149);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(127, 26);
            this.txtCantidad.TabIndex = 26;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(194, 91);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(127, 26);
            this.txtPrecio.TabIndex = 25;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(194, 345);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(127, 26);
            this.txtTotal.TabIndex = 24;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(194, 275);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(127, 26);
            this.txtImpuesto.TabIndex = 23;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(194, 228);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(127, 26);
            this.txtSubtotal.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(26, 345);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 20);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total a pagar:";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(22, 281);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(122, 20);
            this.lblImpuesto.TabIndex = 20;
            this.lblImpuesto.Text = "Impuesto(13%):";
            // 
            // lalSubtotal
            // 
            this.lalSubtotal.AutoSize = true;
            this.lalSubtotal.Location = new System.Drawing.Point(26, 231);
            this.lalSubtotal.Name = "lalSubtotal";
            this.lalSubtotal.Size = new System.Drawing.Size(73, 20);
            this.lalSubtotal.TabIndex = 19;
            this.lalSubtotal.Text = "Subtotal:";
            // 
            // cboLibros
            // 
            this.cboLibros.FormattingEnabled = true;
            this.cboLibros.Items.AddRange(new object[] {
            "The Lord Of The Rings (J.R.R Tolkien)",
            "Drácula (Bram Stroker)",
            "La Casa De Los Espiritus (Isabel Allende)",
            "Harry Potter (J.K. Rowling)",
            "The Twilight (Stephenie Meyer)",
            "The Da Vinci Code ( Dan Brown)",
            ""});
            this.cboLibros.Location = new System.Drawing.Point(194, 40);
            this.cboLibros.Name = "cboLibros";
            this.cboLibros.Size = new System.Drawing.Size(373, 28);
            this.cboLibros.TabIndex = 18;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(22, 152);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(22, 97);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(22, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 20);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Titulo del libro:";
            // 
            // libreria_universitaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 476);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.lalSubtotal);
            this.Controls.Add(this.cboLibros);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTitulo);
            this.Name = "libreria_universitaria";
            this.Text = "libreria_universitaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lalSubtotal;
        private System.Windows.Forms.ComboBox cboLibros;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTitulo;
    }
}