using ProyectoAppMovil.Cl;
using ProyectoAppMovil.Clases;
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
    public partial class Recarga : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        public Recarga()
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            btnGuardar.Clicked += btnGuardar_Clicked;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            var DatosRecarga = new T_Recarga
            {
                //asignar todos los parametros para recarga
                Numero_Vehiculo = txtNumVehiculo.Text,
                Modelo_Vehiculo = txtModelo.Text,
                Placa_Vehiculo = txtPlaca.Text,
                Estado_Vehiculo = txtEstado.Text

            };

            var DatosConductor = new T_Conductor
            {
                codigo = txtCodigo.Text,
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                edad = txtEdad.Text,
                cedula = txtCedula.Text,
                num_licencia = txtNum_Licencia.Text,
                tipo_sangre = txtTip_Sangre.Text

            };
            conexion.InsertAsync(DatosConductor);
            conexion.InsertAsync(DatosVehiculo);
            limpiarFormulario();
            limpiarFormulario1();
            DisplayAlert("Confirmación", "El Conductor se registró correctamente", "OK");



        }
    }
}