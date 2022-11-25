using ProyectoAppMovil.Tablas;
using SQLite;
using SQLiteAgenda.Datos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoAppMovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalle_Actividad : ContentPage
    {
        public int IdSeleccionado;
        public TimeSpan horaSaSeleccionado, horalleSeleccionado;
        public DateTime fechSeleccionado;
        public string nomSeleccionado, logSeleccionado,  desSeleccionado ;
        private SQLiteAsyncConnection conexion;
        IEnumerable<T_Actividad> ResultadoDelete;
        IEnumerable<T_Actividad> ResultadoUpdate;
        public Detalle_Actividad(int ID, string nom, string log, TimeSpan horS1, TimeSpan horLl, string des,DateTime fec)
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            IdSeleccionado = ID;
            nomSeleccionado = nom;
           logSeleccionado = log;
          horaSaSeleccionado = horS1;
            horalleSeleccionado = horLl;
            desSeleccionado = des;
            fechSeleccionado = fec;



        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lblMensaje1.Text = " ID :" + IdSeleccionado;
            txtNombreA.Text = nomSeleccionado;
            txtLogin.Text = logSeleccionado;
            txtHoraSa.Time = horaSaSeleccionado;
            txtHoraLl.Time = horalleSeleccionado;
            txtDestino.Text = desSeleccionado;
            txtFecha.Date = fechSeleccionado;


        }
        
       
       
    }
}