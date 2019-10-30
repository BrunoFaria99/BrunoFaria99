using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppHC3.Classes;

namespace AppHC3.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaAvaliacao : ContentPage
    {
        public TelaAvaliacao()
        {
            InitializeComponent();
         // this.BindingContext = new Ratingg2();
            this.BindingContext = new Ratingg();
            
        }              
    }
}