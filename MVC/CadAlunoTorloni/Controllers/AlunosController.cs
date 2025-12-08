
using System.Threading.Tasks;
using CadAlunoTorloni.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CadAlunoTorloni.Controllers
{
    public class AlunosController : Controller
    {
        // public static List<Aluno> alunos = new List<Aluno>
        // {
        //     new Aluno{ Id = 1, Nome = "Eduardo", Idade = 43},
        //     new Aluno{ Id = 2, Nome = "Pedro", Idade = 17},
        // };
        private readonly CadAlunoTorloniContext _context;
        private readonly ILogger<AlunosController> _logger;

        public AlunosController(ILogger<AlunosController> logger, CadAlunoTorloniContext context)
        {
            _logger = logger;
            _context = context; 
        }



        // public IActionResult Index()
        // {
        //     return View(alunos);
        // }
        public async Task<IActionResult> Index()
        {
            var alunos = await _context.Alunos.ToListAsync();
            return View(alunos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Aluno aluno)
        {

            
            _context.Add(aluno);//adiciona na memória da _context
            await _context.SaveChangesAsync();//salva no banco de dados
            
            return RedirectToAction(nameof(Index));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}



