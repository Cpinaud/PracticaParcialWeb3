using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PruebaArtistas.Data.Entidades
{
    [ModelMetadataType(typeof(CantanteModelMetaData))]
    partial class Cantante
    {
        public Cantante()
        {

        }
    }

    public class CantanteModelMetaData
    {

        [Required(ErrorMessage ="Debe agregar un nombre")]
        [StringLength(50,MinimumLength =3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        public string? Nombre { get; set; } = null!;

        [Required(ErrorMessage = "Debe agregar una edad")]
        [Range(10,100,ErrorMessage = "La edad debe estar entre 10 y 100")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Debe agregar una descripcion")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "la descripcion debe tener entre 20 y 500 caracteres")]
        public string? Descripcion { get; set; } = null!;
    }
}
