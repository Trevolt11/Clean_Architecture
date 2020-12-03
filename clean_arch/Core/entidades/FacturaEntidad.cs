using System;
using System.Collections.Generic;
using System.Text;

namespace Core.entidades
{
    public partial class FacturaEntidad : BaseEntidad
    {
       
        public int Idfactura { get; set; }
        public string matricula { get; set; }
        public int Idcliente { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        

        public virtual VehiculoEntidad Vehiculo { get; set; }
        public virtual ClienteEntidad cliente { get; set; }
    }

}
