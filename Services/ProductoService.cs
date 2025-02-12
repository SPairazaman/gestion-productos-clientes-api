using Domain.Entities;
using Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Services
{
    public class ProductoService
    {
        public List<Producto> Get(string filtro)
        {
            using (var _context= new ProyectoFinalContext())
            {
                var query=_context.Productos.Where(p => p.Activo == true);

                if (!filtro.IsNullOrEmpty())
                {
                    query = query.Where(p => p.Nombre.Contains(filtro));
                }
                return query.ToList();
            }
        }

        public void Create(Producto producto)
        {
            using (var _context = new ProyectoFinalContext())
            {
                producto.Activo = true;
                producto.FechaCreacion =DateTime.Now;
                _context.Productos.Add(producto);
                _context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var _context= new ProyectoFinalContext())
            {
                Producto producto = _context.Productos.Find(Id);
                if (producto != null) {
                    _context.Entry(producto).State = EntityState.Modified;
                    producto.Activo=false;
                    _context.SaveChanges();
                }
            }
        }
    }
}
