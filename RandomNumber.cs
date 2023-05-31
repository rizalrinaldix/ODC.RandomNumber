namespace RandomNumber
{
    public class RandomNumber : IRandomNumber
    {
        private static Random? _random;

        public decimal GetRandomDecimal(decimal Min, decimal Max)
        {
            if (Min > Max || Min < 0)
            {
                throw new Exception("Input fields Exception: The min number is 0 and the max can't be lower than min!");
            }
            else
            {
                double min = (Double)Min;
                double max = (Double)Max;
                if (_random == null) _random = new Random();
                return (Decimal)(_random.NextDouble() * (max - min) + min);
            }
        }

        public int GetRandomInteger(int Min, int Max)
        {
            if (Min > Max || Min < 0)
            {
                throw new Exception("Input fields Exception: The min number is 0 and the max can't be lower than min!");
            }
            else
            {
                if (_random == null) _random = new Random();
                return _random.Next(Min, Max + 1);
            }
        }
    }
}