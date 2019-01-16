using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Common.Extentions
{
    public static class DateTimeExtextions
    {
        public static Dictionary<int, string> GetFullMonthNames()
        {
            return CultureInfo.CurrentUICulture.DateTimeFormat.MonthNames
                .TakeWhile(m => m != string.Empty)
                .Select((m, i) => new { Key = i + 1, Value = m })
                .ToDictionary(t => t.Key, t => t.Value);
        }

        public static DateTime StartOfMonth(this DateTime input)
        {
            return new DateTime(input.Year, input.Month, 1);
        }

        public static DateTime EndOfMonth(this DateTime input)
        {
            return new DateTime(input.Year, input.Month, DateTime.DaysInMonth(input.Year, input.Month));
        }
    }
}
