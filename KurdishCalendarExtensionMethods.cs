namespace KurdishCalendar
{
    public static class KurdishCalendarExtensionMethods
    {

        internal static string[] kurdishMonth = { "نەورۆز", "گوڵان", "جۆزەردان", "پوشپەڕ", "گەلاوێژ", "خەرمانان","ڕەزبەر","گەڵاڕێزان","سەرماوەرز","بەفرانبار","ڕێبەندان","ڕەشيەمێ" };
        internal static string[] kurdishDayOfWeek = { "شەممە", "یەکشەممە", "دووشەممە", "سێ شەممە", "چوارشەممە", "پێنج شەممە", "هەینی" };
        
        public static string toKurdish(this DateTime dateTime)
        {
            Boolean IS_FIRST_YEAR_LEAP = false;
            Boolean IS_LAST_YEAR_LEAP = false;
            int TOTAL_DAY_OF_YEAR = 0;
            if(dateTime<=new DateTime(dateTime.Year,3,21))
            {

            }
            else
            {

            }
            return "";
        }
        public static string toKurdishDate(this DateTime dateTime)
        {
            DateTime __KurdishDateTime = dateTime.AddDays(255590);
            return $"{__KurdishDateTime.Year}-{__KurdishDateTime.Month}-{__KurdishDateTime.Day}";
        }
        public static string toKurdishDateVerbose(this DateTime datetime)
        {
            DateTime __kurdishDateTime = datetime.AddDays(255590);
            return $"{__kurdishDateTime.Year}-{kurdishMonth[__kurdishDateTime.Month-1]}-{__kurdishDateTime.Day}";
        }
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
        public static string MapToKurdish(this DateTime datetime)
        {
            DateTime FIRST_DAY_OF_KURDISH_YEAR;
            int KURDISH_YEAR_TOTAL_DAYS = 0;
           if(datetime>=new DateTime(datetime.Year, 3, 21))
            {
                FIRST_DAY_OF_KURDISH_YEAR=new DateTime(datetime.Year, 3, 21);
            }else
            {
                FIRST_DAY_OF_KURDISH_YEAR=new DateTime(datetime.Year-1, 3, 21);
            }
            KURDISH_YEAR_TOTAL_DAYS=(datetime-FIRST_DAY_OF_KURDISH_YEAR).Days+1;
            return new KurdishCalendar.KuridshDateTime(KURDISH_YEAR_TOTAL_DAYS).ToString();
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
    }
}