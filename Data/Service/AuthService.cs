using RayihaRestaurant.Core.Models;

namespace RayihaRestaurant.Data.Service
{
    public class AuthService
    {
        private readonly DatabaseContext _context;

        public AuthService(DatabaseContext context)
        {
            _context = context;
        }
        public User AuthenticateUser(string username, string password)
        {
            User user = _context.Users.FirstOrDefault(u => u.Name == username && u.Password == password);
            return user;
        }
    }

}
