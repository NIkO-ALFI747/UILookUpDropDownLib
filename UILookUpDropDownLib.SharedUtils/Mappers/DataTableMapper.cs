using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace UILookUpDropDownLib.SharedUtils.Mappers
{
    public class DataTableMapper<TModel>
        where TModel : new()
    {
        public IEnumerable<TModel> MapToList(DataTable dataCollection)
        {
            if (dataCollection == null) return new List<TModel>();
            var resultList = new List<TModel>();
            var properties = typeof(TModel).GetProperties();
            foreach (DataRow row in dataCollection.Rows)
            {
                var item = MapDataRowToItem(row, properties, dataCollection.Columns);
                resultList.Add(item);
            }
            return resultList;
        }

        private TModel MapDataRowToItem(
            DataRow row,
            PropertyInfo[] properties,
            DataColumnCollection columns
            )
        {
            var item = new TModel();
            foreach (PropertyInfo prop in properties)
            {
                if (columns.Contains(prop.Name))
                {
                    object value = row[prop.Name];
                    SetValue(item, prop, value);
                }
            }
            return item;
        }

        private void SetValue(
            TModel item,
            PropertyInfo prop,
            object value
            )
        {
            if (value == DBNull.Value)
            {
                prop.SetValue(item, null, null);
            }
            else
            {
                ApplyValue(item, prop, value);
            }
        }

        private void ApplyValue(
            TModel item,
            PropertyInfo prop,
            object value
            )
        {
            var targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
            try
            {
                var convertedValue = Convert.ChangeType(value, targetType);
                prop.SetValue(item, convertedValue, null);
            }
            catch (Exception ex)
            {
                LogConversionError(prop.Name, targetType.Name, ex.Message);
            }
        }

        private void LogConversionError(
            string propertyName,
            string targetTypeName,
            string errorMessage
            )
        {
            Debug.WriteLine($"Error converting column '{propertyName}' " +
                $"to type '{targetTypeName}': {errorMessage}");
        }
    }
}
