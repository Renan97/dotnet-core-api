using System;
using System.Data;

namespace dotnet_core_api.Utils
{
    public class ConvertDatasetToClass
    {
        public ConvertDatasetToClass() { }
        public static int validateValue(DataRow row, string columnName, int defaultValue)
        {
            try
            {
                return (int)row[columnName];
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static string validateValue(DataRow row, string columnName, string defaultValue)
        {
            try
            {
                return row[columnName].ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}