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
	public partial class MenuCoordenador : MasterDetailPage
	{
		public MenuCoordenador ()
		{
			InitializeComponent ();
		}
        private void inseriraluno(object sender, EventArgs args)
        {
            Detail = new inseriraluno(); 
            
        }
        private void excluiraluno(object sender, EventArgs args)
        {
            Detail = new excluiraluno();

        }
        private void vermsgpais(object sender, EventArgs args)
        {
            Detail = new vermsgpais();

        }
        private void mandarmsgpais(object sender, EventArgs args)
        {
            Detail = new mandarmsgpais();

        }
        private void inserirprof(object sender, EventArgs args)
        {
            Detail = new inserirprof();

        }
        private void excluirprof(object sender, EventArgs args)
        {
            Detail = new excluirprof();

        }
        

    }
}