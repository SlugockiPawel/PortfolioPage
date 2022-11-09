using Portfolio.Enums;

namespace PortfolioPage.ViewModels
{
    public sealed class ProjectModel
    {
        public int Id { get; init; }
        public bool IsMainProject { get; init; } = true;
        public string Title { get; init; } = default!;
        public string Abstract { get; init; } = default!;
        public string Description { get; init; } = default!;
        public string CardImage { get; init; } = default!;
        public List<string> CarouselImages { get; init; } = new();
        public List<Technology> Technologies { get; init; } = new();
        public DateOnly Date { get; init; } = DateOnly.FromDateTime(DateTime.Today);
        public string ProjectUrl { get; init; } = default!;
        public string GithubUrl { get; init; } = default!;
    }
}
