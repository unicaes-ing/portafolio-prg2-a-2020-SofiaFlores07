namespace Practica2
{
    partial class Correo
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
            this.components = new System.ComponentModel.Container();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            this.lblconfir = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtconfirmacion = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.err2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.err3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblcorreo.Location = new System.Drawing.Point(23, 33);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(57, 20);
            this.lblcorreo.TabIndex = 0;
            this.lblcorreo.Text = "Correo";
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblcontra.Location = new System.Drawing.Point(23, 87);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(92, 20);
            this.lblcontra.TabIndex = 1;
            this.lblcontra.Text = "Contraseña";
            // 
            // lblconfir
            // 
            this.lblconfir.AutoSize = true;
            this.lblconfir.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblconfir.Location = new System.Drawing.Point(23, 147);
            this.lblconfir.Name = "lblconfir";
            this.lblconfir.Size = new System.Drawing.Size(208, 20);
            this.lblconfir.TabIndex = 2;
            this.lblconfir.Text = "Confirmación de contraseña";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(121, 33);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(394, 26);
            this.txtcorreo.TabIndex = 3;
            this.txtcorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcorreo_Validating);
            this.txtcorreo.Validated += new System.EventHandler(this.txtcorreo_Validated);
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(168, 87);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(347, 26);
            this.txtcontra.TabIndex = 4;
            this.txtcontra.Validating += new System.ComponentModel.CancelEventHandler(this.txtcontra_Validating);
            this.txtcontra.Validated += new System.EventHandler(this.txtcontra_Validated);
            // 
            // txtconfirmacion
            // 
            this.txtconfirmacion.Location = new System.Drawing.Point(237, 144);
            this.txtconfirmacion.Name = "txtconfirmacion";
            this.txtconfirmacion.Size = new System.Drawing.Size(278, 26);
            this.txtconfirmacion.TabIndex = 5;
            this.txtconfirmacion.Validating += new System.ComponentModel.CancelEventHandler(this.txtconfirmacion_Validating);
            this.txtconfirmacion.Validated += new System.EventHandler(this.txtconfirmacion_Validated);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // err2
            // 
            this.err2.ContainerControl = this;
            // 
            // err3
            // 
            this.err3.ContainerControl = this;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.Location = new System.Drawing.Point(134, 223);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 45);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(326, 223);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 45);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(616, 316);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtconfirmacion);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lblconfir);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblcorreo);
            this.Name = "Correo";
            this.Text = "Correo";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.Label lblconfir;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txtconfirmacion;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ErrorProvider err2;
        private System.Windows.Forms.ErrorProvider err3;
    }
}