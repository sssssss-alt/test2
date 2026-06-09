using System.ComponentModel.DataAnnotations;

namespace s32757test2.Models;

public class Guests
{
    public int GuestId { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    [MaxLength(100)]
    public string LastName { get; set; } = null!;
    [MaxLength(100)]
    public string Email { get; set; } = null!;
    [MaxLength(9)]
    public string Phone { get; set; } = null!;
    
    public ICollection<Reservations> Reservations { get; set; } = new List<Reservations>();
}