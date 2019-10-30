using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppHC3.Classes;

namespace AppHC3.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            this.BindingContext = new Ratingg();
        }
    }
}