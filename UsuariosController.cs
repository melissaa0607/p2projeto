
using Microsoft.AspNetCore.Mvc;
using RoletaAPI.Data;
using RoletaAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace RoletaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly RoletaContext _context;

        public UsuariosController(RoletaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        [HttpPost]
        public ActionResult<Usuario> PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetUsuario), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public IActionResult PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();

            return NoContent();
        }
    }
}