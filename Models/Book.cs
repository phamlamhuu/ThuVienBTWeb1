using System.ComponentModel.DataAnnotations;

namespace ThuVien_AIP.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool  IsRead { get; set; }
        public DateTime DataRead{ get; set; }

        public int Rate { get; set; }

        public int Gerne{ get; set; }

        public string CoverUrt { get; set; }

        public DateTime DateAdded { get; set; }

        public int PubisherID { get; set; }

        public Pubishers Pubishers { get; set; }
        public LinkedList<BookAuthor> BookAuthor { get; set;}
    }
}
