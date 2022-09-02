// See https://aka.ms/new-console-template for more information
using Kordamine_OOP;
Console.WriteLine("-----Koer----\n");
Koer koer = new Koer(Koer.toug.Taksa, "Sarik", "punane", Koduloom.sugu.isane, 35.5, 7, true);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Barsik");
veelkoer.muudaVarv("Hall");
veelkoer.muudaKaal(40);
veelkoer.muudaVanus(5);

veelkoer.print_Info();

Console.WriteLine("\n-----Hamsters----\n");

Hamsters hamsters = new Hamsters(Hamsters.toug.Djungaria, "Bob", "Haal", Koduloom.sugu.isane, 25, 1, true);
hamsters.print_Info();
hamsters.print_Haal();

Hamsters veelhamsters = new Hamsters(hamsters);
veelhamsters.muudatNimi("Jar");
veelhamsters.muudatVarv("Valge");
veelhamsters.muudatKaal(36);
veelhamsters.muudatVanus(2);

veelhamsters.print_Info();

string file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Koduloom_info.txt");
using (StreamWriter text = new StreamWriter(file))
{
    text.WriteLine("-----Koer----\n");
    text.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} kg. ja ta on {5} aastat vana", koer.Toug, koer.nimi, koer.varv, koer.loomaSugu, koer.kaal, koer.vanus);
    
    text.WriteLine("\n-----Hamsters----\n");
    text.WriteLine("{0} hamsters. Nimi: {1} {2} ta on {3} ja tema kaal on {4} gramm ja ta on {5} aastat vana", hamsters.Toug, hamsters.nimi, hamsters.varv, hamsters.loomaSugu, hamsters.kaal, hamsters.vanus);
}