using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppUtilidades.Views.Generic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UcItemView : ContentView
    {
        public UcItemView()
        {
            InitializeComponent();
            BindingContext = new UcItemViewModel();

        }
    }
}