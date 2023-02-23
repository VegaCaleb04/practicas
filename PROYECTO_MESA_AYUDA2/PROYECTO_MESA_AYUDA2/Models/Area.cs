using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_MESA_AYUDA2.Models
{
    public class Area
    {
        String idArea;
        String nombre;
        String fkEmple;

        public Area(string idArea, string nombre, string fkEmple)
        {
            this.IdArea = idArea;
            this.Nombre = nombre;
            this.FkEmple = fkEmple;
        }

        public string IdArea {
            get => idArea;
            set => idArea = value;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FkEmple { get => fkEmple; set => fkEmple = value; }
    }
}