using DesafioPOO.Models;

Smartphone novo_Iphone = new Iphone(numero: "113424242", modelo:"Iphone 14",imei:"1111111", memoria: 128);
Console.WriteLine("Smartphone Iphone:");
novo_Iphone.Ligar();
novo_Iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Smartphone novo_Nokia = new Nokia(numero: "21324234", modelo: "Nokia2", imei:"222222", memoria: 64);
Console.WriteLine("Smartphone Nokia:");
novo_Nokia.ReceberLigacao();
novo_Nokia.InstalarAplicativo("Facebook");