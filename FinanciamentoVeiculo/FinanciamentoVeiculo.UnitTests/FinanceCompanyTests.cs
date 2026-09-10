using FinanciamentoVeiculo.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanciamentoVeiculo.UnitTests
{
    public class FinanceCompanyTests
    {
        private readonly FinanceCompany _service = new();

        [Theory]
        [InlineData(100, 3, 104.5)]
        public void CalculateInterests_ShouldCalculateCorrectly(
            decimal amount,
            int mounth,
            decimal expect) 
        {
            // Arrange
            // Act
            var result = _service.CalculateInterest(amount, mounth);

            //Assert
            result.Should().Be(expect);
        }

        [Theory]
        [InlineData(104.5, 107.64)]
        public void CalculateAdministractiveFee_ShouldCalculateCorrectly(
            decimal amount,
            decimal expect)
        {
            // Arrange
            // Act
            var result = _service.CalculateAdministractiveFee(amount);

            //Assert
            result.Should().Be(expect);
        }


    }
}
