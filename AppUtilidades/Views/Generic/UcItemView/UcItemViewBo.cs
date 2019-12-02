using AppUtilidades.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AppUtilidades.Views.Generic
{
    public class UcItemViewBo : BaseViewModel
    {
        bool _efectuoAccion = false;
        public bool EfectuoAccion
        {
            get { return _efectuoAccion; }
            set { SetProperty(ref _efectuoAccion, value); }
        }

        string _descripcion = string.Empty;
        public string Descripcion
        {
            get { return _descripcion; }
            set { SetProperty(ref _descripcion, value); }
        }

        public ICommand AccionOperacion { get; }


    }
}
