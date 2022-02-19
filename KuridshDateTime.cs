using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurdishCalendar
{
    public class KuridshDateTime
    {

        private  string[] KURDISH_MONTHS = { "نەورۆز","گوڵان","جۆزەردان","پوشپەڕ","گەڵاوێژ","خەرمانان","ڕەزبەر","گەڵاڕێزان","سەرماوەرز","بەفرانبار","ڕێبەندان","ڕەشەمێ"}; 
        private int day { set; get; }
        private int month { set; get; }
        private int year { set; get; }

        private Func<int,int,int, (int,int,int)> CALCULATE_DAY_PER_YEAR =(x,y,z) =>{
            int year = 1;
            int month = (int)Math.Floor((decimal)(x-1)/y)+1;
            int days= x%y;
            days=days==0?y: days;
            return (year,month+z,days);
        };
        private Func<int,int,int, int, (int,int, int)> CALCULATE_DAY_PER_YEAR_TOTAL = (year,x,y,z) => {
            int month = (int)Math.Floor((decimal)(x-1)/y)+1;
            int days = x%y;
            days=days==0 ? y : days;
            return (year,month+z, days);
        };

        public KuridshDateTime(int totaldays) => (this.year, this.month, this.day)= totaldays switch
        {
            var x when x<=186 => CALCULATE_DAY_PER_YEAR(x, 31, 0),
            var x when x>186 => CALCULATE_DAY_PER_YEAR(x-186, 30, 6),
            _ => (1, 1, 1)
        };
        public KuridshDateTime(DateTime datetime) => (this.year, this.month, this.day)=datetime.getTotalKurdishDay() switch
        {
            var x when x<=186 => CALCULATE_DAY_PER_YEAR_TOTAL(datetime.mapKurdishYear(),x, 31, 0),
            var x when x>186 => CALCULATE_DAY_PER_YEAR_TOTAL(datetime.mapKurdishYear(),x-186, 30, 6),
            _ => (1, 1, 1)
        };

       
        public override string ToString() => $"{this.year} - {KURDISH_MONTHS[this.month-1]} - {this.day} ";
        
    }
}
