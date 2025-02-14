using Domain.Entities;
using Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ClienteService
    {
        public List<Cliente> Get(string filtro)
        {
            using (var _context = new ProyectoFinalContext())
            {
                var query = _context.Clientes.Where(c => c.Activo == true);

                if (!filtro.IsNullOrEmpty())
                {
                    query = query.Where(c => c.Nombre.Contains(filtro) || c.Correo.Contains(filtro) || c.Telefono.Contains(filtro));
                }
                return query.ToList();
            }
        }

        public void Create(Cliente cliente)
        {
            using (var _context = new ProyectoFinalContext())
            {
                cliente.Activo = true;
                cliente.FechaCreacion =DateTime.Now;
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var _context = new ProyectoFinalContext())
            {
                Cliente cliente = _context.Clientes.Find(Id);
                if (cliente != null) { 
                    _context.Entry(cliente).State=EntityState.Modified;
                    cliente.Activo=false;
                    _context.SaveChanges();
                }
            }
        }

    }
}
