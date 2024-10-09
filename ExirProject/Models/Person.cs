namespace ExirProject.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? NationalCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Profile? Profile { get; set; }
        public LastStatus Status { get; set; }
    }
}
