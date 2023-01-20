using System;
using System.Collections.Generic;

namespace MiproyectoMVC.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string? Nombre { get; set; }

    public string? Identificador { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
