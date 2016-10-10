using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Day1_Homework
{

    public static class CalculateExtension
    {
        public static IEnumerable<int> GetSum<TSource>(this IEnumerable<TSource> source, int groupNumber, Func<TSource, int> selector)
        {

            var index = 0;
            while (index <= source.Count())
            {
                if( groupNumber == 0)
                {
                    throw new OutOfMemoryException("GroupNumber is Nero");
                }
                yield return source.Skip(index).Take(groupNumber).Sum(selector);
                index += groupNumber;
            }
        }
    }
    
}
