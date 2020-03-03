namespace Practica4
{
    partial class Numeros
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
            this.lblnum4 = new System.Windows.Forms.Label();
            this.lblsuma = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtnum4 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(24, 30);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(78, 20);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Número 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(24, 101);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(78, 20);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Número 2";
            // 
            // lblnum3
            // 
            this.lblnum3.AutoSize = true;
            this.lblnum3.Location = new System.Drawing.Point(24, 178);
            this.lblnum3.Name = "lblnum3";
            this.lblnum3.Size = new System.Drawing.Size(78, 20);
            this.lblnum3.TabIndex = 2;
            this.lblnum3.Text = "Número 3";
            // 
            // lblnum4
            // 
            this.lblnum4.AutoSize = true;
            this.lblnum4.Location = new System.Drawing.Point(24, 252);
            this.lblnum4.Name = "lblnum4";
            this.lblnum4.Size = new System.Drawing.Size(78, 20);
            this.lblnum4.TabIndex = 3;
            this.lblnum4.Text = "Número 4";
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.Location = new System.Drawing.Point(24, 391);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(51, 20);
            this.lblsuma.TabIndex = 4;
            this.lblsuma.Text = "Suma";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(122, 391);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 20);
            this.lbltotal.TabIndex = 5;
            // 
            // txtnum4
            // 
            this.txtnum4.Location = new System.Drawing.Point(146, 246);
            this.txtnum4.Name = "txtnum4";
            this.txtnum4.Size = new System.Drawing.Size(100, 26);
            this.txtnum4.TabIndex = 6;
            // 
            // txtnum3
            // 
            this.txtnum3.Location = new System.Drawing.Point(146, 172);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(100, 26);
            this.txtnum3.TabIndex = 7;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(146, 95);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 26);
            this.txtnum2.TabIndex = 8;
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(146, 24);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 26);
            this.txtnum1.TabIndex = 9;
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.Color.Yellow;
            this.btnSumar.Location = new System.Drawing.Point(113, 306);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(114, 43);
            this.btnSumar.TabIndex = 10;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum4);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.lblnum4);
            this.Controls.Add(this.lblnum3);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Numeros";
            this.Text = "Numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblnum3;
        private System.Windows.Forms.Label lblnum4;
        private System.Windows.Forms.Label lblsuma;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtnum4;
        private System.Windows.Forms.TextBox txtnum3;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Button btnSumar;
    }
}

