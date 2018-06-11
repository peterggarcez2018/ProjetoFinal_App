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
	public partial class Pais : ContentPage
	{
		public Pais ()
		{
			InitializeComponent ();


        }

        public void validarSenhaPais() {
            bool isCoordenador = Logica.VerificarSenhas.verificarSenhaPais(LoginPais, SenhaPais);
            if (isCoordenador) {
              // App.Current.MainPage = new  
            } else {
                retornosenha.Text = "Login ou Senha Incorretos";
            }
                   
                
                
                }





    }
}