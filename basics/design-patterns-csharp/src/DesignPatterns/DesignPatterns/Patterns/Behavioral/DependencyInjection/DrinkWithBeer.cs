namespace DesignPatterns.Patterns.Behavioral.DependencyInjection
{
    public class DrinkWithBeer
    {
        private Beer _beer;
        private decimal _water;
        private decimal _sugar;

        public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
        {
            _water = water;
            _sugar = sugar;
            _beer = beer;
        }

        public void Build()
        {
            Console.WriteLine($"Preparamos una cerveza {_beer.Name} que tiene {_water} unidades de agua y " +
                              $"{_sugar} de azúcar");
        }

    }
}
