using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHC3.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuAgendamentos : MasterDetailPage
    {
        public MenuAgendamentos()
        {
            InitializeComponent();
        }
        private void EntrarTelaPerfil(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Telas.TelaPerfil());
            IsPresented = false;
        }

        private void EntrarAvaliacao(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new TelaAvaliacao());
            IsPresented = false;
        }
    }
}