
using System.ComponentModel.DataAnnotations;

namespace Prueba2.Models;

public class Autos
{
    [Key]
    public int Id { get; set; }
    public string Brand { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int Year { get; set; }
}
