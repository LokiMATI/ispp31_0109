using ApiServices.Models;
using ApiServices.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WepApp.Pages
{
    public class IndexModel(GamesService service) : PageModel
    {
        private readonly GamesService _service = service;

        public IEnumerable<Game> Games;

        public async Task OnGet()
        {
            try
            {
                Games = await _service.GetGamesAsync();
            }
            catch (Exception)
            {
                Games = new List<Game>();
            }
        }

        public IActionResult OnPostDetails(int id)
        {
            return RedirectToPage("./Details", new { id });
        }

        public async Task OnPostDeleteAsync(int id)
        {
            try
            {
                await _service.DeleteGameAsync(id);
                RedirectToPage();
            }
            catch (Exception)
            {
                RedirectToPage();
            }
        }
    }
}
