using System.ComponentModel.DataAnnotations;

namespace s32757test2.Models;

public class Services
{
    public int ServiceId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    [MaxLength(200)]
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int DurationMinutes { get; set; }
}