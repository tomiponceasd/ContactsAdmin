using ContactAdmin.Data;
using ContactAdmin.Models;
using ContactAdmin.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public ContactsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet, Authorize]
        public IActionResult GetAllContacts()
        {
            var allContactos = dbContext.Contactos.ToList();
            return Ok(allContactos);
        }

        [HttpGet, Authorize]
        [Route("{id:guid}")]
        public IActionResult GetContactById(Guid id)
        {
            var contacto = dbContext.Contactos.Find(id);

            if (contacto is null)
                return NotFound();
            return Ok(contacto);

        }

        [HttpGet("email/{email}"), Authorize]
        public IActionResult GetContactByEmail(string email)
        {           
            var contacto = dbContext.Contactos
               .FirstOrDefault(u => u.Email == email);

            if (contacto is null)
                return NotFound();
            return Ok(contacto);
        }

        [HttpGet("telefono/{telefono}"), Authorize]
        public IActionResult GetContactByTelefono(string telefono)
        {
            var contacto = dbContext.Contactos
               .FirstOrDefault(u => u.Telefono == telefono);

            if (contacto is null)
                return NotFound();
            return Ok(contacto);
        }

        [HttpPost, Authorize]
        public IActionResult AddContact(AddContactDto addContactDto)
        {
            var contactEntity = new Contacto()
            {
                Nombre = addContactDto.Nombre,
                Empresa = addContactDto.Empresa,
                Email = addContactDto.Email,
                Telefono = addContactDto.Telefono

            };

            dbContext.Contactos.Add(contactEntity);
            dbContext.SaveChanges();

            return Ok(contactEntity);
        }

        [HttpPut, Authorize]
        [Route("{id:guid}")]
        public IActionResult UpdateContact(Guid id,UpdateContactDto updateContactDto) 
        {
            var contacto = dbContext.Contactos.Find(id);

            if (contacto is null)
                return NotFound();

            contacto.Nombre = updateContactDto.Nombre;
            contacto.Empresa = updateContactDto.Empresa;
            contacto.Email = updateContactDto.Email;
            contacto.Telefono = updateContactDto.Telefono;

            dbContext.SaveChanges();

            return Ok(contacto);
        }

        [HttpDelete, Authorize]
        [Route("{id:guid}")]
        public IActionResult DelenteContact(Guid id) 
        {
            var contacto = dbContext.Contactos.Find(id);

            if (contacto is null)
                return NotFound();

            dbContext.Contactos.Remove(contacto);
            dbContext.SaveChanges();

            return Ok();
        }

    }
}
