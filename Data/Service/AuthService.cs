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
    }

}
