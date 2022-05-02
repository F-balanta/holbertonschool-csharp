using System;
using System.Reflection;
/// <summary>
/// OBJ Class
/// </summary>
class Obj
{
    /// <summary>
    /// Method Print Properties and Methods available of an object
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        TypeInfo tobj = myObj.GetType().GetTypeInfo();
        Console.WriteLine($"{tobj.Name} properties:");
        foreach (PropertyInfo properties in tobj.GetProperties())
            Console.WriteLine(properties.Name);

        Console.WriteLine("{0} Methods:", tobj.Name);
        foreach (MethodInfo methods in tobj.GetMethods())
            Console.WriteLine(methods.Name);
    }
}
