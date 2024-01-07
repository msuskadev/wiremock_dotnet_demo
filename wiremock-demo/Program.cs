using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;

var server = WireMockServer.Start(3000);

server
  .Given(
    Request.Create().WithPath("/some/thing").UsingGet()
  )
  .RespondWith(
    Response.Create()
      .WithStatusCode(200)
      .WithHeader("Content-Type", "text/plain")
      .WithBody("Hello world!")
  );

  Console.ReadLine();