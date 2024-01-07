using Spectre.Console;
using WireMock.Server;

ShowTitle();
RunWiremockServer(3000);
AnsiConsole.WriteLine("Press any key to stop server...");
Console.ReadLine();

void ShowTitle()
{
    AnsiConsole.Write(new FigletText("Wiremock Demo")
        .Centered()
        .Color(Color.DarkSeaGreen4_1));
}

void RunWiremockServer(int port)
{
    var server = WireMockServer.Start(port);
    AnsiConsole.WriteLine($"Wiremock server listening on http://localhost:{server.Port}");
}