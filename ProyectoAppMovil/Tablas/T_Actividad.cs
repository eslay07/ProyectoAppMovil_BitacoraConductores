using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAppMovil.Tablas
{
    internal class T_Actividad
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Actividad { get; set; }
        [MaxLength(255)]
        public string Nombre_Actividad { get; set; }
        [MaxLength(255)]
        public string Login_Actividad { get; set; }
        [MaxLength(255)]
        public string Hora_sal_Actividad { get; set; }
        [MaxLength(255)]
        public string Hora_lleg_Actividad { get; set; }
        [MaxLength(255)]
        public string Destino_Actividad { get; set; }
        [MaxLength(255)]
        public DateTime Fecha_Actividad { get; set; }
        [MaxLength(255)]
        public string Fibra_Utilz_Actividad { get; set; }
        [MaxLength(255)]
        public string Jefe_cuadr_Actividad { get; set; }


    }
}
