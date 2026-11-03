using MangaFan.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangaFan.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MangasController : ControllerBase
	{
		// Şimdilik geçici bir liste oluşturalım (İleride bunu veritabanına bağlayacağız)
		private static readonly List<Manga> _mangas = new List<Manga>
		{
			new Manga { Id = 1, Title = "One Piece", Author = "Eiichiro Oda", Chapters = 1100 },
			new Manga { Id = 2, Title = "Naruto", Author = "Masashi Kishimoto", Chapters = 700 },
			new Manga { Id = 3, Title = "Berserk", Author = "Kentaro Miura", Chapters = 370 }
		};

		// GET: api/mangas
		[HttpGet]
		public ActionResult<IEnumerable<Manga>> GetMangas()
		{
			return Ok(_mangas);
		}
	}
}
