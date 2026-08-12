using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManoloContactos.Data;
using ManoloContactos.Models;

namespace ManoloContactos.Pages.Contactos;

[Authorize]
public class DetailsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DetailsModel(ApplicationDbContext context)
    {
        _context = context;
    }

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
}