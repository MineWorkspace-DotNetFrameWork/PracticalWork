using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork
{
    struct DateFormat
    {
        public int year;
        public int month;
        public int day;
    }
    class Date
    {
        public DateFormat DateFormat = new DateFormat();
        public Date(string date)
        {
            string[] splitter = date.Split(".");
            DateFormat.year = Convert.ToInt32(splitter[0]);
            DateFormat.month = Convert.ToInt32(splitter[1]);
            DateFormat.day = Convert.ToInt32(splitter[2]);
        }
        public Date(int year, int month, int day)
        {
            DateFormat.year = year;
            DateFormat.month = month;
            DateFormat.day = day;
        }
        public Date(DateTime dateTime)
        {
            dateTime = DateTime.Now;
        }
        public int CalcDate(int days)
        {
            int result = DateFormat.day + days;
            if (result > 31)
                DateFormat.month++;
            if (result > 365)
                DateFormat.year++;
            return result;
        }
        public int MinusCalcDate(int days)
        {
            int result = DateFormat.day - days;
            if (result < 0)
                DateFormat.month--;
            if (result < -30)
                DateFormat.month = DateFormat.month - 2;
            return result; 
        }
        public bool LeapYear()
        {
            if(DateFormat.year % 4 == 0)
            {
                if (DateFormat.year % 100 == 0)
                {
                    if (DateFormat.year % 400 == 0)
                        return true; // Год высокосный
                    else
                        return false; // не высокосный
                }
                else
                    return true;// высокосный
            }
            else
                return false;// не высокосный
        } // проверка на высокосность
        // Присваивание отдельных частей
        public void AddYear(int years)
        {
            DateFormat.year += years;
        }
        public void AddMonth(int months)
        {
            DateFormat.month += months;
        }
        public void AddDay(int days)
        {
            DateFormat.day += days;
        }
        // Сравнивание и отличие дат
        public void CompareDate(DateTime dateTime)
        {
            int date1 = DateFormat.year + DateFormat.month + DateFormat.day;
            int date2 = dateTime.Year + dateTime.Month + dateTime.Day;
            // Можно так
            if (date1 > date2)
                Console.WriteLine("\n Дефолтная дата больше указываемой");
            else
                Console.WriteLine("\n Дефолтная дата меньше указываемой");
            if(date1 == date2)
                Console.WriteLine("\n Дефолтная дата равна указываемой");
            // А можно так
            /*
            // По годам
            if (DateFormat.year > dateTime.Year)
                Console.WriteLine($"{DateFormat.year} > {dateTime.Year}");
            if (DateFormat.year < dateTime.Year)
                Console.WriteLine($"{DateFormat.year} < {dateTime.Year} ");
            // По месяцам
            if (DateFormat.year == dateTime.Year)
            {
                if (DateFormat.month > dateTime.Month)
                    Console.WriteLine($"{DateFormat.year}.{DateFormat.month} > {dateTime.Year}.{dateTime.Month} ");
                else
                    Console.WriteLine($"{DateFormat.year}.{DateFormat.month} < {dateTime.Year}.{dateTime.Month} ");
            }
            // По месяцам
            if (DateFormat.year == dateTime.Year)
            {
                if (DateFormat.month == dateTime.Month)
                { 
                    if(DateFormat.day > dateTime.Day)
                        Console.WriteLine($"{DateFormat.year}.{DateFormat.month}.{DateFormat.day} > {dateTime.Year}.{dateTime.Month}{dateTime.Day} ");
                    else
                        Console.WriteLine($"{DateFormat.year}.{DateFormat.month}.{DateFormat.day} < {dateTime.Year}.{dateTime.Month}{dateTime.Day} ");
                }
            }
            // Даты идентичны
            if (DateFormat.year == dateTime.Year)
            {
                if (DateFormat.month == dateTime.Month)
                {
                    if (DateFormat.day == dateTime.Day)
                        Console.WriteLine("\n Dates is identical");
                }
            }*/
        }
        public void Difference(DateTime dateTime)
        {
            int date1 = DateFormat.year + DateFormat.month + DateFormat.day;
            int date2 = dateTime.Year + dateTime.Month + dateTime.Day;

            int result = date1 - date2;
            if (result < 0)
                Console.WriteLine($" Вводимая дата больше дефолтной на {result} дней (со знаком +)");
            else
                Console.WriteLine($" Вводимая дата меньше дефолтной на {result} дней");
        }
    }
}
