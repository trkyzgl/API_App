using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class UserManager : IUserService
    {

        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public User CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public List<User> GetAllUsers()
        {
            return new List<User>();
        }

        public User GetUserById(int id)
        {
            if (id > 0)
            {
                return _userRepository.GetUsersById(id);
            }
            else
            {
                throw new Exception("Id Con not be less than 0");
            }
        }

        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
