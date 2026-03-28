using Microsoft.AspNetCore.Mvc;
using PortalCampanasComerciales.Models;
using PortalCampanasComerciales.Services;

namespace PortalCampanasComerciales.Controllers;

// === MODIFICADO EN RAMA feature/resumen-campanas - LÓGICA DE RESUMEN ===

public class CampanasController : Controller
{
    // Listado + Filtros
    public IActionResult Index(string? categoria, string? estado)
    {
        var campanas = CampanaService.Campanas.AsQueryable();

        if (!string.IsNullOrEmpty(categoria))
            campanas = campanas.Where(c => c.Categoria == categoria);

        if (!string.IsNullOrEmpty(estado))
            campanas = campanas.Where(c => c.Estado == estado);

        // Para llenar los dropdowns de filtros
        ViewBag.Categorias = CampanaService.Campanas
            .Select(c => c.Categoria)
            .Distinct()
            .OrderBy(c => c)
            .ToList();

        ViewBag.Estados = new List<string> { "Vigente", "Próxima", "Finalizada" };

        return View(campanas.ToList());
    }

    // Detalle de una campaña
    public IActionResult Detalle(int id)
    {
        var campana = CampanaService.Campanas.FirstOrDefault(c => c.Id == id);
        if (campana == null)
            return NotFound();

        return View(campana);
    }

    // Resumen con indicadores
    public IActionResult Resumen()
    {
        var campanas = CampanaService.Campanas;

        ViewBag.TotalCampanas = campanas.Count;
        ViewBag.Vigentes = campanas.Count(c => c.Estado == "Vigente");
        ViewBag.Proximas = campanas.Count(c => c.Estado == "Próxima");
        ViewBag.Finalizadas = campanas.Count(c => c.Estado == "Finalizada");
        ViewBag.PromedioDescuento = Math.Round(campanas.Average(c => c.DescuentoPct), 2);

        // Cantidad por canal
        ViewBag.PorCanal = campanas.GroupBy(c => c.Canal)
            .Select(g => new 
            { 
                Canal = g.Key, 
                Cantidad = g.Count() 
            })
            .ToList();

        return View();
    }
}