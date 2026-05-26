public class RentalHistory
{
    public string? CustomerCode { get; set; }

    public int? RentalItemId { get; set; }

    public DateTime? RentalDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string? Memo { get; set; }

    public bool HasReturned { get; set; }
}