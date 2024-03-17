using BussinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ShowtimeDAO
    {
        private static ShowtimeDAO instance = null;
        private static object lockObject = new object();
        public ShowtimeDAO() { }
        public static ShowtimeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShowtimeDAO();
                }
                return instance; 
            }
        }
        public Showtime GetShowtimeById(int? showtimeId)
        {
            using var db = new HakoloCinemaManagementContext();
            return db.Showtimes.Include(f => f.Tickets).SingleOrDefault(f => f.ShowtimeId == showtimeId);
        }
        
    }
}
