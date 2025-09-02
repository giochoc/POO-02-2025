// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Televisao tv = new Televisao (55f);

Console.WriteLine($"A tv tem o tamanho {tv.Tamanho}"); 

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");