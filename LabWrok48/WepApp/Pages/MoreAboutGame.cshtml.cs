using APIServices.Models;
using APIServices.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class MoreAboutGameModel(GamesService service) : PageModel
    {
        private readonly GamesService _service = service;

        public Game? Game { get; set; }

        public async Task OnPost(int id)
        {
            Game = await _service.GetGameByIdAsync(id);
        }
    }
}
