using MVVMLight.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVVMLight.Selector
{
   public class TemplateSelectors : DataTemplateSelector
    {
        public DataTemplate ADataTemplate { get; set; }

        public DataTemplate BDataTemplate { get; set; }

        public DataTemplate CDataTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (container is FrameworkElement && item != null)
            {
                if (item is AViewModel)
                    return ADataTemplate;

                if (item is BViewModel)
                    return BDataTemplate;

                if (item is CViewModel)
                    return CDataTemplate;

                else return null;
            }
            return null;
        }
    }
}
