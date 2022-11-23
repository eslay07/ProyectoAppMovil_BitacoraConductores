using ProyectoAppMovil.Cl;
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
    }
}