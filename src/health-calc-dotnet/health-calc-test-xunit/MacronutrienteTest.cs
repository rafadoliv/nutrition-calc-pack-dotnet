using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Models;

namespace health_calc_test_xunit
{
    public class MacronutrienteTest
    {
        [Fact]
        public void When_RequestMacronutrientesCalcWithValidDataForCutting_ThenReturnResult()
        {
            //Arrange
            var MacronutrienteObj = new Macronutriente();
            var Sexo = SexoEnum.Masculino;
            var NivelAtividadeFisica = NivelAtividadeFisicaEnum.Sedentario;
            var Height = 1.68;
            var Weight = 85;
            var ObjetivoFisico = ObjetivoFisicoEnum.Cutting;

            var Expected = new MacronutrienteModel()
            {
                Carboidratos = 170,
                Proteinas = 170,
                Gorduras = 85
            };

            //Act
            var Result = MacronutrienteObj.Calc(
                Sexo,
                Height,
                Weight,
                NivelAtividadeFisica,
                ObjetivoFisico);

            //Assert
            Assert.Equal(Expected.Carboidratos, Result.Carboidratos);
            Assert.Equal(Expected.Proteinas, Result.Proteinas);
            Assert.Equal(Expected.Gorduras, Result.Gorduras);

        }

        [Theory]
        [InlineData(NivelAtividadeFisicaEnum.Sedentario, 340)]
        [InlineData(NivelAtividadeFisicaEnum.ModeradamenteAtivo, 340)]
        [InlineData(NivelAtividadeFisicaEnum.BatanteAtivo, 595)]
        [InlineData(NivelAtividadeFisicaEnum.ExtremamenteAtivo, 595)]
        public void When_RequestMacronutrientesCalcWithValidDataForBulking_ThenReturnResult(NivelAtividadeFisicaEnum NivelAtividadeFisica, int Carboidratos)
        {
            //Arrange
            var MacronutrienteObj = new Macronutriente();
            var Sexo = SexoEnum.Masculino;
            var Height = 1.68;
            var Weight = 85;
            var ObjetivoFisico = ObjetivoFisicoEnum.Bulking;

            var Expected = new MacronutrienteModel()
            {
                Carboidratos = Carboidratos,
                Proteinas = 170,
                Gorduras = 170
            };

            //Act
            var Result = MacronutrienteObj.Calc(
                Sexo,
                Height,
                Weight,
                NivelAtividadeFisica,
                ObjetivoFisico);

            //Assert
            Assert.Equal(Expected.Carboidratos, Result.Carboidratos);
            Assert.Equal(Expected.Proteinas, Result.Proteinas);
            Assert.Equal(Expected.Gorduras, Result.Gorduras);

        }

        [Fact]
        public void When_RequestMacronutrientesCalcWithValidDataForMaintenance_ThenReturnResult()
        {
            //Arrange
            var MacronutrienteObj = new Macronutriente();
            var Sexo = SexoEnum.Masculino;
            var NivelAtividadeFisica = NivelAtividadeFisicaEnum.Sedentario;
            var Height = 1.68;
            var Weight = 85;
            var ObjetivoFisico = ObjetivoFisicoEnum.Maintenance;

            var Expected = new MacronutrienteModel()
            {
                Carboidratos = 425,
                Proteinas = 170,
                Gorduras = 85
            };

            //Act
            var Result = MacronutrienteObj.Calc(
                Sexo,
                Height,
                Weight,
                NivelAtividadeFisica,
                ObjetivoFisico);

            //Assert
            Assert.Equal(Expected.Carboidratos, Result.Carboidratos);
            Assert.Equal(Expected.Proteinas, Result.Proteinas);
            Assert.Equal(Expected.Gorduras, Result.Gorduras);

        }

        [Fact]
        public void When_RequestMacronutrientesCalcWithInvalidData_ThenThrowException()
        {
            //Arrange
            var MacronutrienteObj = new Macronutriente();
            var Sexo = SexoEnum.Masculino;
            var NivelAtividadeFisica = NivelAtividadeFisicaEnum.Sedentario;
            var Height = 1.68;
            var Weight = 34;
            var ObjetivoFisico = ObjetivoFisicoEnum.Maintenance;

            //Act and Assert
            Assert.Throws<Exception>(() => MacronutrienteObj.Calc(
                Sexo,
                Height,
                Weight,
                NivelAtividadeFisica,
                ObjetivoFisico));

        }

    }
}