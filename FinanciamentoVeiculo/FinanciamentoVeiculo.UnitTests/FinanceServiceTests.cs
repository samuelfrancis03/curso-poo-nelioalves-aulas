using FinanciamentoVeiculo.Entities;
using FinanciamentoVeiculo.Services;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanciamentoVeiculo.UnitTests
{
    public class FinanceServiceTests
    {
        private readonly Mock<IFinanceCompany> _financeCompanyMock;
        private readonly FinancingService _service;

        public FinanceServiceTests()
        {
            _financeCompanyMock = new Mock<IFinanceCompany>();
            _service = new FinancingService(_financeCompanyMock.Object);
        }

        [Fact]
        public void Process_SholdAddInstalments()
        {
            //Arrange
            const int mounth = 3;
            var finance = new Financing(1001, DateTime.Now, 300);

            _financeCompanyMock
                .Setup(mock => mock.CalculateInterest(It.IsAny<decimal>(), It.IsAny<int>()))
                .Returns(101.5m);

            _financeCompanyMock
                .Setup(mock => mock.CalculateAdministractiveFee(It.IsAny<decimal>()))
                .Returns(104.54m);

            //Act
            _service.Process(finance, mounth);

            //Assert
            finance.Installments.Should().NotBeEmpty();

        }






    }
}
