using CarMag.Model;
using CarMag.Service;
using CarMag.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarMag.ViewModel
{
    class MantenimientoViewModel:BaseViewModel
    {
        string _TextOdometro;
        string _TextTipoServicio;
        string _TextLocalizacion;
        string _TextCuantia;
        private Command _MantenimientoButtonCommand;
        public ICommand MantenimientoButtonCommand => _MantenimientoButtonCommand;

        Cliente clienteLo = new Cliente();
        CacheService cache = new CacheService();
        public MantenimientoViewModel()
        {
            _MantenimientoButtonCommand = new Command(MantenimientoButtonComman);
            List<Cliente> lista = cache.GetAsync<Cliente>();
            clienteLo = lista[0];
        }

        private void MantenimientoButtonComman(object obj)
        {
            throw new NotImplementedException();
        }



        public string TextCuantia
        {
            get { return _TextCuantia; }
            set
            {
                _TextCuantia = value;
                RaisePropertyChanged();
            }
        }
        public string TextOdometro
        {
            get { return _TextOdometro; }
            set
            {
                _TextOdometro = value;
                RaisePropertyChanged();
            }
        }
        public string TextTipoServicio
        {
            get { return _TextTipoServicio; }
            set
            {
                _TextTipoServicio = value;
                RaisePropertyChanged();
            }
        }
        public string TextLocalizacion
        {
            get { return _TextLocalizacion; }
            set
            {
                _TextLocalizacion = value;
                RaisePropertyChanged();
            }
        }

    }
}
