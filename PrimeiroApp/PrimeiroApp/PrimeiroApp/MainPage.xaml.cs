using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimeiroApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnVerificar_Clicked(object sender, EventArgs e)
        {
            string texto = $"O nome tem {txtNome.Text.Length} caracteres";
            DisplayAlert("Mensagem", texto, "Ok");

        }

        private async void btnLimpar_Clicked(object sender, EventArgs e)
        {
            if(await DisplayAlert("Pergunta", "Deseja realmente Limpar?", "Yes", "No"))
            {
                txtNome.Text = String.Empty;
                //Mesmo que --> txtNome.Text = "";
            }
        }
    }
}
