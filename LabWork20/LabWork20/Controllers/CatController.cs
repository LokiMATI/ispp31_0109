using Microsoft.AspNetCore.Mvc;
using LabWork20.Models;
using Microsoft.AspNetCore.Http;
using System.Reflection.Metadata.Ecma335;

namespace LabWork20.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {
        private static List<Cat> _cats = new()
        {
            new Cat { Id = 1, Name = "Усатик", Breed = "Персидская", Color = "Белый", Age = 5 },
            new Cat { Id = 2, Name = "Варежка", Breed = "Сиамская", Color = "Сил-пойнт", Age = 3 },
            new Cat { Id = 3, Name = "Дымок", Breed = "Британская короткошерстная", Color = "Серый", Age = 7 },
            new Cat { Id = 4, Name = "Белла", Breed = "Мейн-кун", Color = "Рыжий", Age = 4 },
            new Cat { Id = 5, Name = "Макс", Breed = "Рэгдолл", Color = "Сил-миттед", Age = 2 },
            new Cat { Id = 6, Name = "Луна", Breed = "Персидская", Color = "Трехцветный", Age = 6 },
            new Cat { Id = 7, Name = "Оливер", Breed = "Британская короткошерстная", Color = "Черный", Age = 8 },
            new Cat { Id = 8, Name = "Клео", Breed = "Сиамская", Color = "Коричневый", Age = 3 },
            new Cat { Id = 9, Name = "Симба", Breed = "Мейн-кун", Color = "Рыжий", Age = 5 },
            new Cat { Id = 10, Name = "Ромашка", Breed = "Персидская", Color = "Белый", Age = 2 },
            new Cat { Id = 11, Name = "Тест", Breed = "Персидская", Color = "Белый", Age = 2 },
            new Cat { Id = 12, Name = "Ромашка", Breed = "Персидская", Color = "Белый", Age = 2 }
        };

        [HttpGet("/cats")]
        public ActionResult<List<Cat>> GetList(int page = 1, int pageSize = int.MaxValue)
        {
            var cats = _cats.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return Ok(cats);
        }

        [HttpGet("/cats/{id:int}")]
        public ActionResult<Cat> GetById(int id)
        {
            var cat = _cats.FirstOrDefault(c => c.Id == id);

            if (cat == null)
                return NotFound();

            return Ok(cat);
        }

        [HttpGet("/cats/breed")]
        public ActionResult<List<Cat>> GetByBreed(string breed)
            => Ok(_cats.Where(c => c.Breed == breed));

        [HttpPost]
        public ActionResult<Cat> Create([FromBody]Cat cat)
        {
            try
            {
                cat.Id = _cats.Count() + 1;
                _cats.Add(cat);

                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var cat = _cats.FirstOrDefault(_c => _c.Id == id);

            if (cat is not null)
            {
                _cats.Remove(cat);
                return NoContent();
            }

            return NotFound();
        }
    }
}
