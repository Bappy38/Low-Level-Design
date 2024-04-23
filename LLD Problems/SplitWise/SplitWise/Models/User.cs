using System.ComponentModel.DataAnnotations.Schema;

namespace SplitWise.Models;

public class User
{
    [Column("UserId")]
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
}