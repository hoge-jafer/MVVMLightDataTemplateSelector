/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MVVMLight"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace MVVMLight.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MianViewModel>();
            SimpleIoc.Default.Register<AViewModel>();
            SimpleIoc.Default.Register<BViewModel>();
            SimpleIoc.Default.Register<CViewModel>();

        }

        public MianViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MianViewModel>();
            }
        }

        public AViewModel A
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AViewModel>();
            }
        }

        public BViewModel B
        {
            get
            {
                return ServiceLocator.Current.GetInstance<BViewModel>();
            }
        }

        public CViewModel C
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}