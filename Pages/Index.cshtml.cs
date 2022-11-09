using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PortfolioPage.Clients;
using PortfolioPage.DTOs;

namespace PortfolioPage.Pages
{
    public sealed class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBlogClient _blogClient;

        public IndexModel(ILogger<IndexModel> logger, IBlogClient blogClient)
        {
            _logger = logger;
            _blogClient = blogClient;
        }

        [BindProperty] public List<PostDto>? PostsFromBlog { get; set; } = new();

        public async Task OnGetAsync()
        {
            PostsFromBlog = (await _blogClient.GetPostsFromBlog(3))?.ToList();
        }
        
        
    }
}