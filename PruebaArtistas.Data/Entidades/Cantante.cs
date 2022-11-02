using System;
using System.Collections.Generic;

namespace PruebaArtistas.Data.Entidades
{
    public partial class Cantante
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Edad { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
