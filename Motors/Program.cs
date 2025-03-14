namespace Motors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statisztika statisztika = new Statisztika();
            statisztika.ReadFromFile("motors.txt");
            Console.WriteLine("Az összes motor ára egyben: " +statisztika.SumPrices() + "EUR");
            Console.WriteLine("Van e benne Bear 650: " + statisztika.Contains("Bear 650"));
            Console.WriteLine("Legöregebb motor:" + statisztika.OLdest());
            Console.WriteLine("yamaha motorok ára egyben: " +statisztika.SumBasedOnBrand("Aprilia", "motors.txt") + "EUR");
            statisztika.Sort();
        
        }
    }
}
