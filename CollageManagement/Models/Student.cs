
using System.ComponentModel.DataAnnotations;

namespace CollageManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }

        [Required]
        public int RollNo { get; set; }
        public int RegNo { get; set; }

        [Required]
        public int DepartmentId { get; set; }
    }
}