# MediatRPattern
Mediator Pattern Example



#New Project MediaRtPattern
Create a  new web api project from the command prompt
    
    dotnet new sln -n MediaRt
    dotnet new webapi -n MediaRtPattern
    dotnet sln ./MediaRt.sln add ./MediaRtPattern.csproj
    dotnet new nunit -n Test.Mediatr
    dotnet add ./Test.Mediatr/Test.Mediatr.csproj referemce ./MediaRtPattern/MediaRtPattern.csproj
    dotnet sln ./MediaRt.sln add ./MediaRtPattern/MediaRtPattern.csproj


#Register the Service
Add MediatR services to the Dependency Injection container.
    
    builder.Services.AddMediatR(typeof(Program));


#Handler
Define the AddBooking Handler to handle request and return new booking record as a response

    public class AddBookingHandler : IRequestHandler<BookingRequest, Booking>   
       
    public async Task<Booking> Handle(BookingRequest request, CancellationToken cancellationToken)
        
#Handler Request Command/Query
Add Booking mediart request which accept booking record as input parameter and reponse with new booking record
 
    public record BookingRequest(Booking booking) : IRequest<Booking>;
    

#Unit Test
    
    curl -X POST https://localhost:5001/api/Booking -H "Content-Type: application/json" --data "{\"id\":4,\"name\":\"D4\"}"

#Improvement/Enhancement
Generic request and response can be improved
Try-Catch block need to be enhanced for exception handling
Unit Testing is missing, need to enhance

