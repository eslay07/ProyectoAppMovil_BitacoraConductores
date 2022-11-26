
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAppMovil.Tablas
{
    internal class LoginHelpers
    {
        //debo agregar este using using S7Toapantanta.models;
        public static IEnumerable<Empleado> SELECT_WHERE(SQLiteConnection db, string usuario, string contraseña)
        {
            return db.Query<Empleado>("SELECT * FROM Empleado where usuario=? and contraseña=?", usuario, contraseña);
        }
    }
}
