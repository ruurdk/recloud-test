// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

Console.WriteLine("Address data faker");

var a = new AddressFaker().Generate(1000);

var a_j = JsonConvert.SerializeObject(a.First());
Console.WriteLine(a_j);
