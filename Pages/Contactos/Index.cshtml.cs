using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManoloContactos.Data;
using ManoloContactos.Models;
using Microsoft.AspNetCore.Authorization;

namespace ManoloContactos.Pages.Contactos;

[Authorize]
public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Contacto> Contacto { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Contacto = await _context.Contactos.ToListAsync();
    }
}