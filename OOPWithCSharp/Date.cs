namespace OOPWithCSharp
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
            set => _year = value;
        }

        public int Month
        {
            get => _month;
            set => _month = value;
        }

        public int Day
        {
            get => _day;
            set => _day = value;
        }
        #endregion

        #region Methods
        private int ValidateYear(int year)
        {
            throw new NotImplementedException();
        }
        private int ValidateMonth(int month)
        {
            throw new NotImplementedException();
        }
        private int ValidateDay(int day)
        {
            throw new NotImplementedException();
        }


        public override string ToString() => $"{Year,4:0000}/{Month,2:00}/{Day,2:00}"; 
        #endregion

    }
}
