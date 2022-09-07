using MyLib;


AbstractFactory MyClass;

while (true)
{
    if (Console.ReadLine() == "1")
    {
        MyClass = new ConcreteFactory1();
        doWork();
    }
    else
    {
        MyClass = new ConcreteFactory2();
        doWork();
    }
}

void doWork()
{
    Console.ForegroundColor = ClosestConsoleColor(MyClass.CreateProductB().R, MyClass.CreateProductB().G, MyClass.CreateProductB().B);
    Console.WriteLine(MyClass.CreateProductA());
}

static ConsoleColor ClosestConsoleColor(byte r, byte g, byte b)
{
    ConsoleColor ret = 0;
    double rr = r, gg = g, bb = b, delta = double.MaxValue;

    foreach (ConsoleColor cc in Enum.GetValues(typeof(ConsoleColor)))
    {
        var n = Enum.GetName(typeof(ConsoleColor), cc);
        var c = System.Drawing.Color.FromName(n == "DarkYellow" ? "Orange" : n); // bug fix
        var t = Math.Pow(c.R - rr, 2.0) + Math.Pow(c.G - gg, 2.0) + Math.Pow(c.B - bb, 2.0);
        if (t == 0.0)
            return cc;
        if (t < delta)
        {
            delta = t;
            ret = cc;
        }
    }
    return ret;
}
