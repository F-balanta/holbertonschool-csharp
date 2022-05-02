using System;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if(derivedType is baseType)
            return true;
    }
}