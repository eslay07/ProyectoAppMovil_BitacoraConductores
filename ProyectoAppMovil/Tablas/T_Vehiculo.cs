using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAppMovil.Clases
{
    public class T_Vehiculo
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Vehiculo { get; set; }
        [MaxLength(255)]
        public string Numero_Vehiculo { get; set; }
        [MaxLength(255)]
        public string Modelo_Vehiculo { get; set; }
        [MaxLength(255)]
        public string Placa_Vehiculo { get; set; }
        [MaxLength(255)]
        public string Estado_Vehiculo { get; set; }


    }
}
