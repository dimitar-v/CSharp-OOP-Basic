using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        private DateTime startDate;
        private DateTime endDate;

        public DateModifier(string start, string end)
        {
            startDate = DateTime.Parse(start);
            endDate = DateTime.Parse(end);
        }

        public double DaysBetweenDate ()
        {
            return Math.Abs((startDate - endDate).TotalDays);
        }
    }
}
