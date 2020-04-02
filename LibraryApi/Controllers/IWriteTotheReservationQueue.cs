using LibraryApi.Domain;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
    public  interface IWriteTotheReservationQueue
    {
        Task Write(Reservation reservation);
    }
}