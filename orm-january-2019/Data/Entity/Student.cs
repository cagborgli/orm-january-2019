using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace orm_january_2019.Data.Entity
{
    [Table("student")]
    public class Student
    {
        [Key]
        [Column("student_id")]
        public int Id { get; set; }
        
        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }
        
        [Column("last_name")]
        public string LastName { get; set; }
        
        [Column("age")]
        public int Age { get; set; }
        
        [Column("gpa", TypeName = "decimal(3, 2)")]
        public double Gpa { get; set; }

        [ForeignKey("major_id")]
        [Required]
        public virtual Major Major { get; set; }
        
        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Major.MajorText}, GPA: {Gpa}, Age: {Age}";
        }
    }
}