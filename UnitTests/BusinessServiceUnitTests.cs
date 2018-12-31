using BusinessAccessLayer.Services;
using Moq;
using System;
using Xunit;
using System.Collections.Generic;
namespace UnitTests
{
    public class BusinessServiceUnitTests
    {
        
        [Fact]
        public void Test_GetAllBookedDays()
        {
            var mockBookingService = new Mock<BookingService>();
            mockBookingService.Setup(x => x.GetAllBookedDays(2)).Returns(new List<DateTime>()
            {
                new DateTime(2019,1,13),
                new DateTime(2019,1,14),
                new DateTime(2019,1,15),
                new DateTime(2019,1,16),
                new DateTime(2019,1,17)
            } );

            var result=mockBookingService.Object.GetAllBookedDays(2).Count;

            Assert.Equal(5, result);
        }
    }
}
