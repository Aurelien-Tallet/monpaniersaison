using System.ComponentModel.DataAnnotations;
namespace back.Models;
 
[Index(nameof(Email), IsUnique = true)]
   public class Employee
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key, Column(Order = 0)]
    [Editable(false)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name field is required.")]
    [StringLength(100, MinimumLength = 3)]
    [Editable(true)]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email field is required.")]
    [StringLength(50, MinimumLength = 10)]
    [EmailAddress]
    [Editable(true)]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone field is required.")]
    [StringLength(15, MinimumLength = 10)]
    [Editable(true)]
    public string Phone { get; set; }

    [StringLength(250)]
    [Editable(true)]
    public string? Adress { get; set; } 

}