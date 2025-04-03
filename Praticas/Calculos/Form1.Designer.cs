namespace Calculos
{
    partial class Aplicacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textNumeroOne = new System.Windows.Forms.TextBox();
            this.NumeroOne = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumeroTwo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.ButtonSomar = new System.Windows.Forms.Button();
            this.Calculos = new System.Windows.Forms.Label();
            this.ButtonSubtrair = new System.Windows.Forms.Button();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNumeroOne
            // 
            this.textNumeroOne.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textNumeroOne.Location = new System.Drawing.Point(116, 83);
            this.textNumeroOne.Name = "textNumeroOne";
            this.textNumeroOne.Size = new System.Drawing.Size(296, 20);
            this.textNumeroOne.TabIndex = 0;
            // 
            // NumeroOne
            // 
            this.NumeroOne.AutoSize = true;
            this.NumeroOne.Location = new System.Drawing.Point(60, 90);
            this.NumeroOne.Name = "NumeroOne";
            this.NumeroOne.Size = new System.Drawing.Size(50, 13);
            this.NumeroOne.TabIndex = 1;
            this.NumeroOne.Text = "Numero1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero2";
            // 
            // textNumeroTwo
            // 
            this.textNumeroTwo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textNumeroTwo.Location = new System.Drawing.Point(116, 164);
            this.textNumeroTwo.Name = "textNumeroTwo";
            this.textNumeroTwo.Size = new System.Drawing.Size(296, 20);
            this.textNumeroTwo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(116, 240);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(296, 20);
            this.textResultado.TabIndex = 4;
            // 
            // ButtonSomar
            // 
            this.ButtonSomar.Location = new System.Drawing.Point(418, 240);
            this.ButtonSomar.Name = "ButtonSomar";
            this.ButtonSomar.Size = new System.Drawing.Size(75, 23);
            this.ButtonSomar.TabIndex = 6;
            this.ButtonSomar.Text = "Somar";
            this.ButtonSomar.UseVisualStyleBackColor = true;
            this.ButtonSomar.Click += new System.EventHandler(this.ButtonSomar_Click);
            // 
            // Calculos
            // 
            this.Calculos.AutoSize = true;
            this.Calculos.Location = new System.Drawing.Point(235, 45);
            this.Calculos.Name = "Calculos";
            this.Calculos.Size = new System.Drawing.Size(47, 13);
            this.Calculos.TabIndex = 7;
            this.Calculos.Text = "Calculos";
            // 
            // ButtonSubtrair
            // 
            this.ButtonSubtrair.Location = new System.Drawing.Point(499, 240);
            this.ButtonSubtrair.Name = "ButtonSubtrair";
            this.ButtonSubtrair.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubtrair.TabIndex = 8;
            this.ButtonSubtrair.Text = "Subtrair";
            this.ButtonSubtrair.UseVisualStyleBackColor = true;
            this.ButtonSubtrair.Click += new System.EventHandler(this.ButtonSubtrair_Click);
            // 
            // ButtonSair
            // 
            this.ButtonSair.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonSair.ForeColor = System.Drawing.Color.Brown;
            this.ButtonSair.Location = new System.Drawing.Point(418, 45);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(75, 23);
            this.ButtonSair.TabIndex = 9;
            this.ButtonSair.Text = "Sair";
            this.ButtonSair.UseVisualStyleBackColor = false;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // Aplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSair);
            this.Controls.Add(this.ButtonSubtrair);
            this.Controls.Add(this.Calculos);
            this.Controls.Add(this.ButtonSomar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNumeroTwo);
            this.Controls.Add(this.NumeroOne);
            this.Controls.Add(this.textNumeroOne);
            this.Name = "Aplicacao";
            this.Text = "Aplicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumeroOne;
        private System.Windows.Forms.Label NumeroOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumeroTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button ButtonSomar;
        private System.Windows.Forms.Label Calculos;
        private System.Windows.Forms.Button ButtonSubtrair;
        private System.Windows.Forms.Button ButtonSair;
    }
}

