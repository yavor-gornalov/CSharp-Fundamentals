using System;
using System.Globalization;
/*
1.05.2016
15.05.2016
----------
1.5.2016
2.5.2016
----------
15.5.2020
10.5.2020
----------
22.2.2020
1.3.2020
 */

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = System.DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = System.DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        }

        Console.WriteLine(holidaysCount);
    }
}