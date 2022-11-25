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
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {


           

        }

        private void btnAsignacion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Asignacion());

        }

        private void btnRecarga_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recarga());

        }

        private void btnHoja_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Hoja());
        }

        private void btnIncidente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Incidente());

        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registros());

        }
    }
}