using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAppMovil.Tablas
{
    internal class T_Recarga
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Recarga { get; set; }
        [MaxLength(255)]
        public DateTime Fecha_Recarga { get; set; }
        [MaxLength(255)]
        public int ticket_Recarga { get; set; }
        [MaxLength(255)]
        public float galones_Recarga { get; set; }
        [MaxLength(255)]
        public float valor_Recarga { get; set; }
        [MaxLength(255)]
        public string kilometraje_Recarga { get; set; }
        [MaxLength(255)]
        public string estacion_Recarga { get; set; }


    }
}
