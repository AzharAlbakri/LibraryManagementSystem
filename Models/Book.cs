namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishDate { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }


        public List<BookGenre> BookGenres { get; set; }
        public List<BorrowingHistory> BorrowingHistories { get; set; }

    }
}
