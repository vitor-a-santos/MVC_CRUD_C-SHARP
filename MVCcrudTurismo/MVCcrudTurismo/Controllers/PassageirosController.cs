using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCcrudTurismo.Models;

namespace MVCcrudTurismo.Controllers
{
    public class PassageirosController : Controller
    {
        private readonly PassageiroContext _context;

        public PassageirosController(PassageiroContext context)
        {
            _context = context;
        }

        // GET: Passageiros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Passageiros.ToListAsync());
        }

       

        // GET: Passageiros/Create
        public IActionResult CreateAndUpdate(int id=0)
        {
            if (id == 0)
                return View(new Passageiro());
            else
                return View(_context.Passageiros.Find(id));
        }

        // POST: Passageiros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAndUpdate([Bind("PassageiroId,NomePassageiro,CpfPassageiro,Pagamento,Destino")] Passageiro passageiro)
        {
            if (ModelState.IsValid)
            {
                if (passageiro.PassageiroId == 0)
                    _context.Add(passageiro);
                else
                    _context.Update(passageiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(passageiro);
        }

      
        

        // GET: Passageiros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            var passageiro = await _context.Passageiros.FindAsync(id);
            _context.Passageiros.Remove(passageiro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        

      
    }
}
