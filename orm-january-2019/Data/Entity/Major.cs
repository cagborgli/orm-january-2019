using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace orm_january_2019.Data.Entity
{
    [Table("major")]
    public class Major
    {
        [Key]
        [Column("major_id")]
        public int Id { get; set; }
        
        [Column("major_text")]
        public string MajorText { get; set; }

        public List<Student> Students { get; set; }
    }
}