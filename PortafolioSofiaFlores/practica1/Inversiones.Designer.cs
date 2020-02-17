namespace practica1
{
    partial class Inversiones
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
            this.lblInversionistas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInver1 = new System.Windows.Forms.TextBox();
            this.txtInver2 = new System.Windows.Forms.TextBox();
            this.txtInver3 = new System.Windows.Forms.TextBox();
            this.txtPorcen1 = new System.Windows.Forms.TextBox();
            this.txtPorcen2 = new System.Windows.Forms.TextBox();
            this.txtPorcen3 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInversionistas
            // 
            this.lblInversionistas.AutoSize = true;
            this.lblInversionistas.Location = new System.Drawing.Point(32, 39);
            this.lblInversionistas.Name = "lblInversionistas";
            this.lblInversionistas.Size = new System.Drawing.Size(106, 20);
            this.lblInversionistas.TabIndex = 0;
            this.lblInversionistas.Text = "Inversionistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Porcentajes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total de inversiones";
            // 
            // txtInver1
            // 
            this.txtInver1.Location = new System.Drawing.Point(40, 81);
            this.txtInver1.Name = "txtInver1";
            this.txtInver1.Size = new System.Drawing.Size(130, 26);
            this.txtInver1.TabIndex = 6;
            // 
            // txtInver2
            // 
            this.txtInver2.Location = new System.Drawing.Point(36, 138);
            this.txtInver2.Name = "txtInver2";
            this.txtInver2.Size = new System.Drawing.Size(134, 26);
            this.txtInver2.TabIndex = 7;
            // 
            // txtInver3
            // 
            this.txtInver3.Location = new System.Drawing.Point(40, 204);
            this.txtInver3.Name = "txtInver3";
            this.txtInver3.Size = new System.Drawing.Size(130, 26);
            this.txtInver3.TabIndex = 8;
            // 
            // txtPorcen1
            // 
            this.txtPorcen1.Location = new System.Drawing.Point(235, 78);
            this.txtPorcen1.Name = "txtPorcen1";
            this.txtPorcen1.ReadOnly = true;
            this.txtPorcen1.Size = new System.Drawing.Size(128, 26);
            this.txtPorcen1.TabIndex = 9;
            // 
            // txtPorcen2
            // 
            this.txtPorcen2.Location = new System.Drawing.Point(235, 138);
            this.txtPorcen2.Name = "txtPorcen2";
            this.txtPorcen2.ReadOnly = true;
            this.txtPorcen2.Size = new System.Drawing.Size(128, 26);
            this.txtPorcen2.TabIndex = 10;
            // 
            // txtPorcen3
            // 
            this.txtPorcen3.Location = new System.Drawing.Point(235, 204);
            this.txtPorcen3.Name = "txtPorcen3";
            this.txtPorcen3.ReadOnly = true;
            this.txtPorcen3.Size = new System.Drawing.Size(128, 26);
            this.txtPorcen3.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(51, 299);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(141, 26);
            this.txtTotal.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalcular.Location = new System.Drawing.Point(16, 377);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 44);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Location = new System.Drawing.Point(156, 377);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 44);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.Location = new System.Drawing.Point(280, 377);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 44);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Inversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 441);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPorcen3);
            this.Controls.Add(this.txtPorcen2);
            this.Controls.Add(this.txtPorcen1);
            this.Controls.Add(this.txtInver3);
            this.Controls.Add(this.txtInver2);
            this.Controls.Add(this.txtInver1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInversionistas);
            this.Name = "Inversiones";
            this.Text = "Inversiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInversionistas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInver1;
        private System.Windows.Forms.TextBox txtInver2;
        private System.Windows.Forms.TextBox txtInver3;
        private System.Windows.Forms.TextBox txtPorcen1;
        private System.Windows.Forms.TextBox txtPorcen2;
        private System.Windows.Forms.TextBox txtPorcen3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}