using System.Collections;
using Microsoft.Extensions.Options;
using PortfolioPage.DTOs;
using PortfolioPage.Models;

namespace PortfolioPage.Clients;

public class BlogClient : IBlogClient
{
    private readonly HttpClient _httpClient;

    public BlogClient(HttpClient httpClient, IOptions<BlogApiSettings> blogApiSettings)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = blogApiSettings.Value.BaseAddress;
    }

    public async Task<IEnumerable<PostDto>?> GetPostsFromBlog(int count)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PostDto>>($"api/posts/{count}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        return null;
    }
}