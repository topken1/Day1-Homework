using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Day1_Homework
{
    public class Calculate<T>
    {
        //private int SumOfProperty(IEnumerable<T> source, string propertyName)
        //{
        //    int result = 0;
        //    Type type = typeof(T);
        //    PropertyInfo propertyInfo = type.GetProperty(propertyName);
        //    if (propertyInfo != null && propertyInfo.PropertyType == typeof(int))
        //    {

        //        result = source.Sum(s => (int)propertyInfo.GetValue(s));
        //    }
        //    return result;
        //}

        public IEnumerable<int> SumOfPropertyGrupByNumber(IEnumerable<T> source, string propertyName, int groupNumber)
        {
            IEnumerable<int> result = null;
            List<T> listSource = source.ToList();
            Type type = typeof(T);
            PropertyInfo propertyInfo = type.GetProperty(propertyName);
            if (propertyInfo != null && propertyInfo.PropertyType == typeof(int))
            {
                result = listSource.GroupBy(g => (listSource.IndexOf(g) / groupNumber + 1))
                   .Select(o => o.Sum(s => (int)propertyInfo.GetValue(s)));
                    
            }
            return result;
        }
    }
}
