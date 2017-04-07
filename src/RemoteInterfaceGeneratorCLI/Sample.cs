namespace RemoteInterfaceGeneratorCLI
{
    public static class Sample
    {
        //C:\Program Files (x86)\Google\Chrome\Application>chrome --remote-debugging-port=9223

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    var sessions = GetSessions("http://localhost:9223/").GetAwaiter().GetResult();

        //    var session = new ChromeSession(sessions.Last());
        //    var result = session.SendCommand<NavigateCommand, NavigateCommandResponse>(new NavigateCommand
        //    {
        //        Url = "http://www.winamp.com"
        //    }, CancellationToken.None).GetAwaiter().GetResult();
        //}

        //public static async Task<string[]> GetSessions(string url)
        //{
        //    var remoteSessionUrls = new List<string>();
        //    var webClient = new HttpClient();
        //    var uriBuilder = new UriBuilder(url);
        //    uriBuilder.Path = "/json";
        //    var remoteSessions = await webClient.GetStringAsync(uriBuilder.Uri);
        //    using (var stringReader = new StringReader(remoteSessions))
        //    using (var jsonReader = new JsonTextReader(stringReader))
        //    {
        //        var sessionsObject = JToken.ReadFrom(jsonReader) as JArray;
        //        foreach (var sessionObject in sessionsObject)
        //        {
        //            var webSocketDebuggerToken = sessionObject["webSocketDebuggerUrl"];
        //            if (webSocketDebuggerToken != null)
        //            {
        //                remoteSessionUrls.Add(webSocketDebuggerToken.Value<string>());
        //            }
        //        }
        //    }
        //    return remoteSessionUrls.ToArray();
        //}
    }
}
