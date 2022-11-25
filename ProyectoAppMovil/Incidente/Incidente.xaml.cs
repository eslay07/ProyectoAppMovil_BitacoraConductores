using ProyectoAppMovil.Tablas;
using SQLite;
using SQLiteAgenda.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoAppMovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Incidente : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        public Incidente()
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            btnGuardar2.Clicked += btnGuardar2_Clicked;
            BindingContext = new FotoViewModel();

        }

        private void btnGuardar2_Clicked(object sender, EventArgs e)
        {
            var DatosIncidente = new T_Incidente
            {

                descripcion = txtDescripcion.Text

            };

           

        }

        private void btnCamara_Clicked(object sender, EventArgs e)
        {

        }
        private void limpiarFormulario()
        {

            txtDescripcion.Text = "";
        }
    }
}