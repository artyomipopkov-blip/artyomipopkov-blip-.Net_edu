using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Райнер Мария Рильке");
            Console.WriteLine("Читатель");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Кем он бывает, в чтенье погружён?");
            Console.WriteLine("В каких мирах витает, где границы");
            Console.WriteLine("Тех странных стран, что с каждою страницей");
            Console.WriteLine("Всё больше - быль и всё бесспорней - сон?");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("В кого перерождается на час?");
            Console.WriteLine("В какой он бездне и в каком полёте?");
            Console.WriteLine("И мать бы не сказала \"плоть от плоти\",");
            Console.WriteLine("и сына не признала бы сейчас.");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Но вот он кончил книгу. Все печали");
            Console.WriteLine("И радости, что пели за строкой,");
            Console.WriteLine("В глазах его волшебно засияли");
            Console.WriteLine("И льют - уже оттуда - пламень свой.");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("И он уже не тот, что был вначале:");
            Console.WriteLine("Чужие судьбы, став его судьбой,");
            Console.WriteLine("Призвав, его уводят за собой -");
            Console.WriteLine("Чтоб эти письмена ни означали.");

            Console.ResetColor();
        }
    }
}