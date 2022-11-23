using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Interfaces;


namespace Health_calc_test_xunit
{
    public class IMCTest
    {
        [Fact]
        public void When_RequestIMCCalcWithValidData_ThenReturnIMCIndex()
        {
            //Arrange
            var Imc = new IMC();
            var Height = 1.70;
            var Weight = 90;
            var Expected = 28.10;


            //Act
            var Result = Imc.Calc(Height, Weight);

            //Assert
            Assert.Equal(Expected, Result);
        }

        [Fact]
        public void WhenRequestIMCCalcWithValidDataThenReturnIMCIndexWithRangeAssert()
        {
            //Arrange
            var Imc = new IMC();
            var Height = 1.70;
            var Weight = 90;
            var ExpectedMin = 28;
            var ExpectedMax = 28.15;

            //Act
            var Result = Imc.Calc(Height, Weight);

            //Assert
            Assert.InRange(Result, ExpectedMin, ExpectedMax);
        }

        //[Fact]
        // public void When_RequestIMCCalcWithInValidData_ThenReturnNaN()
        //{
        //Arrange
        //var Imc = new IMC();
        // var Height = 0.0;
        // var Weight = 0.0;
        // var Expected = double.NaN;


        //Act
        //var Result = Imc.Calc(Height, Weight);

        //Assert
        //Assert.Equal(Expected, Result);
        // }

        [Fact]
        public void When_RequestIMCCalcWithInValidAllData_ThenThrowException()
        {
            //Arrange
            var Imc = new IMC();
            var Height = 0.0;
            var Weight = 0.0;

            //Act & Assert
            Assert.Throws<Exception>(() => Imc.Calc(Height, Weight));
        }


        // [Fact]
        // public void When_RequestIMCCalcWithInValidData_ThenReturnInfinity()
        // {
        //Arrange
        //var Imc = new IMC();
        //var Height = 0.0;
        //var Weight = 85.0;
        //var Expected = double.PositiveInfinity;


        //Act
        //var Result = Imc.Calc(Height, Weight);

        //Assert
        //Assert.Equal(Expected, Result);
        // }


        [Fact]
        public void When_RequestIMCCalcWithInValidHeightData_ThenThrowException()
        {
            //Arrange
            var Imc = new IMC();
            var Height = 0.0;
            var Weight = 85.0;


            //Act & Assert
            Assert.Throws<Exception>(() => Imc.Calc(Height, Weight));
        }

        [Theory]
        [InlineData(17.5, "Abaixo do Peso")]
        [InlineData(18.49, "Abaixo do Peso")]
        [InlineData(18.50, "Peso Normal")]
        [InlineData(24.99, "Peso Normal")]
        [InlineData(25, "Pre-Obesidade")]
        [InlineData(29.99, "Pre-Obesidade")]
        [InlineData(30, "Obesidade Grau 1")]
        [InlineData(34.99, "Obesidade Grau 1")]
        [InlineData(35, "Obesidade Grau 2")]
        [InlineData(39.99, "Obesidade Grau 2")]
        [InlineData(40, "Obesidade Grau 3")]
        [InlineData(45, "Obesidade Grau 3")]
        public void When_RequestIMCCategory_ThenReturnCategory(double IMC, string ExpectedResult)
        {
            //Arrange
            var Imc = new IMC();

            //Act
            var Result = Imc.GetIMCCategory(IMC);
            //Assert
            Assert.Equal(ExpectedResult, Result);
        }



        [Theory]
        [InlineData(0, 1.68)]
        [InlineData(85, 0)]
        [InlineData(0, 0)]
        public void When_InvalidDate_ThenReturnValidationResultFalse(double Height, double Weight)
        {
            //Arrange
            var Imc = new IMC();
            var _Height = Height;
            var _Weight = Weight;


            //Act
            var Result = Imc.IsValid(_Height, _Weight);

            //Assert
            Assert.False(Result);
        }


    }
}