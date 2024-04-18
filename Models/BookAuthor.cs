using System.ComponentModel.DataAnnotations;

namespace ThuVien_AIP.Models
{
    public class BookAuthor
    {

        [Key]
        public int Id { get; set; }
        public int BookID { get; set; }

        public int AuthorID { get; set; }
    }
}
