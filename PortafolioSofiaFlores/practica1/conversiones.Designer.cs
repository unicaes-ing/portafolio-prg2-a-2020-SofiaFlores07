namespace practica1
{
    partial class conversiones
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
            this.lblDecimal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtOctal = new System.Windows.Forms.TextBox();
            this.txtHexadecimal = new System.Windows.Forms.TextBox();
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblOctal = new System.Windows.Forms.Label();
            this.lblHexadecimal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(42, 39);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(66, 20);
            this.lblDecimal.TabIndex = 0;
            this.lblDecimal.Text = "Decimal";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCalcular.Location = new System.Drawing.Point(46, 465);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 47);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLimpiar.Location = new System.Drawing.Point(190, 465);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 47);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.Location = new System.Drawing.Point(320, 465);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 47);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(131, 39);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(145, 26);
            this.txtDecimal.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHexadecimal);
            this.groupBox1.Controls.Add(this.lblOctal);
            this.groupBox1.Controls.Add(this.lblBinario);
            this.groupBox1.Controls.Add(this.txtHexadecimal);
            this.groupBox1.Controls.Add(this.txtOctal);
            this.groupBox1.Controls.Add(this.txtBinario);
            this.groupBox1.Location = new System.Drawing.Point(46, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equivale a:";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(180, 53);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.ReadOnly = true;
            this.txtBinario.Size = new System.Drawing.Size(142, 26);
            this.txtBinario.TabIndex = 0;
            // 
            // txtOctal
            // 
            this.txtOctal.Location = new System.Drawing.Point(180, 116);
            this.txtOctal.Name = "txtOctal";
            this.txtOctal.ReadOnly = true;
            this.txtOctal.Size = new System.Drawing.Size(142, 26);
            this.txtOctal.TabIndex = 1;
            // 
            // txtHexadecimal
            // 
            this.txtHexadecimal.Location = new System.Drawing.Point(180, 183);
            this.txtHexadecimal.Name = "txtHexadecimal";
            this.txtHexadecimal.ReadOnly = true;
            this.txtHexadecimal.Size = new System.Drawing.Size(142, 26);
            this.txtHexadecimal.TabIndex = 2;
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Location = new System.Drawing.Point(15, 53);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(58, 20);
            this.lblBinario.TabIndex = 3;
            this.lblBinario.Text = "Binario";
            // 
            // lblOctal
            // 
            this.lblOctal.AutoSize = true;
            this.lblOctal.Location = new System.Drawing.Point(15, 116);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(46, 20);
            this.lblOctal.TabIndex = 4;
            this.lblOctal.Text = "Octal";
            // 
            // lblHexadecimal
            // 
            this.lblHexadecimal.AutoSize = true;
            this.lblHexadecimal.Location = new System.Drawing.Point(6, 189);
            this.lblHexadecimal.Name = "lblHexadecimal";
            this.lblHexadecimal.Size = new System.Drawing.Size(100, 20);
            this.lblHexadecimal.TabIndex = 5;
            this.lblHexadecimal.Text = "Hexadecimal";
            // 
            // conversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDecimal);
            this.Name = "conversiones";
            this.Text = "conversiones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHexadecimal;
        private System.Windows.Forms.Label lblOctal;
        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.TextBox txtHexadecimal;
        private System.Windows.Forms.TextBox txtOctal;
        private System.Windows.Forms.TextBox txtBinario;
    }
}