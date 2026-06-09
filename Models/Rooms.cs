using System.ComponentModel.DataAnnotations;

namespace s32757test2.Models;

public class Rooms
{
    public int Roomid { get; set; }
    [MaxLength(10)]
    public string Roomnumber { get; set; } = null!;
    [MaxLength(50)]
    public string Type { get; set; } = null!;
    public decimal PricePerNight { get; set; }
    public int Floor { get; set; }
    
    public ICollection<Reservations> Reservations { get; set; } = new List<Reservations>();

}