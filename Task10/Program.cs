using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительные значения. Отрицательные значения будут менять знак на +");
            Console.WriteLine("Градусов:");
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минут:");
            int minute_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Секунд:");
            int second_ = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(gradus_, minute_, second_);

            Console.WriteLine("{0} градусов, {1} минут, {2} секунд", angle.Gradus, angle.Minute, angle.Second);
            
            double radian = angle.ToRadians();
            Console.WriteLine(radian);
            Console.ReadKey();

        }
       
    }
}
