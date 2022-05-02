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
        TypeInfo t = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", t.Name);
        foreach (PropertyInfo prop in t.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }
        Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo meth in t.GetMethods())
        {
            Console.WriteLine(meth.Name);
        }
    }
}
