using System.Windows.Input;
using ReactiveUI;
using System.Windows.Input;
namespace AvaloniaApplication1.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        public string Greeting => "Welcome to Avalonia!";
        public ICommand SendToApi { get; }
#pragma warning restore CA1822 // Mark members as static
        public MainWindowViewModel()
        {
            SendToApi = ReactiveCommand.Create(() =>
            {
                var arek = "test";
            });
        }
        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                if (value != _login)
                {
                    _login = value;
                    OnPropertyChanged(nameof(Login));
                }
            }
        }
        private string _haslo;
        public string Haslo
        {
            get { return _haslo; }
            set
            {
                if (value != _haslo)
                {
                    _haslo = value;
                    OnPropertyChanged(nameof(Haslo));
                }
            }
        }

    }
}
