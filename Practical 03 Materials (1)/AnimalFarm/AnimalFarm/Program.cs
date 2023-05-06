using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AnimalFarm
{
    // The farm object
    public class FarmObject
    {
        // Class variables
        private int iMaxWidth, iMaxHeight;
        protected string strAppearance;
        protected Random rnd;
        private int iX, iY;

        // Constructor
        public FarmObject(int iMaxWidth, int iMaxHeight, Random rnd)
        {
            this.iMaxWidth = iMaxWidth;
            this.iMaxHeight = iMaxHeight;
            this.rnd = rnd;

            this.iX = rnd.Next(0, iMaxWidth);
            this.iY = rnd.Next(0, iMaxHeight);
            this.strAppearance = "#";
        }

        // Class methods
        public void Draw()
        {
            Console.SetCursorPosition(iX, iY);
            Console.Write(strAppearance);
        }
    }

    internal class Program
    {
        public const int iMaxWidth = 50;
        public const int iMaxHeight = 15;

        static void Main(string[] args)
        {
            // Variables
            Random rnd = new Random();

            // Objects
            FarmObject fm = new FarmObject(iMaxWidth, iMaxHeight, rnd);

            // Initialise the string that represent the multiline background
            string strBackground = "";
            for (int y = 0; y < iMaxHeight; y++)
            {
                for (int x = 0; x < iMaxWidth; x++)
                {
                    strBackground += "'";
                }
                strBackground += "\n";
            }

            // Repeat forever until the user quit the program with the system key Ctrl+C
            while (true)
            {
                // Draw the background
                Console.Clear();
                Console.WriteLine(strBackground);
                Console.WriteLine("Press Ctrl+C to quit...");

                // Draw
                fm.Draw();

                // Sleep for a short duration before drawing the next frame
                Console.SetCursorPosition(0, iMaxHeight+2);
                Thread.Sleep(200);
            }
        }
    }
}
