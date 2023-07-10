using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUsers();
        }


        [HttpPost]
        public User Post(User user)
        {
            return _userService.CreateUser(user);
        }


        [HttpPut]
        public User Put(User user)
        {
            return _userService.UpdateUser(user);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }

    }
}
