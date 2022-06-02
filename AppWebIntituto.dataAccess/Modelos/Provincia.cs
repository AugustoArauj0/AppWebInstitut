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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        public int ProvinciaId { get; set; }
        public string? NombreProvincia { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string ObtenerProvincia()
        {
            return NombreProvincia;
        }
    }
}

