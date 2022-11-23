using SQLite;
using System.IO;
using SQLiteAgenda.Droid;
using SQLiteAgenda.Datos;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDB))]
namespace SQLiteAgenda.Droid
{
    public class SQLiteDB : ISQLiteDB
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            // Se crea la base de datos
            var path = Path.Combine(ruta, "BitacoraSQLite.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}