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
            _LoginButtonCommand = new Command(LoginButtonComman);
            _RegisterButtonCommand = new Command(RegisterButtonComman);
        }
        private void LoginButtonComman()
        {
            App.Current.MainPage.Navigation.PushAsync(new TabbedPageCarMag());
        }
        private void RegisterButtonComman()
        {
            App.Current.MainPage.Navigation.PushAsync(new RegisterView());
        }
    }
}
