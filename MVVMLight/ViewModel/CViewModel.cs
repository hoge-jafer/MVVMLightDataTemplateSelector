using GalaSoft.MvvmLight;
using MVVMLight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLight.ViewModel
{
   public class CViewModel : ViewModelBase
    {
        public CViewModel()
        {
            cmodels = new CModel();
        }
        private CModel cmodels;
        public CModel CModels
        {
            get { return cmodels; }
            set
            {
                cmodels = value; RaisePropertyChanged(() => CModels);
            }
        }
    }
}
