using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class Exlinq
    {
        public static IEnumerable<T> Filtro<T>( this IEnumerable<T> source, Func<T, bool> predicado)
        {
            foreach (var item in source)
            {
                if (predicado(item))
                {
                    yield return item; 
                }
            }
        }
    }
}
