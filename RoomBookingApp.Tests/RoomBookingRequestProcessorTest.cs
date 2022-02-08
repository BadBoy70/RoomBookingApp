using System;
using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;
using Xunit;
using Shouldly;

namespace RoomBookingApp.Core;

public class RoomBookingRequestProcessorTest
{
    [Fact]
    public void Should_Return_Room_Booking_Response_With_Request_Values()
    {
            //Arrange

            RoomBookingRequest request = new()
            {
                FullName = "Test Name",
                Email = "test@rtequest.com",
                Date = new DateTime(2021, 10, 20)
            };
            
            RoomBookingRequestProcessor processor = new();
            

            //Act
            RoomBookingResult result = processor.BookRoom(request);

            //Assert
            result.ShouldNotBeNull();
            result.FullName.ShouldBe(request.FullName);
            result.Email.ShouldBe(request.Email);
            result.Date.ShouldBe(request.Date);

    }
    
}