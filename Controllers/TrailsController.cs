using Microsoft.AspNetCore.Mvc;
using TatryExplorer.Models;
using TatryExplorer.Controllers;
using System.Threading.Tasks;


namespace TatryExplorer.Controllers
{ 


    public class TrailsController : Controller
    {
        private object results;

        // Akcja Index, która renderuje widok listy tras
        public IActionResult Index()
        {
            // Tutaj możemy pobrać listę tras z bazy danych lub utworzyć przykładowe dane
            var trails = new List<Trail>
            {
                new Trail { Id = 1, Name = "Trail A", LengthKm = 10, Duration = TimeSpan.FromHours(3), DifficultyLevel = "Easy", MapLink = "https://example.com/map_a", Description = "Description of trail A...", Photo = "path_to_photo_a.jpg" },
                new Trail { Id = 2, Name = "Trail B", LengthKm = 15, Duration = TimeSpan.FromHours(4), DifficultyLevel = "Medium", MapLink = "https://example.com/map_b", Description = "Description of trail B...", Photo = "path_to_photo_b.jpg" },
                new Trail { Id = 3, Name = "Trail C", LengthKm = 20, Duration = TimeSpan.FromHours(5), DifficultyLevel = "Difficult", MapLink = "https://example.com/map_c", Description = "Description of trail C...", Photo = "path_to_photo_c.jpg" }
            };

            return View(trails);

        }
        public IActionResult Search()
        {
            return View();
        }

        // Akcja do obsługi wyszukiwania tras
        [HttpPost]
      

        private IActionResult View(string v, object results)
        {
            throw new NotImplementedException();
        }
    }
}

