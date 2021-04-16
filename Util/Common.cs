using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanlyKho.Util
{
    public class Common
    {
        public static string GetResouceString(string key)
        {
            try
            {
                return ResourceUtil.Instance.GetString(key);
            }
            catch 
            {
                return "";
            }
        }
        public static decimal GetDefaultDecimalValue(object value)
        {
            try
            {
                if (value == null || string.IsNullOrEmpty(value.ToString()))
                    return 0m;
                return Convert.ToDecimal(value);
            }
            catch 
            {
                return 0m;
            }
        }
        public static Nullable<decimal> GetDecimalValue(string value)
        {
            try
            {
                if (value == "")
                    return null;
                return Convert.ToDecimal(value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Nullable<double> GetDoubleValue(string value)
        {
            try
            {
                if (value == "")
                    return null;
                return Convert.ToDouble(value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static double GetDefaultDoubleValue(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return 0d;
                return Convert.ToDouble(value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string GetStringValue(object value)
        {
            try
            {
                if (value == null)
                    return "";
                return value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Nullable<int> GetIntValue(string value)
        {
            try
            {
                if (value == "")
                    return null;
                return Convert.ToInt32(value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetInvoiceNo(string prefix, DateTime dt)
        {
            return prefix + string.Format("{0:yyyyMM}", dt); 
        }
        public static string GetShortDate(Nullable<DateTime> dt)
        {
            if (dt == null)
                return "";
            else
                return dt.Value.ToString("dd/MM/yyyy");
        }
        public static string GetMoney(decimal? money)
        {
            if (money == null)
                return "0";
            return String.Format("{0:0,00}", money);
        }
    }
}
