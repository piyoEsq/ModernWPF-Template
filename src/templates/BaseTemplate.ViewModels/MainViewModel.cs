using System.ComponentModel;
using Prism.Logging;
using Prism.Mvvm;

namespace BaseTemplate.ViewModels
{
    public class MainViewModel : BindableBase, INotifyPropertyChanged
    {
        public MainViewModel(ILoggerFacade logger)
        {
            logger.Log($"{nameof(MainViewModel)} Called", Category.Info, Priority.Medium);
        }
    }
}