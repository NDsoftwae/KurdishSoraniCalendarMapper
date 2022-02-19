namespace KurdishCalendar
{
    public static class KurdishCalendarExtensionMethods
    {

        internal static string[] kurdishMonth = { "نەورۆز", "گوڵان", "جۆزەردان", "پوشپەڕ", "گەلاوێژ", "خەرمانان","ڕەزبەر","گەڵاڕێزان","سەرماوەرز","بەفرانبار","ڕێبەندان","ڕەشيەمێ" };
        internal static string[] kurdishDayOfWeek = { "شەممە", "یەکشەممە", "دووشەممە", "سێ شەممە", "چوارشەممە", "پێنج شەممە", "هەینی" };
        
        public static Boolean isLeapYear(this DateTime dateTime)
        {
            try
            {
                if (dateTime.Year%400==0 || (dateTime.Year%4==0 && dateTime.Year%100!=0))
                    return true;
                return false;
            }
            catch
            {
                throw new Exception();
            }
        }
       
        public static int getTotalKurdishDay(this DateTime datetime)
        {
            DateTime FIRST_DAY_OF_KURDISH_YEAR;
            int KURDISH_YEAR_TOTAL_DAYS = 0;
            if (datetime>=new DateTime(datetime.Year, 3, 21))
            {
                FIRST_DAY_OF_KURDISH_YEAR=new DateTime(datetime.Year, 3, 21);
            }
            else
            {
                FIRST_DAY_OF_KURDISH_YEAR=new DateTime(datetime.Year-1, 3, 21);
            }
            KURDISH_YEAR_TOTAL_DAYS=(datetime-FIRST_DAY_OF_KURDISH_YEAR).Days+1;
            return KURDISH_YEAR_TOTAL_DAYS;
        }
        public static DateTime getFirstKurdishDateStart(this DateTime datetime)
        {
            DateTime FIRST_DAY_OF_KURDISH_YEAR;
            if (datetime>=new DateTime(datetime.Year, 3, 21))
            {
                FIRST_DAY_OF_KURDISH_YEAR=new DateTime(datetime.Year, 3, 21);
            }
            else
            {
                FIRST_DAY_OF_KURDISH_YEAR=new DateTime(datetime.Year-1, 3, 21);
            }
            return FIRST_DAY_OF_KURDISH_YEAR;
        }
        public static int mapKurdishYear(this DateTime datetime)
        {
            DateTime FIRST_DAY_OF_KURDISH_YEAR;
            if (datetime>=new DateTime(datetime.Year, 3, 21))
            {
                FIRST_DAY_OF_KURDISH_YEAR=new DateTime(datetime.Year, 3, 21);
            }
            else
            {
                FIRST_DAY_OF_KURDISH_YEAR=new DateTime(datetime.Year-1, 3, 21);
            }
            return FIRST_DAY_OF_KURDISH_YEAR.Year+700;
        }
        public static KurdishCalendar.KuridshDateTime toKurdish(this DateTime datetime)
        {
            return new KurdishCalendar.KuridshDateTime(datetime);
        }
        public static String tokurdishString(this DateTime datetime)
        {
            return new KurdishCalendar.KuridshDateTime(datetime).ToString();
        }
    }
}