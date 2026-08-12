using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManoloContactos.Data;
using ManoloContactos.Models;

namespace ManoloContactos.Pages.Contactos;

[Authorize]
public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Contacto Contacto { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contacto = await _context.Contactos
            .FirstOrDefaultAsync(m => m.Id == id);

        if (contacto is not null)
        {
            Contacto = contacto;
            return Page();
        }

        return NotFound();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contacto = await _context.Contactos.FindAsync(id);

        if (contacto != null)
        {
            Contacto = contacto;
            _context.Contactos.Remove(Contacto);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}