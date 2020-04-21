using System;
using System.Collections.Generic;
using System.Text;

namespace Benchmark_Test
{

    //2019-12
    class DateParser
    {
        public int GetYearFromDateTime(string dateTimeAsString)
        {
            var dateTime = DateTime.Parse(dateTimeAsString);

            return dateTime.Year;
        }

        public int GetYearFromSplit(string dateTimeAsString)
        {
            var x = dateTimeAsString.Split('-');
            return int.Parse(x[0]);
        }

        public int GetYearFromSubstring(string dateTimeAsString)
        {
            var indexOfHyhen = dateTimeAsString.IndexOf('-');
            return int.Parse(dateTimeAsString.Substring(0, indexOfHyhen));
        }

        public int GetYearFromSpan(ReadOnlySpan<char> dateTimeAsString)
        {
            var indexOfHyphen = dateTimeAsString.IndexOf('-');
            return int.Parse(dateTimeAsString.Slice(0, indexOfHyphen));
        }
    }
}
