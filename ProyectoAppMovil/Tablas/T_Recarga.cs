using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProyectoAppMovil.Tablas
{
    public class T_Recarga
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Recarga { get; set; }
        [MaxLength(255)]
        public DateTime Fecha_Recarga { get; set; }
        [MaxLength(255)]
        public string ticket_Recarga { get; set; }
        [MaxLength(255)]
        public string galones_Recarga { get; set; }
        [MaxLength(255)]
        public string valor_Recarga { get; set; }
        [MaxLength(255)]
        public string kilometraje_Recarga { get; set; }
        [MaxLength(255)]
        public string estacion_Recarga { get; set; }


    }
}
