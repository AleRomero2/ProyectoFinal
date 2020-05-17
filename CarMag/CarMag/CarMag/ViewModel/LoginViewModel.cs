using CarMag.Service;
using CarMag.View;
using CarMag.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarMag.ViewModel
{
    public class LoginViewModel: BaseViewModel
    {
        private string _TextEmail;
        private string _TextPassword;
        private Command _LoginButtonCommand;
        public ICommand LoginButtonCommand => _LoginButtonCommand;

        private Command _RegisterButtonCommand;
        public ICommand RegisterButtonCommand => _RegisterButtonCommand;
        IHttpService peticion = new HttpService();
        public LoginViewModel(){
            _LoginButtonCommand = new Command(LoginButtonCommanAsync);
            _RegisterButtonCommand = new Command(RegisterButtonComman);
        }
        private async void LoginButtonCommanAsync()
        {
            //if (await peticion.httpAuth(TextEmail, TextPassword))
            //{
                await App.Current.MainPage.Navigation.PushAsync(new TabbedPageCarMag(peticion));
           // }
           // else
            //
                Console.WriteLine("Credenciales Erroneas");
            //
        }
        private void RegisterButtonComman()
        {
            App.Current.MainPage.Navigation.PushAsync(new RegisterView());
        }
        public string TextEmail
        {
            get { return _TextEmail; }
            set
            {
                _TextEmail = value;
                RaisePropertyChanged();
            }
        }
        public string TextPassword
        {
            get { return _TextPassword; }
            set
            {
                _TextPassword = value;
                RaisePropertyChanged();
            }
        }
    }
}
