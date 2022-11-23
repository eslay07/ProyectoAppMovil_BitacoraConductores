using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAppMovil.Tablas
{
    internal class T_Incidente
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Incidente { get; set; }
        [MaxLength(255)]
        public string descripcion { get; set; }

    }
}
