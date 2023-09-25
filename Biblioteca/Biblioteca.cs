using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public class Biblioteca
    {
        private List<Libro> libros;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
        }

        public List<Libro> getLibros()
        {
            return libros;
        }

        private Libro buscarLibro(string nombre)
        {
            
            Libro? l = null;
            int i = 0;
            while (i < libros.Count)
            {
                
                if (libros[i].getTitulo().Equals(nombre))
                {
                    l = libros[i];
                    i = libros.Count;
                }
                i++;
            }
            return l;
        }

        public bool agregarLibro(string nombre, string autor, string editorial)
        {
            bool resp = false;
            Libro l = buscarLibro(nombre);

            if (l == null)
            {
                
                l = new Libro(nombre, autor, editorial);
                libros.Add(l);
                resp = true;
            }
            return resp;
        }

        public bool eliminarLibro(string nombre, string autor, string editorial)
        {
            bool resp = false;
            Libro l = buscarLibro(nombre);
            if (l != null)
            {
                libros.Remove(l);
                resp = true;
            }
            return resp;
        }



    }
}
