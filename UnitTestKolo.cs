using Geometria;

namespace TestProject1
{
    public class UnitTestKolo
    {
        [Fact]
        public void TestPole()
        {
            var kolo = new Kolo { Promien = 1 };
            var pole = kolo.Pole();

            Assert.Equal(3.14, pole, 0.01);

            kolo.Promien = 100000;
            Assert.Equal(Math.PI * 100000 * 100000, kolo.Pole(), 0.01);

        }
        [Fact]
        public void TestPromien()
        {
            var kolo = new Kolo();
            kolo.Promien = 7;
            Assert.Equal(7, kolo.Promien);

            Assert.Throws<ArgumentException>(()=> kolo.Promien = -2);
        }
    }
}