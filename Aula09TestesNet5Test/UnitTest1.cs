using System;
using Aula09TestesNet5;
using FluentAssertions;
using Xunit;

namespace Aula09TestesNet5Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestingSum()
        {
            var result = Program.Somar(5, 5);
            result.Should().NotBe(0);
            result.Should().BeGreaterThan(0);
            result.Should().Be(10);
        }

        [Fact]
        public void TestandoIntervaloEntre17e31()
        {
            var result = Program.ObterParesDoInvervalo(17, 31);
            //result = 
        }


        [Theory]
        [InlineData("441.631.650-02")]
        [InlineData("781.486.380-55")]
        [InlineData("500.381.300-76")]
        public void CpfValido(string cpf)
        {
            var result = Program.CpfValido(cpf);
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("")]
        [InlineData("abcd")]
        [InlineData("asdasdfasd")]
        [InlineData("12345678900")]
        public void CpfInvalido(string cpf)
        {
            var result = Program.CpfValido(cpf);
            result.Should().BeFalse();
        }
    }
}

