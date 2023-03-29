using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Read in the size of the room
            Console.WriteLine("Odanın kenar uzunluklarını aralarında boşluk bırakarak giriniz.(örnek 5 5))");
            string[] roomSize = Console.ReadLine().Split();
            int maxX = int.Parse(roomSize[0]);
            int maxY = int.Parse(roomSize[1]);

            // Read in the first robot's position and instructions
            Console.WriteLine("ilk robotun pozisyonunu aralarında boşluk bırakarak giriniz.(örnek 1 2 N)");
            string[] robot1Position = Console.ReadLine().Split();
            int x1 = int.Parse(robot1Position[0]);
            int y1 = int.Parse(robot1Position[1]);
            char orientation1 = char.Parse(robot1Position[2]);
            Robot robot1 = new Robot(x1, y1, orientation1, maxX, maxY);
            Console.WriteLine("ilk robotun takip edeceği hareketleri giriniz.(örnek LMLMLMLMM)");
            string robot1Instructions = Console.ReadLine();
            robot1.Move(robot1Instructions);

            // Read in the second robot's position and instructions
            Console.WriteLine("ikinci robotun pozisyonunu aralarında boşluk bırakarak giriniz.(örnek 3 3 E)");
            string[] robot2Position = Console.ReadLine().Split();
            int x2 = int.Parse(robot2Position[0]);
            int y2 = int.Parse(robot2Position[1]);
            char orientation2 = char.Parse(robot2Position[2]);
            Robot robot2 = new Robot(x2, y2, orientation2, maxX, maxY);
            Console.WriteLine("ikinci robotun takip edeceği hareketleri giriniz.(örnek MMRMMRMRRM)");
            string robot2Instructions = Console.ReadLine();
            robot2.Move(robot2Instructions);

            // Print out the final positions and orientations of the robots
            Console.WriteLine(robot1.ToString());
            Console.WriteLine(robot2.ToString());
            Console.ReadLine();

        //5 5
        //1 2 N
        //LMLMLMLMM
        //3 3 E
        //MMRMMRMRRM
        }
    }
}
