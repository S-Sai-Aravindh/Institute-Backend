using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Institute_Management.Models
{
    [Table("Enrollrequest")]
    public class EnrollrequestModule
    {
        [Key]
        public int StudentId { get; set; }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
