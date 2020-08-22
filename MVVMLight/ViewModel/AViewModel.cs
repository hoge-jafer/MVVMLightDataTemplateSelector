using GalaSoft.MvvmLight;
using MVVMLight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLight.ViewModel
{
   public class AViewModel:ViewModelBase
    {
        public AViewModel()
        {
            amodels = new AModel();
        }

        private AModel amodels;
        public AModel AModels
        {
            get { return amodels; }
            set
            {
                amodels = value; RaisePropertyChanged(() => AModels);
            }
        }
    }
}
