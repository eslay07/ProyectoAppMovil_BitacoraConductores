using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAppMovil.Tablas
{
    public class Empleado
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string usuario { get; set; }

        [MaxLength(50)]
        public string contraseña { get; set; }


    }
}
