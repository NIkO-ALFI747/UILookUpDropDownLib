using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace UILookUpDropDownLib.SharedUtils.TypeConverters
{
    public class ClassTypeToStringTypeConverter<TClass> : TypeConverter
        where TClass : class
    {
        private bool IsTypeValid(Type type)
        {
            if (type == null ||
                !type.IsClass ||
                type.IsAbstract ||
                type.IsGenericTypeDefinition ||
                type.ContainsGenericParameters)
            {
                return false;
            }
            if (type == typeof(TClass)) return false;
            if (type.FullName != null &&
               (type.FullName.StartsWith("C1.") || type.FullName.StartsWith("System.")))
            {
                return false;
            }
            return type.IsSubclassOf(typeof(TClass));
        }

        private List<string> GetAvailableClassNames(ITypeDescriptorContext context)
        {
            var uniqueTypes = new HashSet<string>();

            if (context != null)
            {
                var discoveryService = context.GetService(typeof(ITypeDiscoveryService)) as ITypeDiscoveryService;
                if (discoveryService != null)
                {
                    var classTypes = discoveryService.GetTypes(typeof(TClass), false);
                    foreach (Type type in classTypes)
                    {
                        if (IsTypeValid(type))
                        {
                            uniqueTypes.Add(type.FullName);
                        }
                    }
                }
            }

            try
            {
                PopulateUniqueTypesFromAssemblies(uniqueTypes);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in {nameof(PopulateUniqueTypesFromAssemblies)}: {ex.Message}");
            }

            return uniqueTypes.OrderBy(name => name).ToList();
        }

        private void PopulateUniqueTypesFromAssemblies(HashSet<string> uniqueTypes)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                if (ShouldSkipAssembly(assembly)) continue;

                var typesInAssembly = GetTypesFromAssembly(assembly);

                foreach (var type in typesInAssembly)
                {
                    if (IsTypeValid(type))
                    {
                        uniqueTypes.Add(type.FullName);
                    }
                }
            }
        }

        private bool ShouldSkipAssembly(Assembly assembly)
        {
            if (assembly.IsDynamic) return true;

            string fullName = assembly.FullName;

            return fullName.StartsWith("System") ||
                   fullName.StartsWith("Microsoft") ||
                   fullName.StartsWith("mscorlib") ||
                   fullName.StartsWith("C1.") ||
                   fullName.StartsWith("DevExpress.") ||
                   fullName.StartsWith("Newtonsoft");
        }

        private Type[] GetTypesFromAssembly(Assembly assembly)
        {
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
                return ex.Types.Where(t => t != null).ToArray();
            }
            catch
            {
                return Array.Empty<Type>();
            }
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true;

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true;

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<string> availableClassNames = GetAvailableClassNames(context);
            var listWithNone = new List<string> { "(None)" };
            listWithNone.AddRange(availableClassNames);

            return new StandardValuesCollection(listWithNone);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string stringValue)
            {
                return stringValue == "(None)" ? string.Empty : stringValue;
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                var stringValue = value as string;
                return string.IsNullOrEmpty(stringValue) ? "(None)" : stringValue;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
