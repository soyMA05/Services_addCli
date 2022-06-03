using Microsoft.AspNetCore.Mvc;
using ServicioSOA.Modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicioSOA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        // GET: api/<InventarioController> Interfaz para interactuar con la clase Producto
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            return Program.productos;
        }

        // GET api/<InventarioController>/5  Para buscar un producto
        [HttpGet("{id}")]
        public Producto Get(int id)
        {
            return Program.productos.Find(producto => producto.id==id);
        }

        // POST api/<InventarioController> Para crear un nuevo producto
        [HttpPost]
        public bool Post(Producto producto)
        {
            int pos = Program.productos.FindIndex(item => item.id == producto.id);
            if (pos == -1)
            {
                Program.productos.Add(producto);
                return true;
            }
            return false;
        }

        // PUT api/<InventarioController>/5 Modificar un producto
        [HttpPut("{id}")]
        public bool Put(int id, Producto producto)
        {
            int pos = Program.productos.FindIndex(item => item.id == producto.id);
            if (pos == -1)
            {
                Program.productos.RemoveAt(pos);
                Program.productos.Add(producto);
                return true;
            }
            return false;
        }

        // DELETE api/<InventarioController>/5 Eliminar un producto
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            int pos = Program.productos.FindIndex(item => item.id == id);
            if (pos == -1)
            {
                Program.productos.RemoveAt(pos);
                return true;
            }
            return false;
        }
    }
}
