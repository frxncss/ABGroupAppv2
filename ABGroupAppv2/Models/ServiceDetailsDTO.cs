using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGroupAppv2.Models
{
    public class ServiceDetailsDTO
    {
        public string bookingReference { get; set; }
        public string bookingName { get; set; }
        public string roomingList { get; set; }
        public Bookingitinerary bookingItinerary { get; set; }
        public Bookingservice[] bookingService { get; set; }
    }

}
