using System;
using System.Collections.Generic;

namespace MiproyectoMVC.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public int? IdCategoria { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Estado { get; set; }

    public virtual Categorium? IdCategoriaNavigation { get; set; }
}
