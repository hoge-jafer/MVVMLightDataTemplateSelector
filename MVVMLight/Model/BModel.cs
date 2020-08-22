using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLight.Model
{
    public class BModel : ObservableObject
    {
        private String content;

        public String Content
        {
            get { return content; }
            set
            {
                content = value;
                RaisePropertyChanged(() => Content);
            }
        }
    }
}
