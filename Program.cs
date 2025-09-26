using DesafioPOO.Models;

Console.WriteLine("=======================================");
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo NK1", imei: "111-222-333", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Teams");
Console.WriteLine("---------------------------------------");
Console.WriteLine("=======================================");
Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "54321", modelo: "iPhone XX6", imei: "111-222-333", memoria: 500);
nokia.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
Console.WriteLine("---------------------------------------");