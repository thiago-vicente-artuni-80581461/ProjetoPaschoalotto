using static ProjetoPaschoalotto.Models.Usuario;

namespace ProjetoPaschoalotto.Models
{
    public class Result
    {
        public Name Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Location Location { get; set; }
        public Picture Picture { get; set; }
    }
}
