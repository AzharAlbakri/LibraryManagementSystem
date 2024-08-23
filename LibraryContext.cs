using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Borrower> Borrowers { get; set; }
    public DbSet<BorrowingHistory> BorrowingHistories { get; set; }
    public DbSet<BookGenre> BookGenres { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuring many-to-many relationship for Book and Genre
        modelBuilder.Entity<BookGenre>()
            .HasKey(bg => new { bg.BookId, bg.GenreId });

        modelBuilder.Entity<BookGenre>()
            .HasOne(bg => bg.Book)
            .WithMany(b => b.BookGenres)
            .HasForeignKey(bg => bg.BookId);

        modelBuilder.Entity<BookGenre>()
            .HasOne(bg => bg.Genre)
            .WithMany(g => g.BookGenres)
            .HasForeignKey(bg => bg.GenreId);

        // Configuring many-to-many relationship for Book and Borrower
        modelBuilder.Entity<BorrowingHistory>()
            .HasKey(bh => new { bh.BorrowerId, bh.BookId });

        modelBuilder.Entity<BorrowingHistory>()
            .HasOne(bh => bh.Book)
            .WithMany(b => b.BorrowingHistories)
            .HasForeignKey(bh => bh.BookId);

        modelBuilder.Entity<BorrowingHistory>()
            .HasOne(bh => bh.Borrower)
            .WithMany(b => b.BorrowingHistories)
            .HasForeignKey(bh => bh.BorrowerId);
    }
}
