using ApiServices.Models;
using ApiServices.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class DetailsModel(GamesService service) : PageModel
    {
        private readonly GamesService _service = service;

        public Game? Game { get; set; }

        public void OnGet(int id)
        {
            try
            {
                Game = _service.GetGameByIdAsync(id).Result;
            }
            catch (Exception)
            {
            }
        }

        public async Task<IActionResult> OnPostUpdate(int id, string title, string publicationYear, string description, string price)
        {
            Game = new()
            {
                Id = id,
                Title = title,
                Description = description.Length > 0 ? description : null,
                Price = double.Parse(price),
                PublicationYear = short.Parse(publicationYear)
            };
            await _service.UpdateGameAsync(Game);
            return RedirectToPage("/Details", new { id });
        }
    }
}
