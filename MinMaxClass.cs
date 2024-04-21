using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6dom
{
    public static class MinMaxClass
    {
        public static (U min, U max) MinMax<T, U>(this IEnumerable<T> collection, Func<T, U> funkcja) where U : IComparable<U>
        {
            U? fMin = default(U);
            U? fMax = default(U);

            if (collection == null) throw new ArgumentNullException(nameof(collection));
            fMin = funkcja(collection.First());
            fMax = funkcja(collection.First());

            foreach (T item in collection)
            {
                U val = funkcja(item);
                if (val.CompareTo(fMin) < 0)
                {
                    fMin = val;
                }
                if (val.CompareTo(fMax) > 0)
                {
                    fMax = val;
                }

            }
            return (fMin, fMax);
        }
    }
}
