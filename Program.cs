using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//FEITO
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "C20", imei: "111222333", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "13 Pro Max", imei: "111222333", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Discord");
