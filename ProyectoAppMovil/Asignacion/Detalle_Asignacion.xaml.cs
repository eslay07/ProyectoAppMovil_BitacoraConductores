using ProyectoAppMovil.Cl;
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
    public partial class Detalle_Asignacion : ContentPage
    {
        public int IdSeleccionado;
        public string NomSeleccionado, ApSeleccionado, edSeleccionado, cedSeleccionado, numLicSeleccionado,tipSangSeleccionado;
        private SQLiteAsyncConnection conexion;
        IEnumerable<T_Conductor> ResultadoDelete;
        IEnumerable<T_Conductor> ResultadoUpdate;
        public Detalle_Asignacion(int Id_Conductor, string nom, string ap, string ed, string ced, string numLic, string tipSang)
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            IdSeleccionado = Id_Conductor;
            NomSeleccionado = nom;
            ApSeleccionado = ap;
            edSeleccionado = ed;
            cedSeleccionado = ced;
            numLicSeleccionado = numLic;
            tipSangSeleccionado = tipSang;

            btn_actualizar.Clicked += btn_actualizar_Clicked;
            btn_eliminar.Clicked += btn_eliminar_Clicked;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lblMensaje.Text = " ID :" + IdSeleccionado;
            txtNombre.Text = NomSeleccionado;
            txtApellidos.Text = ApSeleccionado;
            txtEdad.Text = edSeleccionado;
            txtCedula.Text = cedSeleccionado;
            txtNum_Licencia.Text = numLicSeleccionado;
            txtTip_Sangre.Text = tipSangSeleccionado;


        }
        private void btn_eliminar_Clicked(object sender, EventArgs e)
        {
            var rutaDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BitacoraSQLite.db3");
            var db = new SQLiteConnection(rutaDB);
            ResultadoDelete = Delete(db, IdSeleccionado);
            DisplayAlert("Confirmación", "El Conductor se eliminó correctamente", "OK");
            Limpiar();

        }

        private void btn_actualizar_Clicked(object sender, EventArgs e)
        {
            var rutadb = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BitacoraSQLite.db3");
            var db = new SQLiteConnection(rutadb);
            ResultadoUpdate = Update(db, txtNombre.Text, txtApellidos.Text, txtEdad.Text,txtCedula.Text,txtNum_Licencia.Text,txtTip_Sangre.Text, IdSeleccionado);
            DisplayAlert("Confirmación", "Conductor se acualizó correctamente", "OK");

        }
        public static IEnumerable<T_Conductor> Delete(SQLiteConnection db, int id_Conductor)
        {
            return db.Query<T_Conductor>("Delete FROM T_CONDUCTOR WHERE Id_Conductor = ?", id_Conductor);
        }
        public static IEnumerable<T_Conductor> Update(SQLiteConnection db, string nombre, string apellido, string edad, string cedula, string num_licencia, string tipo_sangre, int Id_Conductor)
        {
            return db.Query<T_Conductor>("UPDATE T_CONDUCTOR SET nombre = ?, apellido = ?, edad = ?,cedula = ?,Num_licencia = ?,Tipo_Sangre = ?  WHERE Id_Conductor =?", nombre, apellido, edad, cedula, num_licencia,tipo_sangre, Id_Conductor);
        }
        public void Limpiar()
        {
            lblMensaje.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
            txtCedula.Text = "";
            txtNum_Licencia.Text = "";
            txtTip_Sangre.Text = "";
        }



    }
}