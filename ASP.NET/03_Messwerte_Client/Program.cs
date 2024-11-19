// See https://aka.ms/new-console-template for more information

using Org.OpenAPITools.Api;

var mess = new MessStationApi("http://localhost:5237");

var messstationen = await mess.ApiMesstationenGetAsync();

Console.WriteLine("Stations");
foreach(var m in messstationen){
    Console.WriteLine(m);
}