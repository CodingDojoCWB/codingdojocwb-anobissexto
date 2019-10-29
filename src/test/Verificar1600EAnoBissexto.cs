using NUnit.Framework;
using app;

namespace test
{
    [TestFixture]
    public class Verificar1600EAnoBissexto
    {
        [Test]
        public void Verrificar1600EAnoBissexto()
        {
            //Arange
            var isBissexto = true;

            //act
            isBissexto = Ano.VerificarBissexto(1600);

            //assert
            Assert.IsFalse(isBissexto);

        }
    }
}