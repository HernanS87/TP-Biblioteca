using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        private string nombre;
        private string autor;
        private string editorial;
        public Libro(string nombre, string autor, string editorial)
        {
            this.nombre = nombre;
            this.autor = autor;
            this.editorial = editorial;
        }

        public string getTitulo()
        {
            return nombre;
        }
        public override string ToString()
        {
            return $"El nombre del libro es {nombre} su autor {autor} y editorial: {editorial}";
        }

       
       
    }
}
