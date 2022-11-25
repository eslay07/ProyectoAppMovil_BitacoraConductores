using ProyectoAppMovil.Cl;
using ProyectoAppMovil.Clases;
using ProyectoAppMovil.Tablas;
using SQLite;
using SQLiteAgenda.Datos;
using System;
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
           
        }

        private void btnGuardarq_Clicked(object sender, EventArgs e)
        {
            var DatosRecarga = new T_Recarga
            {
                Fecha_Recarga = txtFechaR.Date,
                ticket_Recarga= txtTicketR.Text,
                galones_Recarga= txtGalonesR.Text + " Galones",
                valor_Recarga= txtValorR.Text + "$$",
                kilometraje_Recarga=txtKilometrajeR.Text + " Km",
                estacion_Recarga=txtEstacionR.Text

            };  
            conexion.InsertAsync(DatosRecarga);
           
             DisplayAlert("Confirmación", "La Recarga se registró correctamente", "OK");
            limpiarFormulario();
        }
        private void limpiarFormulario()
        {
            txtTicketR.Text = "";
            txtGalonesR.Text = "";
            txtValorR.Text = "";
            txtKilometrajeR.Text = "";
            txtEstacionR.Text = "";
           
        }
    }
}