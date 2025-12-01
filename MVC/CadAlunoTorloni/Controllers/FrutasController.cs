using CadAlunoTorloni.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadAlunoTorloni.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }



        // Criar uma lista de Frutas
        // Cítricas
        // Tropical

        private static List<Fruta> frutas = new List<Fruta>
        {
            new Fruta{ Id = 1, Nome = "Maçã", Cor = "Vermelha", Categoria = "Tropical" },
            new Fruta{ Id = 2, Nome = "Banana", Cor = "Amarela", Categoria = "Tropical" },
            new Fruta{ Id = 3, Nome = "Uva", Cor = "Roxa", Categoria = "Tropical" },
            new Fruta{ Id = 4, Nome = "Limão", Cor = "Verde", Categoria = "Cítrica" },
            new Fruta{ Id = 5, Nome = "Abacaxi", Cor = "Roxa", Categoria = "Cítrica" },
        };


        public IActionResult Index()
        {
            return View(frutas);
        }


        // Action para cadastrar uma fruta - Formulário (Viewl)
        public IActionResult Create()
        {
            return View();
        }


        // Método para salvar uma fruta, sem uma View
        [HttpPost]
        public IActionResult Create(Fruta fruta)
        {
            //cria o próximo id
            fruta.Id = frutas.Max(f => f.Id) + 1;
            // salvar no array
            frutas.Add(fruta);
            // redirecionar o usuário para a Index
            return RedirectToAction("Index");
        }




        public IActionResult FrutasCitricas()
        {
            return View(frutas);
        }
        
        public IActionResult FrutasTropicais()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}