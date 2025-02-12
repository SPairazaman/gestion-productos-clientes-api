using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ProductosClientesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        [HttpGet]
        public List<Cliente> GetAsync(string? filtro)
        {
            ClienteService clienteService = new ClienteService();
            return clienteService.Get(filtro);
        }

        [HttpPost]
        public void CreateAsync(Cliente cliente) {
            ClienteService clienteService = new ClienteService();
            clienteService.Create(cliente);
        }

        [HttpDelete]
        public void DeleteAsync(int id) {
            ClienteService clienteService = new ClienteService();
            clienteService.Delete(id);
        }

    }
}
