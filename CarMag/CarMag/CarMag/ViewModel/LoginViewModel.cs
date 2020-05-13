using CarMag.Service;
using CarMag.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarMag.ViewModel
{
    public class LoginViewModel
    {
        private Command _LoginButtonCommand;
        public ICommand LoginButtonCommand => _LoginButtonCommand;

        private Command _RegisterButtonCommand;
        public ICommand RegisterButtonCommand => _RegisterButtonCommand;
        public LoginViewModel(){
            _LoginButtonCommand = new Command(LoginButtonCommanAsync);
            _RegisterButtonCommand = new Command(RegisterButtonComman);
        }
        private async void LoginButtonCommanAsync()
        {
            if (await HttpService.httpAuth("ale@gmail.com", "123"))
            {
                await App.Current.MainPage.Navigation.PushAsync(new TabbedPageCarMag());
            }
            else
            {
                Console.WriteLine("Credenciales Erroneas");
            }
        }
        private void RegisterButtonComman()
        {
            App.Current.MainPage.Navigation.PushAsync(new RegisterView());
        }
    }
}
