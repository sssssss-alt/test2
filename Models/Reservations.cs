using System.ComponentModel.DataAnnotations;

namespace s32757test2.Models;

public class Reservations
{
    public int ReservationId { get; set; }
    
    //FK
    public int GuestId { get; set; }
    public Guests guests { get; set; } = null!;
    public int RoomId { get; set; }
    public Rooms rooms { get; set; } = null!;
    
    public DateTime CheckinDate { get; set; }
    public DateTime? CheckoutDate { get; set; }
    [MaxLength(50)]
    public string Status { get; set; } = null!;
}