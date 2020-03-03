namespace Practica4
{
    partial class Lista
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
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblbuscado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(12, 29);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(65, 20);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Número";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(83, 23);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(89, 26);
            this.txtnum.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(201, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 44);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 20;
            this.lstLista.Location = new System.Drawing.Point(12, 65);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(176, 304);
            this.lstLista.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(201, 342);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 26);
            this.txtBuscar.TabIndex = 4;
            // 
            // lblbuscado
            // 
            this.lblbuscado.AutoSize = true;
            this.lblbuscado.Location = new System.Drawing.Point(206, 302);
            this.lblbuscado.Name = "lblbuscado";
            this.lblbuscado.Size = new System.Drawing.Size(65, 20);
            this.lblbuscado.TabIndex = 5;
            this.lblbuscado.Text = "Número";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.Location = new System.Drawing.Point(205, 374);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 35);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(352, 436);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblbuscado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblnum);
            this.Name = "Lista";
            this.Text = "Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblbuscado;
        private System.Windows.Forms.Button btnBuscar;
    }
}