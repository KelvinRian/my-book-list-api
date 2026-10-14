namespace MyBookList.Api.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public string Author { get; set; } = default!;
        public BookStatus Status { get; set; }
        public int? Rating { get; set; }
        public string? Review { get; set; }
        public bool IsFavorite { get; set; }
        public DateTime? ReadingStartDate { get; set; }
        public DateTime? ReadingEndDate { get; set; }
    }
}
