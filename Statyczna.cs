using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public static class Statyczna
    {
        public static (double, double, double) ZnajdzMinimumFunkcji2D(double minX, double minY, double maxX, double maxY, int liczbaIteracji, Func<double, double, double> funkcja)
        {
            double? foundX= null;
            double? foundY= null;
            double? foundVal= null;

            Random random= new Random();

            for(int i = 0;i<liczbaIteracji;i++) {
                double randX = random.NextDouble() * (maxX - minX) + minX;
                double randY = random.NextDouble() * (maxY - minY) + minY;
                double val = funkcja(randX, randY);

                if(foundVal== null || val < foundVal)
                {
                    foundX = randX;
                    foundY = randY;
                    foundVal = val;
                }
            }

            (double, double, double) wynik;
            wynik.Item1 = (double)foundX;
            wynik.Item2 = (double)foundY;
            wynik.Item3 = (double)foundVal;
            return wynik;
           
        }
    }
}
