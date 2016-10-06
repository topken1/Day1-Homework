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
            if (propertyInfo == null)
            {
                throw new MissingMemberException(string.Format("PropertyName:{0}", propertyName));
            }
            if (propertyInfo.PropertyType != typeof(int))
            {
                throw new TypeLoadException("mustBeInt");
            }
            result = listSource.GroupBy(g => (listSource.IndexOf(g) / groupNumber + 1))
                   .Select(o => o.Sum(s => (int)propertyInfo.GetValue(s)));
        
            return result;
        }
    }
}
