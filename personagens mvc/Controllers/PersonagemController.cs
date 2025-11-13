using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using personagens_mvc.data;
using personagens_mvc.Models;

namespace personagens_mvc.Controllers
{
    public class PersonagemController : Controller
    {
        private readonly AppDbContext _context;
        public PersonagemController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }
        public async Task<IActionResult> Index()
        {
            var lista = await _context.tabelaPersonagem.ToListAsync();

            return View(lista);
        }
        [HttpGet]
        public IActionResult Criar() => View();
        [HttpPost]
        public async Task<IActionResult> Criar(string nomeConstrutor, int nivelConstrutor, string tipoConstrutor)
        {
            Personagem? novoPersonagem = null;

            if (tipoConstrutor == "Guerreiro")
            {
                novoPersonagem = new Guerreiro(nomeConstrutor, nivelConstrutor);
            }
            else if (tipoConstrutor == "Mago")
            {
                novoPersonagem = new Mago(nomeConstrutor, nivelConstrutor);
            }
            else
            {
                return BadRequest("Tipo de personagem invalido");
            }
            _context.tabelaPersonagem.Add(novoPersonagem);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> deletar(int id)
        {
            var personagem = await _context.tabelaPersonagem.FindAsync(id);

            if (personagem == null) return NotFound();

            _context.tabelaPersonagem.Remove(personagem);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}