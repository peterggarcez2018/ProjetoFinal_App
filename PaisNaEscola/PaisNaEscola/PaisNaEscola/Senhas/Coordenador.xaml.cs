using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaisNaEscola.Senhas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Coordenador : ContentPage
    {
        public Coordenador()
        {
            InitializeComponent();

            Logica.Coordenador fulano = new Logica.Coordenador("coord", "teste");
        }
        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new MainPage();
            return true;
        }
        public void verificarloginsenha(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(LoginCoord.Text) || string.IsNullOrEmpty(SenhaCoord.Text))
            {
                DisplayAlert("Atenção!", "Login ou senha inválidos", "OK");

            }
            else if (LoginCoord.Text == "coord" && SenhaCoord.Text == "teste")
            {
                App.Current.MainPage = new Menus.Coordenador.ConteudoCoord(); 
            }else
            {
                DisplayAlert("Atenção!", "Login ou senha incorretos", "OK"); 
            }

        }



    }
}