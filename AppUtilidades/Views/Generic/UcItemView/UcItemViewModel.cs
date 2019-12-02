using AppUtilidades.ViewModels;
using Xamarin.Forms;

namespace AppUtilidades.Views.Generic
{
    public class UcItemViewModel : BaseViewModel
    {
        UcItemViewBo _registro=null;
        public UcItemViewBo Registro
        {
            get { return _registro; }
            set { SetProperty(ref _registro, value); }
        }

        public UcItemViewModel()
        {
            MessagingCenter.Subscribe<UcItemViewBo>(this, "true", (resultado) =>
            {
                Registro = resultado;
                if (resultado.EfectuoAccion)
                {
                    if (string.IsNullOrEmpty(Registro.Descripcion))
                    {
                        //acccion a realizar
                    }
                        
                }
            });
        }
        
    }
}
