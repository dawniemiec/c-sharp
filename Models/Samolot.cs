using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_DBEF.Models
{
    [Table("Samoloty")]
    public partial class Samolot
    {
        [Key]
        public int SamolotId { get; set; }
        [Column("Producent")]
        [MaxLength(30)]
        public string Producent { get; set; } = "";
        [Column("Model")]
        [MaxLength(30)]
        public string Model { get; set; } = "";
        [Column("Predkosc")]
        public double Predkosc {  get; set; }
        [Column("Pulap")]
        public double Pulap { get; set; }
        [Column("Udzwig")]
        public double Udzwig { get; set; }
    }
}
