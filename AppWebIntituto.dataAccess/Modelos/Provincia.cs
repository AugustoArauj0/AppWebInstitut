using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppWebInstitut.DataAccess.Modelos
{
    public class Provincia
    {
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        [DataType(DataType.Text)]
        public int ProvinciaId { get; set; }

        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        [DataType(DataType.Text)]
        public string? NombreProvincia { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        public DateTime FechaActualizacion { get; set; }

    }
}

