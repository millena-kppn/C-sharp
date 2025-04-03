using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos
{
    public partial class Aplicacao : Form
    {
        //Conversão e operadores aritméticos
        int numero1, numero2, resultado;// criação de variáveis na mesma linha

        public Aplicacao()
        {
            InitializeComponent();
        }
        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Aplicacao.ActiveForm.Close();//fecha o formulário
        }
        private void ButtonSomar_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(textNumeroOne.Text);
            numero2 = int.Parse(textNumeroTwo.Text);
            resultado = numero1 + numero2;
            textResultado.Text = resultado.ToString();
        }
        private void ButtonSubtrair_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(textNumeroOne.Text);//conversão de string para inteiro
            numero2 = int.Parse(textNumeroTwo.Text);//conversão de string para inteiro
            resultado = numero1 - numero2;//subtração de inteiro
            textResultado.Text = resultado.ToString();//conversão de inteiro para string
        }

    }
}
