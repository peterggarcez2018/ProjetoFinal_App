using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PaisNaEscola.Senhas; 

namespace PaisNaEscola {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }
        private void SenhaPais(object sender, EventArgs args) {
            App.Current.MainPage = new Senhas.Pais();
        }
        private void SenhaProf(object sender, EventArgs args) {
            App.Current.MainPage = new Senhas.Professor(); 
        }
        private void SenhaCoord(object sender, EventArgs args) {
            App.Current.MainPage = new Senhas.Coordenador();

        }
    }
}