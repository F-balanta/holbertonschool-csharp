using System;
/// <summary>
/// This class contains one method public
/// </summary>
class Obj
{
    /// <summary>
    /// This method return tre if obj is an object of type Int 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>return true if obj is an object of type Int otherwise return false</returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj == null)
            return false;
        if (obj.GetType() == typeof(int))
            return true;
        else
            return false;
    }
}