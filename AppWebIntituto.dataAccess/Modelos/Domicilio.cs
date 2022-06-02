using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppWebInstitut.DataAccess.Modelos
{
    public class Domicilio
    {
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        public int DomicilioId { get; set; }
        public string? Calle { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public string? Departamento { get; set; }
        public string? Barrio { get; set; }
        public string? Manzana { get; set; }
        public int Casa { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string ObtenerCalle()
        {
            return Calle;
        }
        public int ObtenerNroCalle()
        {
            return Numero;
        }
        public int ObtenerPiso()
        {
            return Piso;
        }
        public string ObtenerDepartamento()
        {
            return Departamento;
        }
        public string ObtenerBarrio()
        {
            return Barrio;
        }
        public string ObtenerManzana()
        {
            return Manzana;
        }
        public int ObtenerCasa()
        {
            return Casa;
        }
    }
}