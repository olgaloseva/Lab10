using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        //Угол задан целочисленными значениями градусов, угловых минут и угловых секунд.
        //Реализовать класс, в котором указанные значения представлены в виде свойств. 
        //Предусмотреть в свойствах проверку корректности данных.
        //Класс должен содержать конструктор и метод ToRadians для перевода угла в радианы.
        //В программе создать объект указанного класса и использовать его.
        static void Main(string[] args)
        {
            Console.WriteLine("ПЕРЕВОД УГЛА ИЗ ГРАДУСОВ В РАДИАНЫ");
            Console.WriteLine("___________________________________");
            Console.WriteLine();

            int gradusRead, minRead, secRead;

            do
            {
                Console.Write("Задайте угол ложительными числами: градусы - ");
                gradusRead = Convert.ToInt32(Console.ReadLine());
                Console.Write("угловые минуты - ");
                minRead = Convert.ToInt32(Console.ReadLine());
                Console.Write("угловые секунды - ");
                secRead = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            } while (gradusRead<0|| minRead<0|| secRead<0);

            Angle ang = new Angle(gradusRead, minRead, secRead);

            double radians = ang.ToRadians();
            Console.WriteLine("Угол в радианах составит: {0}", radians);
            Console.ReadKey();
        }
    }
}
