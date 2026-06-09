namespace s32757test2.Models;

public class ReservationServices
{
    //FK
    public int ReservationId { get; set; }
    public  Reservations reservations { get; set; } = null!;

    public int ServiceId { get; set; }
    public Services services { get; set; } = null!;
    
    public int Quantity { get; set; }
    public DateTime ServiceDate { get; set; }
}