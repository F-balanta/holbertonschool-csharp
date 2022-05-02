using System;
using System.Collections.Generic;
/// <summary>
///  This class contains one method public
/// </summary>
class Obj
{
    /// <summary>
    /// This method returns true if is object
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>returns true if is object otherwise returns false</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj == null)
            return false;
        if (typeof(Array).IsInstanceOfType(obj))
            return true;
        else
            return false;
    }
}