using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tabla1._1.Models
{
    [Table("Pieza")]
    public class piezas
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nparte { get; set; }

        public string color { get; set; }
        public string modelo { get; set; }


    }
}
