namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int Count = 0;
            int number2 = number;
            int Gumar = 0;
            while (number2 > 0)
            {
                number2 = number2 / 10;
                Count++;
            }
            number2 = number;
            for(int i = 0; i < Count; i++)
            {
                Gumar = Gumar + (astijan(number2%10,Count));
                number2 = number2 / 10;
            }
            bool result = Gumar == number;
            Console.WriteLine(result);

        }
        static int astijan(int a,int b)
        {
            int z = 1;
            while (b > 0)
            {
                z = z * a;
                b--;
            }
            return z;
        }
    }
}