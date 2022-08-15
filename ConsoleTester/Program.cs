// See https://aka.ms/new-console-template for more information
using BunnyCdn;

Console.WriteLine("Hello, World!");

var client = new BunnyCdnClient("22f7d38a-93f1-46b5-a4c9-77d21fc32ee91e458d28-fef9-4fdc-9b55-a4b147543391");
var libs = await client.ListVideoLibrariesAsync();

foreach(var l in libs)
    Console.WriteLine($"{l.Name} - {l.Id}");

Console.ReadKey();