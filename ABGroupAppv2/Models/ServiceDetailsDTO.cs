namespace ABGroupAppv2
{
    public class ServiceDetailsDTO
    {
        public string bookingReference { get; set; }
        public string bookingName { get; set; }
        public string consultantName { get; set; }
        public string agentName { get; set; }
        public string agentCountry { get; set; }
        public string roomingList { get; set; }
        public BookingItineraryDTO bookingItinerary { get; set; }
        public List<BookingserviceDTO> bookingService { get; set; }
    }

}
