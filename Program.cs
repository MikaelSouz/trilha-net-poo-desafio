using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("1111", "15", "5874", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instragam");

Console.WriteLine("");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("1111", "15", "5874", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");