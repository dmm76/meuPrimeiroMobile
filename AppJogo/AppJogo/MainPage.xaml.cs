using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnJogar.Clicked += Sortear;

        }

        private void Sortear(object sender, EventArgs args)
        {
            int n = Convert.ToInt32(txtNumero.Text);
            Random r = new Random();
            int s = r.Next(1, 5); // s vai receber um numero randomico de 1 ate 5
            if(s == n)
            {
                lblResultado.Text = "Acertou";
                txtNumero.Text = string.Empty;
                txtNumero.Focus();
            }
            else
            {
                lblResultado.Text = "Errou cabeça de guidão";
                txtNumero.Text = string.Empty;
                txtNumero.Focus();
            }
        }
    }
}
