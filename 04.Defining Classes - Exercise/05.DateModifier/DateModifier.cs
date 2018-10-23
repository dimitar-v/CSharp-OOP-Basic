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
            this.StartDate = DateTime.Parse(start);
            this.EndDate = DateTime.Parse(end);
        }

        public DateTime StartDate
        {
            get => this.startDate;
            set => this.startDate = value;
        }

        public DateTime EndDate
        {
            get => this.endDate;
            set => this.endDate = value;
        }

        public double DaysBetweenDate ()
        {
            return Math.Abs((startDate - endDate).TotalDays);
        }
    }
}
