using Geometria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class UnitTestWalec
    {
        [Fact]
        public void TestObj()
        {
            var walec = new Walec() { Promien = 1, Wysokosc = 5 };
            var obj = walec.Objetosc();
            Assert.Equal(3.14*5, obj, 0.01);

            //walec.Promien = -1;
            Assert.Throws<ArgumentException>(() => walec.Promien = -1);

        }
    }
}
