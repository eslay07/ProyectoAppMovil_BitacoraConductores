using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoAppMovil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {

            string usuario = "1";
            string contraseña = "1";
            string tUsuario = txtUsuario.Text;
            string tContraseña = txtContraseña.Text;
            if (usuario == tUsuario & contraseña == tContraseña)
            {
                DisplayAlert("Bitacora para Conductores", "Bienvenido" + usuario, "Cerrar");
                Navigation.PushAsync(new Menu());
            }
            else
            {
                DisplayAlert("Alerta", "Usuario No existe!!", "Cerrar");
            }


        }
    }
}
