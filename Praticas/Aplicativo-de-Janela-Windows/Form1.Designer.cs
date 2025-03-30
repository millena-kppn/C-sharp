namespace Aplicativo_de_Janela_Windows
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
            this.CaixadeTexto = new System.Windows.Forms.TextBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaixadeTexto
            // 
            this.CaixadeTexto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CaixadeTexto.Location = new System.Drawing.Point(164, 164);
            this.CaixadeTexto.Name = "CaixadeTexto";
            this.CaixadeTexto.Size = new System.Drawing.Size(427, 20);
            this.CaixadeTexto.TabIndex = 0;
            this.CaixadeTexto.Text = "Digite seu nome...";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(164, 309);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 1;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonSair
            // 
            this.ButtonSair.Location = new System.Drawing.Point(435, 309);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(75, 23);
            this.ButtonSair.TabIndex = 2;
            this.ButtonSair.Text = "Sair";
            this.ButtonSair.UseVisualStyleBackColor = true;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Location = new System.Drawing.Point(516, 309);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelar.TabIndex = 3;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // Aplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonSair);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.CaixadeTexto);
            this.Name = "Aplicacao";
            this.Text = "Aplicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CaixadeTexto;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonSair;
        private System.Windows.Forms.Button ButtonCancelar;
    }
}

