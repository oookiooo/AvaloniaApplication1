﻿using System.Windows.Input;
using ReactiveUI;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using AvaloniaApplication1.WebApiConnector;
namespace AvaloniaApplication1.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly UserWebApi _userWebApi = new UserWebApi();
        public string Greeting => "Welcome to Avalonia!";
        private ICommand _sendToApi;
        public ICommand SendToApi {  
            get
            {
                if (_sendToApi == null)
                {
                    _sendToApi = new RelayCommand(FilterCheckedExecute);
                }
                return _sendToApi;
            }
        }
        public MainWindowViewModel()
        {

        }
        private async void FilterCheckedExecute()
        {
            await _userWebApi.GetUserAsync(Login, Haslo);
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
