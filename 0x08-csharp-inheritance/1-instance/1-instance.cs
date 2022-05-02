using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj == null)
            return false;
        if (obj.GetType() == typeof(Int32[]))
            return true;
        else
            return false;
    }
}