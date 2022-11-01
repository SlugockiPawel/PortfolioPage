using Portfolio.Enums;
using Portfolio.ViewModels;

namespace Portfolio.Data;

public static class ProjectsData
{
    public static List<ProjectModel> ProjectsList { get; } = new();

    static ProjectsData()
    {
        ProjectsList.AddRange(
            new List<ProjectModel>
            {
                new ProjectModel()
                {
                    Id = 1,
                    Title = "Bug Tracker",
                    Abstract =
                        "<p>Issue tracking app. Built to support multiple companies and support different user roles. The main idea behind this app is to use .NET Core framework and MVC to built business grade application.",
                    Description =
                        "<p>The Bug Tracker is an issue tracking app, where users can create issue tickets.</p> <p>Project Managers assign a person to each tickets, so they can be resolved by competent stuff. Tickets have comments/attachment functionalities and history track record. The application supports multiply companies if needed.</p>",
                    Date = new DateOnly(2022, 02, 15),
                    GithubUrl = "https://gitHubUrl",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "/images/projects/bug_tracker_screenshots/Dashboard1.png",
                    CarouselImages = new List<string>()
                    {
                        "/images/projects/bug_tracker_screenshots/Dashboard1.png",
                        "/images/projects/bug_tracker_screenshots/Dashboard2.png",
                        "/images/projects/bug_tracker_screenshots/LoginPage.png",
                        "/images/projects/bug_tracker_screenshots/TicketDetails.png",
                    },
                    Technologies = new List<Technology>()
                    {
                        Technology.Html5,
                        Technology.CSS3,
                        Technology.Bootstrap5,
                        Technology.JavaScript,
                        Technology.CSharp,
                        Technology.EntityFramework,
                        Technology.PostgreSQL,
                        Technology.MVC,
                        Technology.Git
                    }
                },
                new ProjectModel()
                {
                    Id = 2,
                    Title = "Personal Blog",
                    Abstract =
                        "<p>The Blog app is a classic blog application built using .NET MVC.</p>"
                        + "<p>Main purpose of this application is to show .NET MVC capabilities and allow me to write tech-related articles.</p>",
                    Description =
                        "<p>The Blog is a .NET MVC application that allows me to write technology related posts. The idea was to write down my knowledge to have notes at hand. Additionally, if anyone will be able to profit from my notes, it would be great.</p>"
                        + "<p>The app itself uses Postgresql database alongside Entity Framework. It implements Authentication/Authorization mechanism with custom user roles. Also, each post has comments section.</p>"
                        + "<p>Administrator is responsible for managing user roles. Moderator is responsible for comments moderation.</p>",
                    Date = new DateOnly(2021, 11, 30),
                    GithubUrl = "https://github.com/SlugockiPawel/TheBlog",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "images/projects/project-4.jpg",
                    CarouselImages = new List<string>()
                    {
                        "images/projects/project-4.jpg",
                        "images/projects/project-4.jpg"
                    },
                    Technologies = new List<Technology>()
                    {
                        Technology.Html5,
                        Technology.CSS3,
                        Technology.Bootstrap5,
                        Technology.JavaScript,
                        Technology.CSharp,
                        Technology.EntityFramework,
                        Technology.PostgreSQL,
                        Technology.MVC,
                        Technology.Git
                    },
                },
                new ProjectModel()
                {
                    Id = 3,
                    Title = "The Movie Store",
                    Abstract =
                        "<p>The Movie Store application is a movie library app that allows user to explore The Movie Database.</p>"
                        + "<p>Main purpose of this application is to show how to read and consume data from third party APIs using .NET MVC.</p>",
                    Description =
                        "<p>The Movie Store application uses third-party API to connect to and consume data from The Movie Database (https://www.themoviedb.org/). The received data is displayed to the user as a variation of cinema schedule- movies are grouped in different categories (e.g. Now Playing, Upcoming etc.). User is able to view specific movie details, along with its crew and cast. Details for crew and cast are also available.</p>"
                        + "<p>The Movie Store is a .NET MVC application tah uses Postgresql database alongside Entity Framework.</p>",
                    Date = new DateOnly(2021, 12, 28),
                    GithubUrl = "https://github.com/SlugockiPawel/MovieStore",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "/images/projects/movie_store_screenshots/Main.png",
                    CarouselImages = new List<string>()
                    {
                        "/images/projects/movie_store_screenshots/Main.png",
                        "/images/projects/movie_store_screenshots/Main2.png",
                    },
                    Technologies = new List<Technology>()
                    {
                        Technology.Html5,
                        Technology.CSS3,
                        Technology.Bootstrap5,
                        Technology.JavaScript,
                        Technology.CSharp,
                        Technology.EntityFramework,
                        Technology.PostgreSQL,
                        Technology.MVC,
                        Technology.Git
                    },
                },
                // Mini projects
                new ProjectModel()
                {
                    Id = 4,
                    IsMainProject = false,
                    Title = "The Loan Unicorn JS",
                    Abstract =
                        "<p>The Loan Unicorn app is a small Javascript loan calculator.</p>"
                        + "<p>The app takes user input needed for loan and calculates payment schedule.</p>",
                    Description =
                        "<p>The Loan Unicorn app is a small Javascript loan calculator.</p>"
                        + "<p>The app takes user input needed for loan and calculates payment schedule.</p>",
                    Date = new DateOnly(2021, 08, 12),
                    GithubUrl = "https://github.com/SlugockiPawel/LoanUnicorn",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "/images/projects/loan_unicorn_screenshots/MainPage.png",
                    CarouselImages = new List<string>()
                    {
                        "/images/projects/loan_unicorn_screenshots/MainPage.png",
                        "/images/projects/loan_unicorn_screenshots/NoResult.png",
                        "/images/projects/loan_unicorn_screenshots/Result.png",
                        "/images/projects/loan_unicorn_screenshots/Code.png",
                    },
                    Technologies = new List<Technology>()
                    {
                        Technology.Html5,
                        Technology.CSS3,
                        Technology.Bootstrap5,
                        Technology.JavaScript,
                        Technology.Git
                    },
                },
                new ProjectModel()
                {
                    Id = 6,
                    IsMainProject = false,
                    Title = "FizzBuzz JS",
                    Abstract =
                        "<p>FizzBuzz application is a Javascript program that solves famous coding trivia- fizz-buzz</p>"
                        + "<p>User is presented with 0-100 number range table where each value is displayed according to fizzBuzz algorithm - click below for further details.</p>",
                    Description =
                        "<p>FizzBuzz application is a .NET MVC program that solves famous coding trivia- fizz-buzz.</p>"
                        + "<p>User is presented with 0-100 number range table where each value is displayed according to fizzBuzz algorithm:</p>"
                        + "<p>If the number is divisible by 3 and 5 - displayed value is <span class='fst-italic'> FizzBuzz </span>. If the number is divisible by 3 - displayed value is <span class='fst-italic'> Fizz </span>. If divisible by 5 - <span class='fst-italic'>Buzz.</span></p>",
                    Date = new DateOnly(2021, 08, 24),
                    GithubUrl = "https://github.com/SlugockiPawel/FizzBuzz",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "/images/projects/fizzbuzz_screenshots/MainPage.png",
                    CarouselImages = new List<string>()
                    {
                        "/images/projects/fizzbuzz_screenshots/MainPage.png",
                        "/images/projects/fizzbuzz_screenshots/NoResult.png",
                        "/images/projects/fizzbuzz_screenshots/Result.png",
                        "/images/projects/fizzbuzz_screenshots/Code.png",
                    },
                    Technologies = new List<Technology>()
                    {
                        Technology.Html5,
                        Technology.CSS3,
                        Technology.Bootstrap5,
                        Technology.JavaScript,
                        Technology.Git
                    },
                },
                new ProjectModel()
                {
                    Id = 8,
                    IsMainProject = false,
                    Title = "Rewind JS",
                    Abstract =
                        "<p>Rewind is a small Javascript application that is responsible for reversing a string.</p>"
                        + "<p>String is taken from user via web form and its reversed version is returned back to user.</p>",
                    Description =
                        "<p>Rewind is a small Javascript application that is responsible for reversing a string.</p>"
                        + "<p>String is taken from user via web form and its reversed version is returned back to user.</p>",
                    Date = new DateOnly(2021, 08, 02),
                    GithubUrl = "https://github.com/SlugockiPawel/Rewind",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "/images/projects/rewind_screenshots/MainPage.png",
                    CarouselImages = new List<string>()
                    {
                        "/images/projects/rewind_screenshots/MainPage.png",
                        "/images/projects/rewind_screenshots/NoResult.png",
                        "/images/projects/rewind_screenshots/Result.png",
                        "/images/projects/rewind_screenshots/Code.png",
                    },
                    Technologies = new List<Technology>()
                    {
                        Technology.Html5,
                        Technology.CSS3,
                        Technology.Bootstrap5,
                        Technology.JavaScript,
                        Technology.Git
                    },
                },
                new ProjectModel()
                {
                    Id = 9,
                    IsMainProject = false,
                    Title = "Speedometer JS",
                    Abstract =
                        "<p>Speedometer is a small Javascript application that shows numbers in user specified range.</p>"
                        + "<p>Even number in displayed range are made bold.</p>",
                    Description =
                        "<p>Speedometer is a small Javascript application that shows numbers in user specified range.</p>"
                        + "<p>Even number in displayed range are made bold.</p>",
                    Date = new DateOnly(2021, 07, 28),
                    GithubUrl = "https://github.com/SlugockiPawel/Speedometer",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "/images/projects/speedometer_screenshots/MainPage.png",
                    CarouselImages = new List<string>()
                    {
                        "/images/projects/speedometer_screenshots/MainPage.png",
                        "/images/projects/speedometer_screenshots/NoResult.png",
                        "/images/projects/speedometer_screenshots/Result.png",
                        "/images/projects/speedometer_screenshots/Code.png",
                    },
                    Technologies = new List<Technology>()
                    {
                        Technology.Html5,
                        Technology.CSS3,
                        Technology.Bootstrap5,
                        Technology.JavaScript,
                        Technology.Git
                    },
                },
                new ProjectModel()
                {
                    Id = 10,
                    IsMainProject = false,
                    Title = "Tacocat JS",
                    Abstract =
                        "<p>Tacocat is a Javascript app which solves popular coding trivia- it checks if a string provided by the user is a palindrome.</p>"
                        + "<p>String is taken from the user via web form and the result is returned back to the user in the same view</p>",
                    Description =
                        "<p>Tacocat is a Javascript app which solves popular coding trivia- it checks if a string provided by the user is a palindrome.</p>"
                        + "<p>palindrome is a word that reads the same as its reversed string(e.g. 'tacocat', because reading it backwords is also 'tacocat'</p>"
                        + "<p>String is taken from the user via web form and the result is returned back to the user in the same view</p>",
                    Date = new DateOnly(2021, 08, 11),
                    GithubUrl = "https://github.com/SlugockiPawel/tacocat",
                    ProjectUrl = "https://www.slugocki.dev",
                    CardImage = "/images/projects/tacocat_screenshots/MainPage.png",
                    CarouselImages = new List<string>()
                    {
                        "/images/projects/tacocat_screenshots/MainPage.png",
                        "/images/projects/tacocat_screenshots/Palindrome.png",
                        "/images/projects/tacocat_screenshots/NotPalindrome.png",
                        "/images/projects/tacocat_screenshots/Code.png",
                    },
                    Technologies = new List<Technology>()
                    {
                        Technology.Html5,
                        Technology.CSS3,
                        Technology.Bootstrap5,
                        Technology.JavaScript,
                        Technology.Git
                    },
                },
            }
        );
    }
}
