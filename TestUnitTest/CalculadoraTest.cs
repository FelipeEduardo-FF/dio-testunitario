
using CalculadoraProject.Services;
using Xunit;

namespace TestUnitTest
{
    public class CalculadoraTest
    {
        private readonly Calculadora _calc;

        public CalculadoraTest() {
            _calc = new Calculadora("19/09/2023");
        }

        [Theory]
        [InlineData(1,2,3)]
        public void SomarValoresOsValoresERetornarValorValido(int n1,int n2, int resultado)
        {
            
            int resultadocalc = _calc.somar(n1, n2);
            Assert.Equal(resultado, resultadocalc);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        public void MultiplicarOsValoresERetornarValorValido(int n1, int n2, int resultado)
        {

            int resultadocalc = _calc.multiplicar(n1, n2);
            Assert.Equal(resultado, resultadocalc);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        public void DividirOsValoresERetornarValorValido(int n1, int n2, int resultado)
        {

            int resultadocalc = _calc.dividir(n1, n2);
            Assert.Equal(resultado, resultadocalc);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        public void SubtrairOsValoresERetornarValorValido(int n1, int n2, int resultado)
        {

            int resultadocalc = _calc.subtrair(n1, n2);
            Assert.Equal(resultado, resultadocalc);
        }

        [Fact]
        public void TestarDivisao()
        {

            Assert.Throws<DivideByZeroException>(()=> _calc.dividir(3,0));

        }

        [Fact]
        public void TestarHistorico()
        {
            _calc.somar(1, 2);
            _calc.somar(1, 2);
            _calc.somar(1, 2);
            _calc.somar(1, 2);

            Assert.NotEmpty(_calc.historico());
            Assert.Equal(3,_calc.historico().Count);
        }
    }


}