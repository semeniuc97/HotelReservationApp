using BusinessAccessLayer.Services;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace BusinessServiceXUnitTests
{
    public class UnitTestBusinessService
    {
        private BookedDatesService bookedDatesService = new BookedDatesService();
        Mock<BookedDatesService> mockbookedDatesService = new Mock<BookedDatesService>();

        //[Fact]
        //public void Test_GetAllBookedDays()
        //{
        //    var mockBookingService = new Mock<BookingService>();

        //    mockBookingService
        //        .Setup(x => x.GetAllBookedDays(2))
        //        .Returns(new List<DateTime>()
        //    {
        //        new DateTime(2019,1,13),
        //        new DateTime(2019,1,14),
        //        new DateTime(2019,1,15),
        //        new DateTime(2019,1,16),
        //        new DateTime(2019,1,17)
        //    });

        //    var result = mockBookingService.Object.GetAllBookedDays(2).Count;

        //    Assert.Equal(5, result);
        //}

        //[Fact]
        //public void Test_IsNotEmptyBookedDays()
        //{
        //    mockBookingService.Setup(x => x.GetAllBookedDays(2)).Returns(new List<DateTime>()
        //    {
        //        new DateTime(2019,1,13),
        //        new DateTime(2019,1,14),
        //        new DateTime(2019,1,15),
        //        new DateTime(2019,1,16),
        //        new DateTime(2019,1,17)
        //    });

        //    var result = mockBookingService.Object.GetAllBookedDays(2);

        //    Assert.NotEmpty(result);
        //}

        [Fact]
        public void Test_BookingDatesRange()
        {
            var result = bookedDatesService.GetBookingDatesRange(new DateTime(2019, 1, 3), new DateTime(2019, 1, 6)).Count;

            Assert.Equal(4, result);
        }

        [Fact]
        public void Test_CheckIsBookedDates()
        {
            var bookedDates = new List<DateTime>()
            {
                new DateTime(2019,1,8),
                new DateTime(2019,1,9),
                new DateTime(2019,1,10)
            };
            mockbookedDatesService.Setup(x => x.CheckIsBookedDates(new DateTime(2019, 1, 3), new DateTime(2019, 1, 7),bookedDates)).Returns(true);

            var result = mockbookedDatesService
                .Object
                .CheckIsBookedDates(new DateTime(2019, 1, 3), new DateTime(2019, 1, 7),bookedDates);

            Assert.True(result);
            
        }
    }
}
