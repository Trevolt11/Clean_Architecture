using System;
using System.Collections.Generic;
using System.Text;
using Core.entidades;

namespace Core.entidades
{
    public partial class ClienteEntidad : BaseEntidad
    {
        public ClienteEntidad()
        {
            Facturas = new HashSet<FacturaEntidad>();
            Vehiculos = new HashSet<VehiculoEntidad>();
        }

        public int Idcliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fechaingreso { get; set; }
        public string Telefono { get; set; }
       

        public virtual ICollection<FacturaEntidad> Facturas { get; set; }
        public virtual ICollection<VehiculoEntidad> Vehiculos { get; set; }
    }
}
