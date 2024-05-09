using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345678", "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "44444444", "Modelo 2", imei: "222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");