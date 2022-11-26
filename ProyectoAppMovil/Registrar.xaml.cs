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
    public partial class Registrar : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        public Registrar()
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
        }

        /*private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var datosRegistro = new Empleado { Nombre  = , usuario = txtUsuario.Text, contraseña = txtContraseña.Text };
                conexion.InsertAsync(datosRegistro);

                DisplayAlert("Mensaje", "Ingreso Correcto", "cerrar");

                txtUsuario.Text = "";
                txtNombre.Text = "";
                txtContraseña.Text = "";


            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje", ex.Message, "cerrar");
            }
        }
        */
        private void btnSalir_Clicked(object sender, EventArgs e)
        {

        }
    }
}