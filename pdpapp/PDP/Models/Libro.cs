using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDP.Models
{
    internal class Libro
    {
        private String Autor{  get; set; }
        private String Titulo { get; set; }
        private uint Paginas { get; set; }
        private String Editorial { get; set; }
        private uint AnoPublicacion{  get; set; }
    }
}
