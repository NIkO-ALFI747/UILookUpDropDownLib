using System.Collections.Generic;
using System.Reflection;

namespace UILookUpDropDownLib.SharedUtils.Mappers
{
    public class DictionaryMapper<TModel>
    {
        public Dictionary<string, object> MapToDictionary(TModel source)
        {
            if (source == null)
            {
                return new Dictionary<string, object>();
            }
            var properties = GetPublicInstanceProperties();
            return MapPropertiesToDictionary(source, properties);
        }

        private PropertyInfo[] GetPublicInstanceProperties()
        {
            return typeof(TModel).GetProperties(
                BindingFlags.Public | BindingFlags.Instance
            );
        }

        private Dictionary<string, object> MapPropertiesToDictionary(
            TModel source,
            PropertyInfo[] properties
            )
        {
            var dictionary = new Dictionary<string, object>();
            foreach (var prop in properties)
            {
                AddPropertyValueToDictionary(source, prop, dictionary);
            }
            return dictionary;
        }

        private void AddPropertyValueToDictionary(
            TModel source,
            PropertyInfo prop,
            Dictionary<string, object> dictionary
            )
        {
            object value = prop.GetValue(source);
            dictionary.Add(prop.Name, value);
        }
    }
}
