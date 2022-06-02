using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppWebInstitut.DataAccess.Modelos
{
    public class Localidad
    {
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        public int LocalidadId { get; set; }
        public string? NombreLocalidad { get; set; }
        public string? CodigoPostal { get; set; }
        public int ProvinciaId { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string ObtenerLocalidad()
        {
            return NombreLocalidad;
        }
        public string ObtenerCP()
        {
            return CodigoPostal;
        }
    }
}
