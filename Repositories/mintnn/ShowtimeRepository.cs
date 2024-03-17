using BussinessObject;
using DataAccessObject;
using DataAccessObject.minhtnn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class ShowtimeRepository : IShowtimeRepository
    {
        public Showtime GetShowtimeById(int? showtimeId)
            => ShowtimeDAO.Instance.GetShowtimeById(showtimeId);
    }
}
