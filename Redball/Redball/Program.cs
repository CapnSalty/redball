namespace Redball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            float piValue = 3.14f;
            Console.WriteLine(piValue);
            Console.WriteLine(piValue * 2);

            // width 4 unites wide
            // 8 units tall
            //define perimiter of rectangle
            // Rectangle measurements
            int width = 4;
            int height = 8;

            //Math
            int perimeter = width*2 + height*2;
            Console.WriteLine("The Perimeter of the Rectangle is " + perimeter);



        }
    }
}
