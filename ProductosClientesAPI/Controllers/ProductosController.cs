using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ProductosClientesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        [HttpGet]
        public List<Producto> GetAsync(string? filtro)
        {
            ProductoService service = new ProductoService();
            return service.Get(filtro);
        }

        [HttpPost]
        public void CreateAsync(Producto producto)
        {
            ProductoService service = new ProductoService();
            service.Create(producto);
        }

        [HttpDelete]
        //[Route("Delete")]
        public void DeleteAsync(int id)
        {
            ProductoService service = new ProductoService();
            service.Delete(id);
        }

    }
}
