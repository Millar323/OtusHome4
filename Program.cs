using OtusHome4;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices.ObjectiveC;

Stopwatch stopwatch1 = new Stopwatch();
stopwatch1.Start();
for (var i = 0; i < 10000; i++) 
{
    XML.GetStringXML();
}
stopwatch1.Stop();
Console.WriteLine(stopwatch1.ElapsedMilliseconds);


Stopwatch stopwatch2 = new Stopwatch();
stopwatch2.Start();
for (var i = 0; i < 10000; i++)
{
    GetString.GetFString();
}
stopwatch2.Stop();
Console.WriteLine(stopwatch2.ElapsedMilliseconds);

Console.ReadKey();

public class F
{
    public int i1, i2, i3, i4;
    public F Get() => new F() { i1 = 1, i2 = 2, i3 = 3, i4 = 4 };
}
