var pars = Environment.GetCommandLineArgs();
if (pars.Length <= 1)
    return;

var result = await (new HttpClient()).GetAsync(pars[1]);
var responseText = await result.Content.ReadAsStringAsync();

Console.WriteLine(responseText);