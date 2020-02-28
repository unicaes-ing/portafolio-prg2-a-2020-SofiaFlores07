namespace Practica4
{
    partial class Mayor
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblnum3 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.btnmayor = new System.Windows.Forms.Button();
            this.lblmayor = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(33, 28);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(78, 20);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Número 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(33, 83);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(78, 20);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Número 2";
            // 
            // lblnum3
            // 
            this.lblnum3.AutoSize = true;
            this.lblnum3.Location = new System.Drawing.Point(32, 146);
            this.lblnum3.Name = "lblnum3";
            this.lblnum3.Size = new System.Drawing.Size(78, 20);
            this.lblnum3.TabIndex = 2;
            this.lblnum3.Text = "Número 3";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(128, 22);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 26);
            this.txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(128, 80);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 26);
            this.txtnum2.TabIndex = 4;
            // 
            // txtnum3
            // 
            this.txtnum3.Location = new System.Drawing.Point(128, 140);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(100, 26);
            this.txtnum3.TabIndex = 5;
            // 
            // btnmayor
            // 
            this.btnmayor.Location = new System.Drawing.Point(98, 199);
            this.btnmayor.Name = "btnmayor";
            this.btnmayor.Size = new System.Drawing.Size(107, 36);
            this.btnmayor.TabIndex = 6;
            this.btnmayor.Text = "Mayor";
            this.btnmayor.UseVisualStyleBackColor = true;
            this.btnmayor.Click += new System.EventHandler(this.btnmayor_Click);
            // 
            // lblmayor
            // 
            this.lblmayor.AutoSize = true;
            this.lblmayor.Location = new System.Drawing.Point(52, 280);
            this.lblmayor.Name = "lblmayor";
            this.lblmayor.Size = new System.Drawing.Size(52, 20);
            this.lblmayor.TabIndex = 7;
            this.lblmayor.Text = "Mayor";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(110, 271);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(0, 20);
            this.lblrespuesta.TabIndex = 8;
            // 
            // Mayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 328);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblmayor);
            this.Controls.Add(this.btnmayor);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum3);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Mayor";
            this.Text = "Mayor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblnum3;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum3;
        private System.Windows.Forms.Button btnmayor;
        private System.Windows.Forms.Label lblmayor;
        private System.Windows.Forms.Label lblrespuesta;
    }
}