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
            #region Arrange - Act - Assert Method

            //Arrange
            // Verileri Initialize ettiğim ilk adımdır.

            //int a = 5;
            //int b = 20;
            //var calculator = new Calculator();

            //Act
            // Test edeceğimiz methodu çalıtırdığımız adımdır.

            //var total = calculator.add(a, b);

            //Assert
            // Test sonucunun beklenen değer ile eşleştiğini doğruladığımız adımdır.

            //Assert.Equal(total, a + b);

            #endregion Arrange - Act - Assert Method


            #region Contains - DoesNotContain Method

            //Belirli bir alt metnin bir string içinde yer alıp almadığını kontrol ediyor.
            //Assert.Contains("Göksel", "Göksel Karadağ");

            //Bir alt metnin bir string içerisinde olmadığını kontrol eder.
            //Assert.DoesNotContain("Miray", "Göksel Karadağ");


            //Belirli bir koleksiyonun belirli bir öğeye sahip olup olmadığını doğrulamak için kullanılır.
            //var names = new List<string>() { "Göksel", "Miray", "Cansel" };
            //Assert.Contains(names, x => x == "Göksel");


            #endregion Contains - DoesNotContain Method


            #region True - False Method

            //Assert.True(5 > 2);
            //Assert.False(5 < 2);

            #endregion True - False Method


            #region Matches - DoesNotMatch Method

            //var regEx = "^dog";

            //Belirli bir string'in bir düzenli ifadeye (regex) uygun olup olmadığını doğrulamak için kullanılır.
            //Assert.Matches(regEx, "dog reg");

            //Bir string'in belirli bir düzenli ifadeyle (regex) eşleşmediğini doğrulamak için kullanılır.
            //Assert.DoesNotMatch(regEx, "reg dog");

            #endregion Matches - DoesNotMatch Method


            #region StartsWith - EndsWith Method

            //Bir string'in belirli bir alt metinle başlayıp başlamadığını kontrol eder.
            //Assert.StartsWith("Bir", "Bir masal");

            //Bir string'in belirli bir alt metinle bitip bitmediğini kontrol eder.
            //Assert.EndsWith("masal", "Bir masal");

            #endregion StartsWith - EndsWith Method


            #region Empty - NotEmpty

            //İçeride ki dizinin boş olup olmadığını kontrol eder.
            //Assert.Empty(new List<string>());


            //İçeride ki dizinin dolu olup olmadığını kontrol eder.
            //Assert.NotEmpty(new List<string>() { "Göksel" });

            #endregion Empty - NotEmpty


            #region InRange - NotInRange Method

            //Belirli bir değerin belirli bir aralık (min ve max) içinde olup olmadığını kontrol etmek için kullanılır.
            //Assert.InRange(10,2,20);

            //Belirli bir değerin belirli bir aralık (min ve max) dışında olup olmadığını kontrol etmek için kullanılır.
            //Assert.NotInRange(30,2,20);

            #endregion InRange - NotInRange Method


            #region Single

            //Belirli bir koleksiyonun içinde tek bir öğe olup olmadığını kontrol etmek için kullanılır.
            Assert.Single("G");

            #endregion Single


            #region IsType - IsNotType

            //Bir nesnenin belirtilen türde (type) olup olmadığını kontrol etmek için kullanılır.
            //Assert.IsType<string>("Göksel");

            //Bir nesnenin belirtilen türde olmadığını kontrol etmek için kullanılır.
            //Assert.IsNotType<int>("Göksel");

            #endregion IsType - IsNotType


            #region IsAssignableFrom

            //Bir nesnenin belirtilen türden türetilip türetilmediğini veya o türe atılabilir olup olmadığını kontrol etmek için kullanılır.
            //Assert.IsAssignableFrom<IEnumerable<string>>(new List<string>());

            //Assert.IsAssignableFrom<Object>("Göksel");

            #endregion IsAssignableFrom


            #region Null - NotNull

            //string deger = null;

            //Assert.Null(null);

            //Assert.NotNull(null);


            #endregion Null - NotNull

        }
    }
}
