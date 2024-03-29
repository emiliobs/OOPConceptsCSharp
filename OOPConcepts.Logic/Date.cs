﻿namespace OOPConcepts.Logic
{
    public class Date
    {

        #region Attributes
        private int _year;

        private int _month;

        private int _day;

        #endregion


        #region Contructors
        public Date()
        {
            _year = 1900;
            _month = 1;
            _day = 1;
        }

        public Date(int year, int month, int day)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day);
        }
        #endregion


        #region Properties
        public int Year
        {
            get => _year;
            set => _year = ValidateYear(value);
        }

        public int Month
        {
            get => _month;
            set => _month = ValidateMonth(value);
        }

        public int Day
        {
            get => _day;
            set => _day = ValidateDay(value);
        }
        #endregion

        #region Methods
        public override string ToString() => $"{Year,4:0000}/{Month,2:00}/{Day,2:00}";

        private int ValidateYear(int year)
        {
            if (year < 0)
            {
                throw new ArgumentException("The year is invalid.");
            }

            return year;
        }
        private int ValidateMonth(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentException("The month is no valid.");
            }

            return month;
        }
        private int ValidateDay(int day)
        {
            if ((day == 29 && _month == 2 && IsLeapYear(_year)))
            {
                return day;
            }

            if ((day >= 1 && day <= 28 && _month == 2) ||
                (day >= 1 && day <= 30 && (_month == 4 || _month == 6 || _month == 9 || _month == 11)) ||
                (day >= 1 && day <= 31 && (_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12)))
            {
                return day;
            }

            throw new ArgumentException("The day is not valid");
        }

        // calculate the busiest year short code
        private bool IsLeapYear(int year)
        {
            return (year % 400 == 0 || year % 4 == 0 && year % 100 != 0);
        }

        // calculate the busiest year large code
        //private bool IsLeapYear(int year)
        //{
        //    if (year % 4 == 0)
        //    {
        //        if (year % 100 == 0)
        //        {
        //            if (_year % 400 == 0)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        #endregion

    }
}
