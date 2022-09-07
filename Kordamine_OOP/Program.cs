// See https://aka.ms/new-console-template for more information
using Kordamine_OOP;
Console.WriteLine("-----Koer----\n");
Koer koer = new Koer(Koer.toug.Taksa, "Sarik", "punane", Koduloom.sugu.isane, 35.5, 7, true);
Koer bobik = new Koer(Koer.toug.Mastif, "Bobik", "Haal", Koduloom.sugu.isane, 50.7, 2, true);
koer.print_Info();
koer.print_Haal();
//public void a = koer.print_Info();

/*Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Barsik");
veelkoer.muudaVarv("Hall");
veelkoer.muudaKaal(40);
veelkoer.muudaVanus(5);

veelkoer.print_Info();*/

Console.WriteLine("\n-----Hamsters----\n");

Hamsters hamsters = new Hamsters(Hamsters.toug.Djungaria, "Bob", "Haal", Koduloom.sugu.isane, 25, 1, true);
hamsters.print_Info();
hamsters.print_Haal();

/*Hamsters veelhamsters = new Hamsters(hamsters);
veelhamsters.muudatNimi("Jar");
veelhamsters.muudatVarv("Valge");
veelhamsters.muudatKaal(36);
veelhamsters.muudatVanus(2);

veelhamsters.print_Info();*/


List<Koduloom> Kooduloomut = new List<Koduloom>();
Kooduloomut.Add(koer);
Kooduloomut.Add(bobik);
Kooduloomut.Add(hamsters);
Console.WriteLine("\n");

StreamWriter text = new StreamWriter(@"..\..\..\Info_Koduloom.txt", false);
foreach (Koduloom x in Kooduloomut)
{
    text.WriteLine(x.nimi + "," + x.varv + "," + x.vanus);
}
text.Close();

List<Koer> koera = new List<Koer>();
StreamReader lugeda = new StreamReader(@"..\..\..\Info_Koduloom.txt");
string texta;
while ((texta = lugeda.ReadLine()) != null)
{
    string[] rida = texta.Split(',');
    koera.Add(new Koer(rida[0], rida[1]));
}
lugeda.Close();

foreach (var item in koera)
{
    Console.WriteLine(item.nimi + " " + item.varv);
}
Console.ReadLine();

/*string file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Koduloom_info.txt");
using (StreamWriter text = new StreamWriter(file))
{
    text.WriteLine("-----Koer----\n");
    text.WriteLine($"Toug:{koer.Toug}\nVärv:{koer.varv} \nNimi: {koer.nimi}\nTa on {koer.loomaSugu} ja tema kaal on {koer.kaal} kg\n{koer.vanus} aastat vana\n");
    
    text.WriteLine("\n-----Hamsters----\n");
    text.WriteLine("{0} hamsters. Nimi: {1} {2} ta on {3} ja tema kaal on {4} gramm ja ta on {5} aastat vana", hamsters.Toug, hamsters.nimi, hamsters.varv, hamsters.loomaSugu, hamsters.kaal, hamsters.vanus);
}*/
