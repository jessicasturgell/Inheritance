using System.Xml;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Pearl White";
            Tesla modelS = new Tesla();
            modelS.MainColor = "Midnight Black";
            Cessna mx410 = new Cessna();
            mx410.MainColor = "Ruby Red";

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
        }
    }
}
