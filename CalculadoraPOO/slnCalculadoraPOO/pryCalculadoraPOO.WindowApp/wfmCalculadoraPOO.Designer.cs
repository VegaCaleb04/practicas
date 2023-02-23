
namespace pryCalculadoraPOO.WindowApp
{
    partial class wfmCalculadoraPOO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValorA = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.lblValorB = new System.Windows.Forms.Label();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.lblTituloCalculadoraPOO = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblValidacion = new System.Windows.Forms.Label();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorA.Location = new System.Drawing.Point(41, 90);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(52, 15);
            this.lblValorA.TabIndex = 0;
            this.lblValorA.Text = "Valor A: ";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(123, 82);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(224, 23);
            this.txtValorA.TabIndex = 1;
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorB.Location = new System.Drawing.Point(41, 128);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(49, 15);
            this.lblValorB.TabIndex = 2;
            this.lblValorB.Text = "Valor B:";
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(123, 120);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(224, 23);
            this.txtValorB.TabIndex = 3;
            // 
            // lblTituloCalculadoraPOO
            // 
            this.lblTituloCalculadoraPOO.AutoSize = true;
            this.lblTituloCalculadoraPOO.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCalculadoraPOO.Location = new System.Drawing.Point(41, 31);
            this.lblTituloCalculadoraPOO.Name = "lblTituloCalculadoraPOO";
            this.lblTituloCalculadoraPOO.Size = new System.Drawing.Size(233, 37);
            this.lblTituloCalculadoraPOO.TabIndex = 4;
            this.lblTituloCalculadoraPOO.Text = "Calculadora POO";
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma.Location = new System.Drawing.Point(41, 183);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "Suma +";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(41, 269);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 15);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado :";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(123, 261);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 23);
            this.txtResultado.TabIndex = 7;
            // 
            // lblValidacion
            // 
            this.lblValidacion.AutoSize = true;
            this.lblValidacion.Location = new System.Drawing.Point(41, 232);
            this.lblValidacion.Name = "lblValidacion";
            this.lblValidacion.Size = new System.Drawing.Size(38, 15);
            this.lblValidacion.TabIndex = 8;
            this.lblValidacion.Text = "label5";
            this.lblValidacion.Click += new System.EventHandler(this.lblValidacion_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResta.Location = new System.Drawing.Point(145, 183);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 9;
            this.btnResta.Text = "Resta -";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.Location = new System.Drawing.Point(250, 183);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(105, 23);
            this.btnMultiplicar.TabIndex = 9;
            this.btnMultiplicar.Text = "Multiplicacion *";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDividir.Location = new System.Drawing.Point(408, 182);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 10;
            this.btnDividir.Text = " Division /";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // wfmCalculadoraPOO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.lblValidacion);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lblTituloCalculadoraPOO);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblValorA);
            this.Name = "wfmCalculadoraPOO";
            this.Text = "Calculadora POO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Label lblTituloCalculadoraPOO;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblValidacion;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
    }
}

