using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.App;

namespace UnitTest.Test
{
    public class CalculatorTest
    {
        [Fact] //Her test edeceğimiz methoda vermemiz gerekiyor.
        public void AddTest()
        {
            //Arrange
            // Verileri Initialize ettiğim ilk adımdır.

            int a = 5;
            int b = 20;
            var calculator = new Calculator();

            //Act
            // Test edeceğimiz methodu çalıtırdığımız adımdır.

            var total = calculator.add(a, b);

            //Assert
            // Test sonucunun beklenen değer ile eşleştiğini doğruladığımız adımdır.

            Assert.Equal(total, a + b);

        }
    }
}
