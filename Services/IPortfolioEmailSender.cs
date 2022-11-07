using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Portfolio.Services
{
    public interface IPortfolioEmailSender
    {
        Task SendContactEmailAsync(string emailFrom, string name, string subject, string htmlMessage);
    }
}
