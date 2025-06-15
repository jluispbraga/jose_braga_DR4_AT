using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace AgenciaTurismo.Web.Pages.Notas
{
    public class ViewNotesModel : PageModel
    {
        private readonly IWebHostEnvironment _env;

        [BindProperty]
        public string NovaNota { get; set; } = string.Empty;

        public List<string> ArquivosNotas { get; set; } = new();

        public string? ConteudoNotaSelecionada { get; set; }

        public ViewNotesModel(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void OnGet(string? fileName)
        {
            var dir = Path.Combine(_env.WebRootPath, "files");

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            ArquivosNotas = Directory.GetFiles(dir, "*.txt")
                .Select(Path.GetFileName)
                .Where(name => name != null)
                .Cast<string>()
                .ToList();
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(NovaNota))
            {
                ModelState.AddModelError(nameof(NovaNota), "O conteúdo da nota não pode ser vazio.");
                OnGet(null);
                return Page();
            }

            var nomeArquivo = $"Nota_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            var dir = Path.Combine(_env.WebRootPath, "files");
            Directory.CreateDirectory(dir);

            var caminhoArquivo = Path.Combine(dir, nomeArquivo);
            System.IO.File.WriteAllText(caminhoArquivo, NovaNota);

            return RedirectToPage();
        }
    }
}