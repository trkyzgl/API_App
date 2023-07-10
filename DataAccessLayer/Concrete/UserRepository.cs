using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class UserRepository : IUserRepository
    {
        private DBContext _context;

        public UserRepository(DBContext dbContext)
        {
            _context = dbContext;
        }

        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;    
        }

        public void DeleteUser(int id)
        {
            var deleteUser = GetUsersById(id);
            _context.Users.Remove(deleteUser);
            _context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUsersById(int id)
        {
            return _context.Users.Find(id);
        }

        public User UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}
