using GalaSoft.MvvmLight;
using MVVMLight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLight.ViewModel
{
   public class BViewModel : ViewModelBase
    {
        public BViewModel()
        {
            bmodels = new BModel();
        }
        private BModel bmodels;
        public BModel BModels
        {
            get { return bmodels; }
            set
            {
                bmodels = value; RaisePropertyChanged(() => BModels);
            }
        }
    }
}
