using PT.PassengerWebApp.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PT.PassengerWebApp.Data.Repositories
{
    public interface IPassengerRepository
    {
        Task<IEnumerable<Passenger>> GetAllPassengers();
    }
}