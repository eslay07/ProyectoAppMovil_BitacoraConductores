using ProyectoAppMovil.Cl;
using ProyectoAppMovil.Tablas;
using SQLite;
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
    public partial class Registros : ContentPage
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            try
            {
                var rutaDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BitacoraSQLite.db3");
                var db = new SQLiteConnection(rutaDB);
                db.CreateTable<T_Conductor>();

                Navigation.PushAsync(new Registro_Asignacion());

            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnRecarga_Clicked(object sender, EventArgs e)
        {

            try
            {
                var rutaDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BitacoraSQLite.db3");
                var db = new SQLiteConnection(rutaDB);
                db.CreateTable<T_Recarga>();

                Navigation.PushAsync(new Registro_Recargaxaml());

            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnHoja_Clicked(object sender, EventArgs e)
        {
            try
            {
                var rutaDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BitacoraSQLite.db3");
                var db = new SQLiteConnection(rutaDB);
                db.CreateTable<T_Actividad>();

                Navigation.PushAsync(new Registro_Actividad());

            }
            catch (Exception)
            {
                throw;
            }


        }

        private void btnIncidente_Clicked(object sender, EventArgs e)
        {

        }
    }
}