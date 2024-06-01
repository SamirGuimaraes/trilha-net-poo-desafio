using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO 

Console.WriteLine("Smartphone Nókia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: 1111111111, memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Intagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "456789", modelo: "Modelo 2", imei: 22222222, memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");