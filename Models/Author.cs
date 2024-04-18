using System.ComponentModel.DataAnnotations;

namespace ThuVien_AIP.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}
