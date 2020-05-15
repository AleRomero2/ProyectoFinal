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
    class RegisterViewModel : BaseViewModel
    {
        private string _TextUser;
        private string _TextPsw;
        private string _TextEmail;
        private string _TextConsumo;
        private string _TextCarburante;
        private Command _RegistButtonCommand;
        public ICommand RegistButtonCommand => _RegistButtonCommand;
        IHttpService peticion = new HttpService();
        public RegisterViewModel()
        {
            _RegistButtonCommand = new Command(RegistButtonComman);
        }
        private void RegistButtonComman()
        {
            peticion.httpRegister(TextUser, TextEmail, TextPsw, TextConsumo, TextCarburante);
            App.Current.MainPage.Navigation.PushAsync(new LoginView());
        }
        public string TextUser
        {
            get { return _TextUser; }
            set
            {
                _TextUser = value;
                RaisePropertyChanged();

            }
        }
        public string TextPsw
        {
            get { return _TextPsw; }
            set
            {
                _TextPsw = value;
                RaisePropertyChanged();

            }
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
        public string TextConsumo
        {
            get { return _TextConsumo; }
            set
            {
                _TextConsumo = value;
                RaisePropertyChanged();

            }
        }
        public string TextCarburante
        {
            get { return _TextCarburante; }
            set
            {
                _TextCarburante = value;
                RaisePropertyChanged();

            }
        }
    }
}
