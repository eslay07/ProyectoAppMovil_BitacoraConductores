using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAppMovil.Cl
{
    public class T_Conductor
    {
    [PrimaryKey, AutoIncrement]
    public int Id_Conductor { get; set; }
        [MaxLength(255)]
        public string codigo { get; set; }
        [MaxLength(255)]
        public string nombre { get; set; }
        [MaxLength(255)]
        public string apellido { get; set; }
        
        public String edad { get; set; }
        [MaxLength(255)]
        public string cedula { get; set; }
        [MaxLength(255)]
        public string num_licencia { get; set; }
        [MaxLength(255)]
        public string tipo_sangre { get; set; }

    }
}
