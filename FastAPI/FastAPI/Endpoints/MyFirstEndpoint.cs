using FastEndpoints;

namespace FastAPI.Endpoints
{
    public class MyFirstEndpoint : Endpoint<MyFirstRequest, MyFirstResponse>
    {
        // How the endpoint should listen to incoming requests
        public override void Configure()
        {
            Post("/api/author/create");
            AllowAnonymous();
        }

        // Logic for processing the request and send back the response
        public override async Task HandleAsync(MyFirstRequest request, CancellationToken token)
        {
            await SendAsync(new()
            {
                Message = $"The author name is {request.FirstName} {request.LastName}"
            });
        }
    }
}
