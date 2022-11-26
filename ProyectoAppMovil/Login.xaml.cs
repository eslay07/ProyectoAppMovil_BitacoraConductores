using ProyectoAppMovil.Tablas;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
            
                        string usuario = "jotoapanta";
                        string contraseña = "123";
                        string tUsuario = txtUsuario.Text;
                        string tContraseña = txtContraseña.Text;
                        if (usuario == tUsuario & contraseña == tContraseña)
                        {
                            DisplayAlert("Bitacora para Conductores", "Bienvenido " + usuario, "Cerrar");
                            Navigation.PushAsync(new Menu());
                        }
                        else
                        {
                            DisplayAlert("Alerta", "Usuario No existe!!", "Cerrar");
                        }

                  
            }
           

        }

       
    }

