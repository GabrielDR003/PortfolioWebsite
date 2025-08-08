using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolioSite.Pages;

public class ResumeModelModel : PageModel
{
    private readonly ILogger<ResumeModelModel> _logger;

    public ResumeModelModel(ILogger<ResumeModelModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

