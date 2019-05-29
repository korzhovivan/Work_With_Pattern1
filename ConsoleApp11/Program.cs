using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {

        public class RoundHole
        {
            public double Radius { get; set; }
            public RoundHole(int rad)
            {
                this.Radius = rad;
            }
            public bool Fits(RoundPeg roundPeg)
            {
                if (roundPeg.Radius < this.Radius)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public class RoundPeg
        {
            public double Radius { get; set; }

            public RoundPeg(int radius)
            {
                this.Radius = radius;
            }
            public RoundPeg()
            {

            }

        }
        public class SquarePeg
        {
            public int Width { get; set; }

            public int GetWidth()
            {
                return Width;
            }
        }
        public class SquarePegAdapter : RoundPeg
        {
            public SquarePeg squarePeg { get; set; }
            public SquarePegAdapter(SquarePeg squarePeg)
            {
                this.squarePeg = squarePeg;
                Radius = squarePeg.Width / Math.Sqrt(2);
            }


            public double GetRadius()
            {
                return squarePeg.Width / Math.Sqrt(2);
            }

        }

        static void Main(string[] args)
        {
            SquarePeg squarePeg = new SquarePeg() { Width = 10 };
            RoundHole roundHole = new RoundHole(5);
            RoundPeg roundPeg = new RoundPeg(4);
            SquarePegAdapter adapter = new SquarePegAdapter(squarePeg);

            Console.WriteLine("roundHole Radius: " + roundHole.Radius);
            Console.WriteLine("square Radius: " + adapter.GetRadius() + "\n");
            
            if (roundHole.Fits(adapter))
            {
                Console.WriteLine("Entered");
            }
            else
            {
                Console.WriteLine("No entered");
            }
            Console.ReadKey();
        }
    }
}