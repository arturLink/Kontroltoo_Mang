using Kontroltoo_Mang;
// kod artura! i tolko artura!
List<Ese> items = new List<Ese>();
StreamReader sr = new StreamReader(@"..\..\..\Items.txt");
string text2;
while ((text2 = sr.ReadLine()) != null)
{
    string[] rida = text2.Split(";");
    items.Add(new Ese(rida[0], Converter(rida[1])));
}
sr.Close();

foreach (var x in items)
{
    Console.WriteLine(x.Info(),x.PunktideArv());
}
Console.ReadLine();



int Converter(string variable)
{
    string num = variable;
    int Num = Int32.Parse(variable);
    return Num;
}