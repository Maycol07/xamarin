using System;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        double primerNumero, segundoNumero;
        string operacion;

        public MainPage()
        {
            InitializeComponent();
        }

        void NumeroPresionado(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            string numeroPresionado = botonPresionado.Text;

            if (Resultado.Text == "0" || operacion != null)
            {
                Resultado.Text = numeroPresionado;
            }
            else
            {
                Resultado.Text += numeroPresionado;
            }
        }

        void OperacionPresionada(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            operacion = botonPresionado.Text;
            primerNumero = double.Parse(Resultado.Text);
            Resultado.Text = "0";
        }

        void Igual(object sender, EventArgs e)
        {
            segundoNumero = double.Parse(Resultado.Text);

            switch (operacion)
            {
                case "+":
                    Resultado.Text = (primerNumero + segundoNumero).ToString();
                    break;
                case "-":
                    Resultado.Text = (primerNumero - segundoNumero).ToString();
                    break;
                case "*":
                    Resultado.Text = (primerNumero * segundoNumero).ToString();
                    break;
                case "/":
                    Resultado.Text = (primerNumero / segundoNumero).ToString();
                    break;
            }
            operacion = null;
        }

        void Borrar(object sender, EventArgs e)
        {
            Resultado.Text = "0";
            primerNumero = 0;
            segundoNumero = 0;
            operacion = null;
        }
    }
}