using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLight.Model
{
    public class MainModel : ObservableObject
    {
        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                currentViewModel = value;
                RaisePropertyChanged(() => CurrentViewModel);
            }
        }

        private ViewModelBase selectedViewModel;

        public ViewModelBase SelectedViewModel
        {
            get { return selectedViewModel; }
            set
            {
                selectedViewModel = value;
                RaisePropertyChanged(() => SelectedViewModel);
            }
        }


        private ObservableCollection<ViewModelBase> viewModelsCollection = new ObservableCollection<ViewModelBase>();
        public ObservableCollection<ViewModelBase> ViewModelsCollection
        {
            get { return viewModelsCollection; }
            set
            {
                viewModelsCollection = value;
                RaisePropertyChanged(() => ViewModelsCollection);
            }
        }
    }
}
