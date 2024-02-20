using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tabla1._1.Models
{
    [Table("Linea")]
    public class linea
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public string ajuste { get; set; }

    }
}
