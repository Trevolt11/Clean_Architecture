using infraestructura.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Core.interfaces;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoApiController : ControllerBase

    {

        public readonly InterfaceVehiculoRepositorio _vehiculoRepositorio;

        //Construtor
        public VehiculoApiController(InterfaceVehiculoRepositorio vehiculoRepositorio)
        {
            _vehiculoRepositorio = vehiculoRepositorio;

        }


        [HttpGet]
        public async Task <IActionResult> GetVehiculoApi()
        {
            var VehiculoEn = await _vehiculoRepositorio.GetVehiculos();
            return Ok(VehiculoEn);
        }

    }
}
