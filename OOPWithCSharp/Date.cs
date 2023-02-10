namespace OOPWithCSharp
{
    public class Date
    {
        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }


        public override string ToString()
        {
            return $"{Year, 4:0000}/{Month, 2:00}/{Day, 2:00}";
        }

    }
}
