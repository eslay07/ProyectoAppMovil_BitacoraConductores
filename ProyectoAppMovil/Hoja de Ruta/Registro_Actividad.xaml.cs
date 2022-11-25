using ProyectoAppMovil.Tablas;
using SQLite;
using SQLiteAgenda.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoAppMovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro_Actividad : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        private ObservableCollection<T_Actividad> TablaActividad;
        public Registro_Actividad()
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            ListaActividades.ItemSelected += ListaActividad_ItemSelected;
        }
        private void ListaActividad_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            var Obj = (T_Actividad)e.SelectedItem;
            var item = Obj.Id_Actividad.ToString();
            var nom = Obj.Nombre_Actividad;
            var log = Obj.Login_Actividad;
            var horS = Obj.Hora_sal_Actividad;
            var horLl = Obj.Hora_lleg_Actividad;
            var des = Obj.Destino_Actividad;
            var fec = Obj.Fecha_Actividad;

            int ID = Convert.ToInt32(item);
            //TimeSpan horS1 = Convert.ToDateTime(horS);
           // TimeSpan horLl1 = Convert.ToDateTime(horLl);

            try
            {
                Navigation.PushAsync(new Detalle_Actividad(ID, nom, log, horS, horLl, des, fec));

            }
            catch (Exception)
            {
                throw;
            }
        }

        protected async override void OnAppearing()
        {
            var ResulRegistros = await conexion.Table<T_Actividad>().ToListAsync();
            TablaActividad = new ObservableCollection<T_Actividad>(ResulRegistros);
            ListaActividades.ItemsSource = TablaActividad;
            base.OnAppearing();
        }


    }
}