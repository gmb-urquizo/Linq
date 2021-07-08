using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Libro> arrayLibros = new Libro[]
            {
                new Libro(1, "Poeta en new york", "Federico"),
                new Libro(2, "Los asesinos del emperador", "Santiago"),
                new Libro(3, "Circo maximo", "Santiago"),
                new Libro(4, "El origen perdido", "Federico")
            };

            var libros = from libro in arrayLibros
                         where libro.Autor == "Santiago"
                         select libro;

            IEnumerable<Libro> librosExtension = arrayLibros.Filtro(a => a.Autor == "Santiago");

            Libro ultimo = arrayLibros.LastOrDefault(a => a.Id == 0);

            Libro librosFirstDefault = arrayLibros.SingleOrDefault(a => a.Id == 0);

            var agrupacion = arrayLibros.GroupBy(a => a.Autor);

            foreach (var autorLibro in agrupacion)
            {
                Console.WriteLine(autorLibro.Key);

                foreach (var libro in autorLibro)
                {
                    Console.WriteLine(libro.Titulo);
                }
            }
        }

    }
}
