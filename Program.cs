using Davidko.InternalUtils;
using Newtonsoft.Json;

var payload = new { message = "Hello from NugetFrogbotV3Demo", timestamp = DateTime.UtcNow };
Console.WriteLine(JsonConvert.SerializeObject(payload));
Console.WriteLine(Greeter.Greet("Frogbot"));
