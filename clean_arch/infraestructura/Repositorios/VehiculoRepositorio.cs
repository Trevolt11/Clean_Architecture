using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.entidades;
using Core.interfaces;
using infraestructura.Data;
using Microsoft.EntityFrameworkCore;

namespace infraestructura.Repositorios
{
    public class VehiculoRepositorio : InterfaceVehiculoRepositorio
    {

        public async Task<IEnumerable<ClienteEntidad>> GetVehiculos()
        {
            var vehiculos = Enumerable.Range(1, 10).Select(x => new VehiculoEntidad
            {
                matricula = $"Matricula{x * 2}",
                Idcliente = x,
                Fecha = DateTime.Now,
                Descripcion = $"Descripcion del vehiculo: {x * 3}",

            }) ; 
            await Task.Delay(10);
            //return vehiculos;

            var cliente = Enumerable.Range(1, 10).Select(x => new ClienteEntidad
            {
                Idcliente = x,
                Nombres = $"Nombre{x}",
                Apellidos = $"Apellido{x}",
                Fechaingreso = DateTime.Now,
                Telefono= $"Descripcion del cliente {x}",
                Id = 3,
                //Facturas = new Core.entidades.FacturaEntidad, 
            });
            await Task.Delay(10);
            return cliente;

            var factura = Enumerable.Range(1, 10).Select(x => new FacturaEntidad
            {
                Idcliente = x,
                Idfactura = x,
                Fecha = DateTime.Now,
                //Vehiculo = new VehiculoEntidad,

            });
            await Task.Delay(10);
           // return factura;

        }


    }
}


/* La base de datos no queire funcionar
        private readonly Clean_ArchContext _contexto;
        public VehiculoRepositorio(Clean_ArchContext contexto)
             
        {
            _contexto = contexto;
        }
        public async Task<IEnumerable<VehiculoEntidad>> GetVehiculos()
        {
            var vehiculo = await _contexto.Vehiculos.ToListAsync();
            
            return vehiculo;
        }*/