using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGroupAppv2.Models
{

    public class UserDTO
    {
        public bool IsLoggedIn { get; set; }
        public string Email { get; set; }
        public string SupplierCode { get; set; }
        public string Name { get; set; }
        public List<BookingDTO> Bookings { get; set; }
    }

    public class BookingDTO
    {
        public string BookingReference { get; set; }
        public string BookingName { get; set; }
        public string SupplierCode { get; set; }
        public DateTime ServiceDate { get; set; }
        public string ProductOptionName { get; set; }
        public int BsL_ID { get; set; }
        public DateTime PickUpDate { get; set; }
        public string PickUpTime { get; set; }
        public string PickUpDetails { get; set; }
        public DateTime PropOffDate { get; set; }
        public string PropOffTime { get; set; }
        public string DropOffDetails { get; set; }
    }

}
