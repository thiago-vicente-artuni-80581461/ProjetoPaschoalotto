using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoPaschoalotto.Models
{
    [Table("Usuario")]
    public class UsuarioRegistro
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("Country")]
        public string Country { get; set; }

        [Column("First")]
        public string First { get; set; }

        [Column("Last")]
        public string Last { get; set; }

        [Column("Phone")]
        public string Phone { get; set; }

        [Column("Large")]
        public string Large { get; set; }
    }
}
