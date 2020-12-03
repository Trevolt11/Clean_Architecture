using Core.entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.interfaces
{
    public interface InterfaceVehiculoRepositorio
    {
        Task<IEnumerable<ClienteEntidad>> GetVehiculos();
    }
}
