public class DateForAlex
{
    internal void Exp8Caller() {

        CalculateDate();

        void CalculateDate()
        {
            Console.WriteLine($"{CalculateDay(07)}.{CalculateMonth(2)}.{CalculateYear(2222)}");
        }
        string CalculateDay(int dd)
        {
            int firstDayNum = 0;
            if (dd >= 10 & dd < 20)
                firstDayNum = 1;
            else if (dd >= 20 & dd < 30)
                firstDayNum = 2;
            else if (dd >= 30)
                firstDayNum = 3;
            int secondDayNum = dd - firstDayNum * 10;
            string decimalDay = $"{firstDayNum}{secondDayNum}";
            return decimalDay;
        }
        int CalculateMonth(int mm)
        {
            return 02;
        }
        int CalculateYear(int yyyy)
        {
            return 2022;
        }
    }
}