using CarMag.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarMag.ViewModel
{
    class RegisterViewModel
    {
        private Command _RegistButtonCommand;
        public ICommand RegistButtonCommand => _RegistButtonCommand;

        public RegisterViewModel()
        {
            _RegistButtonCommand = new Command(RegistButtonComman);
        }
        private void RegistButtonComman()
        {
            App.Current.MainPage.Navigation.PushAsync(new LoginView());
        }
    }
}
