using GalaSoft.MvvmLight;
using MVVMLight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLight.ViewModel
{
    public class MianViewModel : ViewModelBase
    {
        public MianViewModel()
        {
            mainModels = new MainModel();

            MainModels.CurrentViewModel = new AViewModel()
            {
                AModels = new AModel() { Content = "A" }
            };
            MainModels.ViewModelsCollection.Add(MainModels.CurrentViewModel);
            MainModels.CurrentViewModel = new AViewModel()
            {
                AModels = new AModel() { Content = "As" }
            };
            MainModels.ViewModelsCollection.Add(MainModels.CurrentViewModel);
            MainModels.CurrentViewModel = new BViewModel()
            {
                BModels = new BModel() { Content = "B" }
            };
            MainModels.ViewModelsCollection.Add(MainModels.CurrentViewModel);
            MainModels.CurrentViewModel = new BViewModel()
            {
                BModels = new BModel() { Content = "Bs" }
            };
            MainModels.ViewModelsCollection.Add(MainModels.CurrentViewModel);
            MainModels.CurrentViewModel = new CViewModel()
            {
                CModels = new CModel() { Content = "C" }
            };
            MainModels.ViewModelsCollection.Add(MainModels.CurrentViewModel);
            MainModels.CurrentViewModel = new CViewModel()
            {
                CModels = new CModel() { Content = "Cs" }
            };
            MainModels.ViewModelsCollection.Add(MainModels.CurrentViewModel);
        }

        private MainModel mainModels;
        public MainModel MainModels
        {
            get { return mainModels; }
            set
            {
                mainModels = value; RaisePropertyChanged(() => MainModels);
            }
        }
    }
}
