using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Day1_Homework
{
    public class Calculate<T>
    {

        public IEnumerable<int> SumOfPropertyGrupByNumber(IEnumerable<T> source, string propertyName, int groupNumber)
        {
            IEnumerable<int> result = null;
            List<T> listSource = source.ToList();
            var propertyInfo = typeof(T).GetProperty(propertyName);
            if (propertyInfo != null && propertyInfo.PropertyType == typeof(int))
            {
                result = listSource.GroupBy(g => (listSource.IndexOf(g) / groupNumber + 1))
                   .Select(o => o.Sum(s => (int)propertyInfo.GetValue(s)));
                    
            }
            return result;
        }
    }
}
