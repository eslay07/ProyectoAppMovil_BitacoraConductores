using ProyectoAppMovil.Cl;
using ProyectoAppMovil.Tablas;
using SQLite;
using SQLiteAgenda.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoAppMovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro_Recargaxaml : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        private ObservableCollection<T_Recarga> TablaRecarga;
        public Registro_Recargaxaml()
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            ListaRecargas.ItemSelected += ListaRecarga_ItemSelected;


        }

        private void ListaRecarga_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            var Obj = (T_Recarga)e.SelectedItem;
            var item = Obj.Id_Recarga.ToString();
            var fech = Obj.Fecha_Recarga.ToString();
            var tik = Obj.ticket_Recarga;
            var ga = Obj.galones_Recarga ;
            var va = Obj.valor_Recarga;
            var ki = Obj.kilometraje_Recarga;
            var es = Obj.estacion_Recarga;

            int ID = Convert.ToInt32(item);
            DateTime fech1= Convert.ToDateTime(fech);


            try
            {
                Navigation.PushAsync(new Detalle_Recarga(ID, fech1, tik, ga, va, ki, es));

            }
            catch (Exception)
            {
                throw;
            }
        }

        protected async override void OnAppearing()
        {
            var ResulRegistros = await conexion.Table<T_Recarga>().ToListAsync();
            TablaRecarga = new ObservableCollection<T_Recarga>(ResulRegistros);
            ListaRecargas.ItemsSource = TablaRecarga;
            base.OnAppearing();
        }
    }
}