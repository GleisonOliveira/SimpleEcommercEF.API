using eCommerce.API.Repositories.Interfaces;
using eCommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _repository.GetById(id);

            if (user == null)
            {
                return NotFound("Not found");
            }

            return Ok(user);
        }

        [HttpPost()]
        public IActionResult Add([FromBody]User user)
        {
            user.Id = 0;
            _repository.Add(user);

            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] User user, int id)
        {
            var savedUser = _repository.GetById(id);

            if (savedUser == null)
            {
                return NotFound("Not found");
            }


            savedUser.MotherName = user.MotherName;
            savedUser.Addresses = user.Addresses;
            savedUser.Document = user.Document;
            savedUser.Name = user.Name;
            savedUser.Email = user.Email;
            savedUser.Contact = user.Contact;
            savedUser.Sex = user.Sex;
            savedUser.Status = user.Status;
            savedUser.FinancialDocument = user.FinancialDocument;
            savedUser.Departments = user.Departments;

            _repository.Update(user);

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var savedUser = _repository.GetById(id);

            if (savedUser == null)
            {
                return NotFound("Not found");
            }

            _repository.Delete(savedUser);

            return NoContent();
        }
    }
}
