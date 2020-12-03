using System;
using System.Collections.Generic;

namespace Core.entidades
{
    public partial class VehiculoEntidad
    {
        public VehiculoEntidad()
        {
            Facturas = new HashSet<FacturaEntidad>();
        }

        public string matricula { get; set; }

        public int Idcliente { get; set; }

        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        public virtual ClienteEntidad IdFacCliente{ get; set; }
        public virtual ICollection<FacturaEntidad> Facturas { get; set; }
    }
}
