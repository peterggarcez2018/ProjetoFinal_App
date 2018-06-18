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
        public Pais()
        {
            InitializeComponent();


        }

        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new MainPage();
            return true;
        }





    }
}