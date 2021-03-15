using BusinessLayer;
using Data;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class BusinessLayerTests
    {
        private Mock<InterviewContext> dbMockContext;

        public BusinessLayerTests()
        {
            SetupMockContext();
        }

        private void SetupMockContext()
        {
            var data = GetTestData();
            var mockSet = new Mock<DbSet<DevLossType>>();

            mockSet.As<IQueryable<DevLossType>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<DevLossType>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<DevLossType>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<DevLossType>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            dbMockContext = new Mock<InterviewContext>();
            dbMockContext.Setup(m => m.DevLossType).Returns(mockSet.Object);
        }

        private IQueryable<DevLossType> GetTestData()
        {
            var list = new List<DevLossType>()
            {
                new DevLossType
                {
                   LossTypeCode = "test",
                   LossTypeDescription = "testDescription",
                   LossTypeId = 1
                }
            };

            return list.AsQueryable();
        }

        [Fact]
        public void DataLoss_GetLossTypes_Should_Return_List()
        {
            // Arrange
            var bs = new DevLossService(dbMockContext.Object);

            // Act
            var result = bs.GetLossTypes();

            // Assert
            Assert.True(result.Count == 1);
            Assert.True(result[0].LossTypeId == 1);
        }
    }
}
