using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_entity.Models
{
    [Table("Studenci")]
    public partial class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column("Imie")]
        [MaxLength(30)]
        public string Imie { get; set; } = "";
        [MaxLength(50)]
        public string Nazwisko { get; set; } = "";
        
        public double? Ocena { get; set; }
        public byte Wiek { get; set; }
    }
}
