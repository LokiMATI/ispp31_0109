using APIServices.Models;
using APIServices.Services;
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

        public IActionResult OnPostRedirectToMoreAboutGame(int id)
        {
            return RedirectToPage("/MoreAboutGame", new { id });
        }

        public async Task OnPostDeleteGame(int id)
        {
            await _service.DeleteGameAsync(id);
            await OnGet();
        }
    }
}
