using ProyectoAppMovil.Cl;
using ProyectoAppMovil.Tablas;
using SQLite;
using SQLiteAgenda.Datos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoAppMovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalle_Recarga : ContentPage
    {
        public int IdSeleccionado;
        public DateTime fechSeleccionado;
        public string tickSeleccionado, galSeleccionado, valSeleccionado, kiloSeleccionado, estSeleccionado;
        private SQLiteAsyncConnection conexion;
        IEnumerable<T_Recarga> ResultadoDelete;
        IEnumerable<T_Recarga> ResultadoUpdate;


        public Detalle_Recarga(int ID, DateTime fech1, string tik, string ga, string va, string ki, string es)
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            IdSeleccionado = ID;
            fechSeleccionado = fech1;
            tickSeleccionado = tik;
            galSeleccionado = ga;
            valSeleccionado = va;
            kiloSeleccionado = ki;
            estSeleccionado = es;

            btn_actualizar.Clicked += btn_actualizar_Clicked;
            btn_eliminar.Clicked += btn_eliminar_Clicked;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lblMensaje.Text = " ID :" + IdSeleccionado;
            txtFechaR.Date = fechSeleccionado;
            txtTicketR.Text = tickSeleccionado;
            txtGalonesR.Text = galSeleccionado;
            txtValorR.Text = valSeleccionado;
            txtKilometrajeR.Text = kiloSeleccionado;
            txtEstacionR.Text = estSeleccionado;


        }

        private void btn_actualizar_Clicked(object sender, EventArgs e)
        {
            var rutadb = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BitacoraSQLite.db3");
            var db = new SQLiteConnection(rutadb);
            ResultadoUpdate = Update(db, txtFechaR.Date, txtTicketR.Text, txtGalonesR.Text, txtValorR.Text, txtKilometrajeR.Text, txtEstacionR.Text, IdSeleccionado);
            DisplayAlert("Confirmación", "El Registro de la recarga se actualizo correctamente", "OK");
            Navigation.PushAsync(new Registro_Recargaxaml());


        }

        private void btn_eliminar_Clicked(object sender, EventArgs e)
        {
            var rutaDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BitacoraSQLite.db3");
            var db = new SQLiteConnection(rutaDB);
            ResultadoDelete = Delete(db, IdSeleccionado);
            DisplayAlert("Confirmación", "El Registro de recarga se eliminó correctamente", "OK");
            Limpiar();
            Navigation.PushAsync(new Registro_Recargaxaml());
        }

        public static IEnumerable<T_Recarga> Delete(SQLiteConnection db, int ID)
        {
            return db.Query<T_Recarga>("Delete FROM T_RECARGA WHERE Id_Recarga = ?", ID);
        }
        public static IEnumerable<T_Recarga> Update(SQLiteConnection db, DateTime Fecha_Recarga, string ticket_Recarga, string egalones_Recarga, string valor_Recarga, string kilometraje_Recarga, string estacion_Recarga, int Id_Recarga)
        {
            return db.Query<T_Recarga>("UPDATE T_RECARGA SET Fecha_Recarga = ?, ticket_Recarga = ?, galones_Recarga = ?,valor_Recarga = ?,kilometraje_Recarga = ?,estacion_Recarga = ?  WHERE Id_Recarga =?", Fecha_Recarga, ticket_Recarga, egalones_Recarga, valor_Recarga, estacion_Recarga, kilometraje_Recarga, Id_Recarga);
        }
        public void Limpiar()
        {
            lblMensaje.Text = "";
            txtTicketR.Text = "";
            txtGalonesR.Text = "";
            txtValorR.Text = "";
            txtKilometrajeR.Text = "";
            txtEstacionR.Text = "";


        }
    }
}