using ProyectoAppMovil.Cl;
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
    public partial class Hoja : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        public Hoja()
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            btnGuardar1.Clicked += btnGuardar1_Clicked;


        }

        private void btnGuardar1_Clicked(object sender, EventArgs e)
        {
            var DatosActividad = new T_Actividad
            {
 
                Nombre_Actividad = txtNombreA.Text,
                Login_Actividad = txtLoginA.Text,
                Hora_sal_Actividad = txtHoraSalA.Time,
            Hora_lleg_Actividad = txtHoraLLeA.Time,
                Destino_Actividad = txtDestino.Text,
                Fecha_Actividad = txtFechaA.Date

            };
            conexion.InsertAsync(DatosActividad);       
            limpiarFormulario();
         
            DisplayAlert("Confirmación", "Se agrego el registro a la Hoja de Ruta correctamente", "OK");

        }

        private void limpiarFormulario()
        {

            txtNombreA.Text = "";
            txtLoginA.Text = "";
            txtDestino.Text = "";
          

        }

        private void txtNombreA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}