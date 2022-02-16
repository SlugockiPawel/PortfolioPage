using Portfolio.Enums;

namespace Portfolio.ViewModels
{
    public class ProjectModel
    {
        public int Id { get; init; }
        public bool MainProject { get; set; } = true;
        public string Title { get; init; } = default!;
        public string Abstract { get; init; } = default!;
        public string Description { get; init; } = default!;
        public List<string>? Images { get; init; }
        public List<Technology>? Technologies { get; init; }
        public DateOnly Date { get; init; } = DateOnly.FromDateTime(DateTime.Today);
        public string ProjectUrl { get; init; } = default!;
        public string GithubUrl { get; init; } = default!;
    }
}
