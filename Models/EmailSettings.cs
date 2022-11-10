namespace PortfolioPage.Models
{
    public sealed class EmailSettings
    {
        public string Email { get; set; } = default!;
        public string EmailPassword { get; set; } = default!;
        public string EmailHost { get; set; } = default!;
        public int EmailPort { get; set; } = default!;
    }
}