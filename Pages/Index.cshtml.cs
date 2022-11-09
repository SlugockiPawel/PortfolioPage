using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using PortfolioPage.Clients;
using PortfolioPage.DTOs;
using PortfolioPage.Models;

namespace PortfolioPage.Pages
{
    public sealed class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBlogClient _blogClient;
        private readonly BlogApiSettings _blogApiSettings;

        public IndexModel(ILogger<IndexModel> logger, IBlogClient blogClient, IOptions<BlogApiSettings> blogApiSettings)
        {
            _logger = logger;
            _blogClient = blogClient;
            _blogApiSettings = blogApiSettings.Value;
        }

        [BindProperty] public List<PostDto>? PostsFromBlog { get; set; } = new();

        public async Task OnGetAsync()
        {
            PostsFromBlog = (await _blogClient.GetPostsFromBlog(3))?.ToList();
            ViewData["BlogClientBaseAddress"] = _blogApiSettings.BaseAddress;
        }
        
        
    }
}