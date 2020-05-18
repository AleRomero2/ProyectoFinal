using CarMag.Model;
using CarMag.Service;
using CarMag.ViewModel.Base;
using Java.Sql;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarMag.ViewModel
{
    class GastoViewModel: BaseViewModel
    {
        List<Gasto> Lgasto = new List<Gasto>();
        string _TextTitulo;
        string _TextGasto;
        string _TextMotivo;
        string _TextCuantia;
        private Command _GastoButtonCommand;
        public ICommand GastoButtonCommand => _GastoButtonCommand;
        IHttpService peticion = new HttpService();
        Cliente logeado = new Cliente();
        CacheService cache = new CacheService();
        public GastoViewModel()
        {
            _GastoButtonCommand = new Command(GastoButtonComman);
            List<Cliente>lista=cache.GetAsync<Cliente>();
            logeado = lista[0];
        }
        public IHttpService _prueba = new HttpService();
        public IHttpService Prueba
        {
            get { return _prueba; }
            set
            {
                _prueba = value;
                RaisePropertyChanged();
            }
        }

        private void GastoButtonComman(object obj)
        {
            peticion.httpAddGasto(1, TextTitulo, TextGasto, TextMotivo,TextCuantia,logeado);
        }

        public string TextTitulo
        {
            get { return _TextTitulo; }
            set
            {
                _TextTitulo = value;
                RaisePropertyChanged();
            }
        }

        public string TextGasto
        {
            get { return _TextGasto; }
            set
            {
                _TextGasto = value;
                RaisePropertyChanged();
            }
        }
        /*public string DatePicker
        {
            get { return _DatePicker; }
            set
            {
                _DatePicker = ;
                RaisePropertyChanged();
            }
        }*/
        public string TextMotivo
        {
            get { return _TextMotivo; }
            set
            {
                _TextMotivo = value;
                RaisePropertyChanged();
            }
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
    }
}
