using Ficticia.Data;
using Ficticia.Models;
using Ficticia.Validation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ficticia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteContext context;

        public ClienteController(ClienteContext context)
        {
            this.context = context;
        }
        
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return context.Cliente.ToList();

        }
        [HttpGet("{id}")]
        public Cliente? Get(int id)
        {
            var cliente = context.Cliente.FirstOrDefault(p=>p.Id == id);
            return cliente;
        }

        [HttpPost("agregar")]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            var validator = new ClienteValidation();
            ValidationResult result = validator.Validate(cliente);
            if (result.IsValid)
            {
                try
                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                    return Ok();
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            
            }
            return Ok();
        }
        
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Cliente cliente)
        {
            if (cliente.Id == id)
            {
                context.Entry(cliente).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();

            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cliente = context.Cliente.FirstOrDefault(p => p.Id == id);
            if (cliente != null)
            {
                context.Cliente.Remove(cliente);
                context.SaveChanges();
                return Ok();

            }
            else
            {
                return BadRequest();
            }
        }

    }
}
