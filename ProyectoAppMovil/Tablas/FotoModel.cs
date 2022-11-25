using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace ProyectoAppMovil.Tablas
{
    public class FotoModel : INotifyPropertyChanged
    {
        private ImageSource fotico;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));

        }

        public ImageSource Fotico
        {
            get { return fotico; }
            set
            {
                fotico = value;
                OnPropertyChanged();
            }
        }
    }
}
