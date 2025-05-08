public class Program
{
    public static void Main(string[] args)
    {
        const int initialCandleCount = 5;
        const int numberOfPartsToMakeNewCandle = 2;
        var totalBurnableCandles = CalculateTotalNumberOfBurnableCandles(initialCandleCount, numberOfPartsToMakeNewCandle);

        Console.WriteLine($"The total number of candles you can burn is ({initialCandleCount}, {numberOfPartsToMakeNewCandle}) = {totalBurnableCandles}");
    }

    private static int CalculateTotalNumberOfBurnableCandles(
        int initialCandles,
        int numberOfPartsToMakeNewCandle,
        int totalBurnedCandles = 0,
        int numberOfLeftOvers = 0)
    {
        // Burn the candles
        totalBurnedCandles += initialCandles;
        numberOfLeftOvers += initialCandles;

        // Calculate the number of new candles that can be made from the burnt candles
        var newCandles = numberOfLeftOvers / numberOfPartsToMakeNewCandle;

        if (newCandles == 0)
        {
            // If there are no new candles, return the sum of burnt candles
            return totalBurnedCandles;
        }

        // If there are new candles, get the remaining leftovers and repeat the process
        numberOfLeftOvers %= numberOfPartsToMakeNewCandle;
        return CalculateTotalNumberOfBurnableCandles(
            newCandles,
            numberOfPartsToMakeNewCandle,
            totalBurnedCandles,
            numberOfLeftOvers);
    }
}
