namespace LibraryManagementSystem.Models
{
    public class BorrowingHistory
    {
        public int BorrowingHistoryId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}