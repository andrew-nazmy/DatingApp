using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUser
    {
     [Key]
     public int Id { get; set; }
     public String UserName { get; set; }   
    }
}