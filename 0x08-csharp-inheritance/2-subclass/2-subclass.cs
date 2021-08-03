using System;


    /// <summary> Public class Obj </summary>
    class Obj
    {
         /// <summary> If class is a Subclass from BaseType </summary>
        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            return (derivedType.IsSubclassOf(baseType));
        }
    }
