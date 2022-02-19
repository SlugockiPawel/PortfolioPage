using Portfolio.Enums;
using Portfolio.ViewModels;

namespace Portfolio.Data
{
    public static class ProjectsData
    {
        public static List<ProjectModel> ProjectsList { get;  } = new();

        static ProjectsData()
        {
            ProjectsList.AddRange(new List<ProjectModel>
            {
                new ProjectModel()
                {
                    Id = 1,
                    Title = "Bug Tracker",
                    Abstract = "This is some abstract for now. Update it later",
                    Description = "This is broader description. Update it later.",
                    Date = new DateOnly(2022, 02, 15),
                    GithubUrl = "https://gitHubUrl",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "images/projects/project-4.jpg",
                    CarouselImages = new List<string>() { "images/projects/project-4.jpg", "images/projects/item-6.jpg" },
                    Technologies = new List<Technology>() { Technology.Bootstrap5, Technology.CSS3 },
                    IsLeadProject = true,
                },
                new ProjectModel()
                {
                    Id = 2,
                    Title = "Blog Project",
                    Abstract = "This is some abstract for now for The Blog. Update it later",
                    Description = "This is broader description. Update it later.",
                    Date = new DateOnly(2022, 02, 13),
                    GithubUrl = "https://gitHubUrl",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "images/projects/project-4.jpg",
                    CarouselImages = new List<string>() { "images/projects/project-4.jpg", "images/projects/project-4.jpg" },
                    Technologies = new List<Technology>() { Technology.Bootstrap5, Technology.CSS3 },
                },
                new ProjectModel()
                {
                    Id = 3,
                    Title = "The Movie Store",
                    Abstract = "This is some abstract for now for The Movie Store. Update it later",
                    Description = "This is broader description. Update it later.",
                    Date = new DateOnly(2022, 02, 13),
                    GithubUrl = "https://gitHubUrl",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "images/projects/project-4.jpg",
                    CarouselImages = new List<string>() { "images/projects/project-4.jpg", "images/projects/item-4.jpg",  "images/projects/item-6.jpg" },
                    Technologies = new List<Technology>() { Technology.Bootstrap5, Technology.CSS3 },
                },

                // Mini projects
                new ProjectModel()
                {
                    Id = 4,
                    IsMainProject = false,
                    Title = "The Loan Unicorn",
                    Abstract = "This is some abstract for now for The Loan Unicorn. Update it later",
                    Description = "This is broader description for Loan Unicorn. Update it later.",
                    Date = new DateOnly(2022, 02, 13),
                    GithubUrl = "https://gitHubUrl",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "images/projects/item-4.jpg",
                    CarouselImages = new List<string>() { "images/projects/project-4.jpg", "images/projects/item-4.jpg",  "images/projects/item-6.jpg" },
                    Technologies = new List<Technology>() { Technology.Bootstrap5, Technology.CSS3 },
                },
            });
        }
    }
}
