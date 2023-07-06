using PT.PassengerWebApp.Data.DataAccess;
using PT.PassengerWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;

namespace PT.PassengerWebApp.Data.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly AppDbContext _context;

        public PassengerRepository(AppDbContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<Passenger>> GetAllPassengers()
        {
            return await _context.Passengers.ToListAsync();
        }
    }
}