public class Sieve
{
    public delegate bool Sift(int number); //"просей"
    public static bool SieveEvens(int number) => number % 2 == 0;
    public static bool SieveAbsolutes(int number) => number > 0;
    public static bool SieveDecimals(int number) => number % 10 == 0;
    public Sift SieveValue { get; set; }
    public Sieve(Sift sieve)
    {
        SieveValue = sieve;      
    }
    public bool IsGood(int number)
    {
        bool verdict;

        verdict = SieveValue(number);
        return verdict;
    }
}