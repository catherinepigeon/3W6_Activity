using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string EventName {get;set;}
        public int Booking_Id { get; set; }
        public ICollection<Booking> Booking { get; set; }
    }
}
