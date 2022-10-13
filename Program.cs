
namespace C_Sharp_Otus
{
    class Program
    {
        static void Main()
        {
            Matrix m1 = new Matrix(1, 2, 3, 4);
            Console.WriteLine(m1);
            Matrix m2 = new Matrix(1, 2, 3, 4);
            Console.WriteLine(m2);
            Console.WriteLine(-m1);
        }
    }
}