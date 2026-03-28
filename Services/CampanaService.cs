using PortalCampanasComerciales.Models;

namespace PortalCampanasComerciales.Services;

public static class CampanaService
{
    public static List<Campana> Campanas { get; } = new List<Campana>
    {
        new Campana 
        { 
            Id = 1, 
            Nombre = "Black Friday 2026", 
            Categoria = "Electro", 
            Estado = "Vigente", 
            FechaInicio = new DateTime(2026, 3, 1), 
            FechaFin = new DateTime(2026, 3, 31), 
            DescuentoPct = 40, 
            Canal = "Web", 
            Descripcion = "Grandes descuentos en televisores, celulares y electrodomésticos" 
        },
        new Campana 
        { 
            Id = 2, 
            Nombre = "Cyber Days - Marzo", 
            Categoria = "Tecnología", 
            Estado = "Vigente", 
            FechaInicio = new DateTime(2026, 3, 20), 
            FechaFin = new DateTime(2026, 4, 10), 
            DescuentoPct = 35, 
            Canal = "App", 
            Descripcion = "Ofertas especiales en laptops, tablets y accesorios tecnológicos" 
        },
        new Campana 
        { 
            Id = 3, 
            Nombre = "Regreso a Clases 2026", 
            Categoria = "Hogar", 
            Estado = "Próxima", 
            FechaInicio = new DateTime(2026, 4, 5), 
            FechaFin = new DateTime(2026, 4, 25), 
            DescuentoPct = 25, 
            Canal = "Tienda", 
            Descripcion = "Descuentos en muebles, útiles escolares y decoración" 
        },
        new Campana 
        { 
            Id = 4, 
            Nombre = "Moda Otoño-Invierno", 
            Categoria = "Moda", 
            Estado = "Finalizada", 
            FechaInicio = new DateTime(2025, 11, 15), 
            FechaFin = new DateTime(2026, 2, 28), 
            DescuentoPct = 50, 
            Canal = "Web", 
            Descripcion = "Colección completa de ropa de temporada" 
        },
        new Campana 
        { 
            Id = 5, 
            Nombre = "Liquidación de Verano", 
            Categoria = "Electro", 
            Estado = "Finalizada", 
            FechaInicio = new DateTime(2025, 12, 1), 
            FechaFin = new DateTime(2026, 1, 31), 
            DescuentoPct = 60, 
            Canal = "Tienda", 
            Descripcion = "Últimas unidades de aire acondicionado y refrigeradoras" 
        }
    };
}