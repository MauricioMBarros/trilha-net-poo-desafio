using System.ComponentModel;
using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "9876543", modelo: "Nokia Xpto", imei: "4321", memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "5555555", modelo: "Iphone Exp", imei: "0000", memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");