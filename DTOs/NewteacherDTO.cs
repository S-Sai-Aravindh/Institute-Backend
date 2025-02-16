namespace Institute_Management.DTOs
{
    public class NewteacherDTO
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; } = string.Empty;
        public string? Role { get; set; }
        public string? ContactDetails { get; set; }
        public string? SubjectSpecialization { get; set; }
    }
}
