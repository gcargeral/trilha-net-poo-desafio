using DesafioPOO.Models;

//Usando Nokia
Nokia phone1 = new Nokia(numero : "+55 41 965325632", modelo: "Nokia 150", imei: "797564649", 128);
Console.WriteLine($"Usando 'Phone1' ({phone1.Numero})");
phone1.Ligar();
phone1.ReceberLigacao();
phone1.InstalarAplicativo("Waze");
Console.WriteLine("");
//Usando iPhone
Iphone phone2 = new Iphone(numero : "+55 41 965325632 ", modelo: "iPhone 15", imei: "889656666", 256);
Console.WriteLine($"Usando 'Phone2' ({phone2.Numero}) ");
phone2.Ligar();
phone2.ReceberLigacao();
phone2.InstalarAplicativo("Mapas");
