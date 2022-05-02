using System;

class Obj
{
    public static void Print(object myObj)
    {
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach (var element in myObj.GetType().GetProperties())
            Console.WriteLine($"{element.Name}");
        Console.WriteLine($"{myObj.GetType().Name} Methods");
        foreach (var elem in myObj.GetType().GetMethods())
            Console.WriteLine($"{elem.Name}");
    }
}
