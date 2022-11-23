using ProyectoAppMovil.Cl;
using ProyectoAppMovil.Clases;
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
    public partial class Registro_Asignacion : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        private ObservableCollection<T_Conductor> TablaConductor;
        public Registro_Asignacion()
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            ListaConductores.ItemSelected += ListaConductor_ItemSelected;
        }
        private void ListaConductor_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            var Obj = (T_Conductor)e.SelectedItem;
            var item = Obj.Id_Conductor.ToString();
            var cod = Obj.codigo;
            var nom = Obj.nombre;
            var ap = Obj.apellido;
            var ed = Obj.edad;
            var ced = Obj.cedula;
            var numLic = Obj.num_licencia;
            var tipSang = Obj.tipo_sangre;


            int ID = Convert.ToInt32(item);


            try
            {
                Navigation.PushAsync(new Detalle_Asignacion(ID,nom,ap,ed,ced,numLic,tipSang));

            }
            catch (Exception)
            {
                throw;
            }
        }

        protected async override void OnAppearing()
        {
            var ResulRegistros = await conexion.Table<T_Conductor>().ToListAsync();
            TablaConductor = new ObservableCollection<T_Conductor>(ResulRegistros);
            ListaConductores.ItemsSource = TablaConductor;
            base.OnAppearing();
        }



    }
}