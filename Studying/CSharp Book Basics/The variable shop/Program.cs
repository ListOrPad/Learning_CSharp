namespace The_variable_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte int1 = 0;
            short int2 = -2;
            int int3 = -3;
            long int4 = -4;

            sbyte int5 = -42;  //from -128 to 128;

            //all types with 'u' can be twice as big as their parent but only positive
            ushort int6 = 1;
            uint int7 = 2;
            ulong int8 = 3;

            string text = "AB";
            char literal = 'C';

            double double0 = 0.1;
            float doubleF = 0.1F;               //all are doubles as the default but F or M makes it other type
            decimal doubleM = 0.1M;

            bool isBigger = true;

            Console.WriteLine($"Interegs: \n{int1}; {int2}; {int3}; {int4}; {int5}; {int6}; {int7}; {int8}");
            Console.WriteLine($"Real Numbers: \n{double0}; {doubleF}; {doubleM}; (all of those are float numbers" +
                                                                              $" are different types, check code)");
            Console.WriteLine($"Text: \n{text}; {literal}");
            Console.WriteLine($"Conditional: \n{isBigger}");
        }
    }
}