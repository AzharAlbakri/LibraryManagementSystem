namespace LibraryManagementSystem.Models
{
    public class Borrower
    {
        public int BorrowerId { get; set; }
        public string Name { get; set; }
        public DateTime MembershipDate { get; set; }

        public List<BorrowingHistory> BorrowingHistories { get; set; }
    }
}
