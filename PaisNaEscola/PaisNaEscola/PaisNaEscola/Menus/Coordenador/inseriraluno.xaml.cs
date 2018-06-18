using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaisNaEscola.Menus.Coordenador
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class inseriraluno : ContentPage
	{
		public inseriraluno ()
		{
			InitializeComponent ();
		}
        public async Task cadaluno(object sender,EventArgs args)
        {
            Logica.Aluno A = new Logica.Aluno(nomealuno.Text, matricula.Text, int.Parse(turma.Text), responsavel.Text, senhapais.Text);
            Logica.Listas.alunos.Add(A);
            var answer = await DisplayAlert("Confirmação!", "Aluno Cadastrado com sucesso", "OK");
            if (answer)
            {
                App.Current.MainPage = new inseriraluno();
            }
            
        }
        public void voltarpagcoord(object sender, EventArgs args)
        {
            App.Current.MainPage = new MenuCoordenador();
        }
	}
}