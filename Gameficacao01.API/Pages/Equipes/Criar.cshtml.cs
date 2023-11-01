using Gameficacao01.API.Data;
using Gameficacao01.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Gameficacao01.API.Pages.Equipes
{
    public class Criar : PageModel
    {
        private readonly AppDbContext _context;

        public Criar(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EquipeModel Equipe { get; set; }

        public List<SelectListItem> Projetos { get; set; }
public List<SelectListItem> MembrosOpcoes { get; set; } = new List<SelectListItem>();

        public void OnGet()
        {
            Projetos = _context.Projetos.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Nome
            }).ToList();

            MembrosOpcoes = _context.Membros.Select(m => new SelectListItem
            {
                Value = m.Id.ToString(),
                Text = m.Nome
            }).ToList();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Equipes.Add(Equipe);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
