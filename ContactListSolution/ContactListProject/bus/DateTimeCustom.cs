namespace ContactListProject.bus
{
    public class DateTimeCustom
    {
        private int day = 0;
        private int month = 0;
        private int year = 0;
        private int hour = 0;
        private int minute = 0;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }

        public DateTimeCustom() { }

        public DateTimeCustom(int month, int day, int year, int hour, int minute)
        {
            Month = month;
            Day = day;
            Year = year;
            Hour = hour;
            Minute = minute;
        }

        public override string ToString()
        {
            return $"{Month:D2}/{Day:D2}/{Year} {Hour:D2}:{Minute:D2}";
        }
    }
}
