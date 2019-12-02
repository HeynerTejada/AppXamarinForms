using AppUtilidades.Views.Generic;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AppUtilidades.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        UcItemViewBo _registro = null;
        public UcItemViewBo Registro
        {
            get { return _registro; }
            set { SetProperty(ref _registro, value); }
        }


        public AboutViewModel()
        {
            Title = "About";
            Registro = new UcItemViewBo();
            Registro.Descripcion = "El ejemplo debe funcionar";
            
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}