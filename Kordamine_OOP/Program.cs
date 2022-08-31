// See https://aka.ms/new-console-template for more information
using Kordamine_OOP;
Console.WriteLine("Hello, World!");
Koer koer = new Koer(Koer.toug.taksa, "Sarik", "punane", Koduloom.sugu.isane, 35.5, 7, true);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Barsik");

veelkoer.print_Info();
