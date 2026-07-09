using System.Text.Encodings.Web;
using Davidko.InternalUtils;
using Newtonsoft.Json;

var payload = new { message = "Hello from NugetFrogbotV3Demo", timestamp = DateTime.UtcNow };
Console.WriteLine(JsonConvert.SerializeObject(payload));
Console.WriteLine(Greeter.Greet("Frogbot"));
Console.WriteLine(HtmlEncoder.Default.Encode("<script>demo</script>"));
