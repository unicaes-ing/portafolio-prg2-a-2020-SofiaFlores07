namespace Practica4
{
    partial class Fibonacci
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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtFibonacci = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(33, 32);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(65, 20);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Número";
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.AutoSize = true;
            this.lblFibonacci.Location = new System.Drawing.Point(33, 161);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(77, 20);
            this.lblFibonacci.TabIndex = 1;
            this.lblFibonacci.Text = "Fibonacci";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(129, 26);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(134, 26);
            this.txtnum.TabIndex = 2;
            // 
            // txtFibonacci
            // 
            this.txtFibonacci.Location = new System.Drawing.Point(129, 161);
            this.txtFibonacci.Name = "txtFibonacci";
            this.txtFibonacci.ReadOnly = true;
            this.txtFibonacci.Size = new System.Drawing.Size(134, 26);
            this.txtFibonacci.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(129, 81);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 39);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 237);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtFibonacci);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblFibonacci);
            this.Controls.Add(this.lblNum);
            this.Name = "Fibonacci";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblFibonacci;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtFibonacci;
        private System.Windows.Forms.Button btnCalcular;
    }
}