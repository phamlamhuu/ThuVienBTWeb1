using System.ComponentModel.DataAnnotations;

namespace ThuVien_AIP.Models
{
    public class Pubishers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
