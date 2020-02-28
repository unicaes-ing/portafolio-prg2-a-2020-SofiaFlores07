namespace Practica3
{
    partial class Letras
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstletras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMostrar.ForeColor = System.Drawing.Color.Yellow;
            this.btnMostrar.Location = new System.Drawing.Point(21, 364);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(113, 46);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Motrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstletras
            // 
            this.lstletras.BackColor = System.Drawing.SystemColors.Info;
            this.lstletras.FormattingEnabled = true;
            this.lstletras.ItemHeight = 20;
            this.lstletras.Location = new System.Drawing.Point(12, 12);
            this.lstletras.Name = "lstletras";
            this.lstletras.Size = new System.Drawing.Size(136, 324);
            this.lstletras.TabIndex = 1;
            // 
            // Letras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(260, 422);
            this.Controls.Add(this.lstletras);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Letras";
            this.Text = "Letras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstletras;
    }
}