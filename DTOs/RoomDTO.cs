using s32757test2.Models;

namespace s32757test2.DTOs;

public class RoomDTO
{
    public int RoomId { get; set; }
    public string RoomNumber { get; set; } = null!;
    public string Type { get; set; } = null!;
    public decimal PricePerNight { get; set; }
    public int Floor { get; set; }
    public List<ReservationsDTO> reservations { get; set; } = new List<ReservationsDTO>();

    public class ReservationsDTO
    {
        public int ReservationId { get; set; }
        public List<GuestsDTO> guests { get; set; } = new List<GuestsDTO>();
        public DateTime checkInDate { get; set; }
        public DateTime? checkOutDate { get; set; }
        public string Status { get; set; } = null!;
        public List<ReservationServicesDTO> reservationServices { get; set; } = new List<ReservationServicesDTO>();
    }

    public class GuestsDTO
    {
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public string email { get; set; } = null!;
        public string phone { get; set; } = null!;
    }
    
    public class ReservationServicesDTO
        {
            public int Quantity { get; set; }
            public DateTime ServiceDate { get; set; }
            public List<ServiceDTO> service { get; set; } = new List<ServiceDTO>();
        }

    public class ServiceDTO
    {
        public int ServiceId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int DurationMinutes { get; set; }
    }
}