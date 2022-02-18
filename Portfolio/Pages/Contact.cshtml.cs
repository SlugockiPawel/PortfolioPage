using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Portfolio.Services;

namespace Portfolio.Pages
{
    [ValidateAntiForgeryToken]
    public class ContactModel : PageModel
    {
        private readonly IPortfolioEmailSender _emailSender;
        public ContactModel(IPortfolioEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [BindProperty] public InputModel Input { get; set; } = new();

        public class InputModel
        {
            [Required]
            [StringLength(80, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 2)]
            public string Name { get; set; } = default!;

            [Required]
            [EmailAddress]
            [StringLength(50, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 5)]
            public string Email { get; set; } = default!;

            [Required]
            [StringLength(50, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 2)]
            public string Subject { get; set; } = default!;

            [Required]
            [StringLength(500, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 10)]
            public string Message { get; set; } = default!;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostSendMessage(InputModel model)
        {
            model.Message = $"{model.Message} <hr/>";
            await _emailSender.SendContactEmailAsync(model.Email, model.Name, model.Subject, model.Message);

            TempData["MailSent"] = true;

            return RedirectToPage("Index");
        }
    }
}
