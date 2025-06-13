using APIServices.Models;
using APIServices.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WepApp.Pages
{
    public class IndexModel(GamesService service) : PageModel
    {
        private readonly GamesService _service = service;

        public IEnumerable<Game> _games;

        public async Task OnGet()
        {
            _games = await _service.GetGamesAsync();
        }
    }
}
