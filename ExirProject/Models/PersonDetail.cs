using System.ComponentModel.DataAnnotations;

namespace ExirProject.Models
{
    public class PersonDetail
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Nationacl Code should be Exactly 10 letters")]
        public string? NationalCode { get; set; }
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Phone { get; set; }
        public LastStatus Status { get; set; }
    }
}
