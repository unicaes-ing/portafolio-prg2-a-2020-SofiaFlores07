namespace Practica3
{
    partial class Dado
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
            this.lstLanzamiento = new System.Windows.Forms.ListBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLanzamiento
            // 
            this.lstLanzamiento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstLanzamiento.FormattingEnabled = true;
            this.lstLanzamiento.ItemHeight = 20;
            this.lstLanzamiento.Location = new System.Drawing.Point(30, 12);
            this.lstLanzamiento.Name = "lstLanzamiento";
            this.lstLanzamiento.Size = new System.Drawing.Size(153, 324);
            this.lstLanzamiento.TabIndex = 0;
            // 
            // btnLanzar
            // 
            this.btnLanzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLanzar.Location = new System.Drawing.Point(53, 362);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(98, 39);
            this.btnLanzar.TabIndex = 1;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = false;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // Dado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(240, 435);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.lstLanzamiento);
            this.Name = "Dado";
            this.Text = "Dado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLanzamiento;
        private System.Windows.Forms.Button btnLanzar;
    }
}