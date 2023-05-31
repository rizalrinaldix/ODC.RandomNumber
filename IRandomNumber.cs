using OutSystems.ExternalLibraries.SDK;

namespace RandomNumber
{
    [OSInterface]
    public interface IRandomNumber
    {
        [OSAction(ReturnName ="RandomInteger")]
        public int GetRandomInteger(int Min, int Max);


        [OSAction(ReturnName = "RandomDecimal")]
        public decimal GetRandomDecimal(decimal Min, decimal Max);
    }
}
