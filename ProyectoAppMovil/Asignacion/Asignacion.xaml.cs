using ProyectoAppMovil.Cl;
using ProyectoAppMovil.Clases;
using SQLite;
using SQLiteAgenda.Datos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoAppMovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Asignacion : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        public Asignacion()
        {
            InitializeComponent();

            conexion = DependencyService.Get<ISQLiteDB>().GetConnection(); 
            btnGuardar2.Clicked += btnGuardar2_Clicked;

        }

        private void btnBuscar_Clicked(object sender, EventArgs e)
        {

        }
        private void limpiarFormulario()
        {
            txtCodigo.Text = "";
               txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtCedula.Text = "";
            txtNum_Licencia.Text= "";
            txtTip_Sangre.Text = "";
        }
        private void limpiarFormulario1()
        {

            txtNumVehiculo.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtEstado.Text = "";

        }
        private void btnGuardar2_Clicked(object sender, EventArgs e)
        {

            var DatosVehiculo = new T_Vehiculo
            {
                Numero_Vehiculo =txtNumVehiculo.Text,
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