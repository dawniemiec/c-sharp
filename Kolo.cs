namespace Geometria
{
    public class Kolo
    {
        private double promien;
        public double Promien { get { return promien; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Promien nie może być ujemny");
                }
                promien = value;
            
            } }
        public double Pole()
        {
            return Math.PI * Math.Pow(Promien,2);
        }
        public double Obwod()
        {
            return 2 * Math.PI * Promien;
        }

    }


}
