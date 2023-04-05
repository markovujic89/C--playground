namespace Definition.Structures
{
    public struct Price : IPrice
    {
        private int _minPrice;

        private int _maxPrice;

        public Price(int minPrice, int maxPrice)
        {
            _minPrice = minPrice;
            _maxPrice = maxPrice;
        }

        public int MinPrice { get { return _minPrice; } }

        public int MaxPrice { get { return _maxPrice; } }

        public double CalculatePrice(int minPrice, int maxPrice)
        {
            return ((minPrice + maxPrice) / 2)*1.2;
        }
    }
}
