using Kontroltoo_Mang;
using System.Text;
// kod artura! i tolko artura!
Console.OutputEncoding = Encoding.UTF8;



try
{
    Peaklass.Uus_mang(8);
}
catch (ArgumentOutOfRangeException) //почему то не видит пункты из txt файла 
{
    Console.WriteLine("file ne zapolnen");
}
catch (FileNotFoundException)
{
    Console.WriteLine("fail ne naiden");
}