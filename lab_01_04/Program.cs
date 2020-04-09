using System;

namespace lab_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double p;
            double side;
            double s;
            string temp;
            Console.WriteLine("Enter P");
            try
            {
                temp = Console.ReadLine();
                p = double.Parse(temp);
                side = p / 3;
                p = p / 2;
                s = Math.Sqrt(p * (p - side) * (p - side) * (p - side));
                Console.WriteLine("{0:f2}\t{1:f2}", side, s);
             }catch(Exception e)
            {
                Console.WriteLine("Exeption: {0}", e.Message);
            }
        }
    }
}
