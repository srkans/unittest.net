﻿using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class BookingHelper_OverlappingBookingExistTests
    {

        private Booking _existingBooking;
        private Mock<IBookingRepository> _repository;


        [SetUp]
        public void SetUp()
        {
            _existingBooking = new Booking 
            {
                Id = 2,
                ArrivalDate = ArriveOn(2023, 1, 15),
                DepartureDate = DepartOn(2023, 1, 20),
                Reference = "a",
            };

            _repository = new Mock<IBookingRepository>();
            _repository.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking>
            {
                _existingBooking
            }.AsQueryable());
        }

        [Test]
        public void BookingStartsAndFinishesBeforeAnExistingBooking_ReturnEmptyString() 
        {
 

            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = Before(_existingBooking.ArrivalDate, days: 2),
                DepartureDate = After(_existingBooking.DepartureDate),
                Reference = "a",
            }, _repository.Object);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void BookingStartsBeforeFinishesInTheMiddleOfAnExistingBooking_ReturnExistingBookingReference()
        {


            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = Before(_existingBooking.ArrivalDate),
                DepartureDate = After(_existingBooking.ArrivalDate),
                Reference = "a",
            }, _repository.Object);

            Assert.That(result, Is.EqualTo(_existingBooking.Reference));
        }

        private DateTime Before(DateTime dateTime, int days = 1)
        {
            return dateTime.AddDays(-days);
        }
        private DateTime After(DateTime dateTime)
        {
            return dateTime.AddDays(1);
        }

        private DateTime ArriveOn(int year,int month, int day)
        {
            return new DateTime(year,month,day,14,0,0);
        }
        private DateTime DepartOn(int year, int month, int day)
        {
            return new DateTime(year, month, day, 10, 0, 0);
        }
    }
}