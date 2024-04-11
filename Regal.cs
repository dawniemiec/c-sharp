using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Generyki
{
    public class Regal<T>
    {
        private T polka1;
        private T polka2;
        private T polka3;

        public T Polka1 { get; set; }
        public T Polka2 { get; set; }
        public T Polka3 { get; set; }
        public T WolnaPolka { set { WstawNaWolnaPolka(value); } }

        public override string ToString()
        {
            return $"P1: {Polka1}, P2: {Polka2}, P3: {Polka3}" ;
        }

        public void WstawNaWolnaPolka(T val)
        {
            if(Polka1==null || Polka1.Equals(default(T)))
            {
                Polka1 = val;
            } else if (Polka2 == null || Polka2.Equals(default(T)))
            {
                Polka2= val;
            }
            else if (Polka3 == null || Polka3.Equals(default(T)))
            {
                Polka3 = val;
            }
            else
            {
                MessageBox.Show("Zawalony regał");
            }
        }
    }
}
