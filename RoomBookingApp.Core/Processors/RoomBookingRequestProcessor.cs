using RoomBookingApp.Core.Models;

namespace RoomBookingApp.Core.Processors;

public class RoomBookingRequestProcessor
{
    public RoomBookingResult BookRoom(RoomBookingRequest request)
    {
        return new()
        {
            FullName = request.FullName,
            Email = request.Email,
            Date = request.Date
        };
    }
}