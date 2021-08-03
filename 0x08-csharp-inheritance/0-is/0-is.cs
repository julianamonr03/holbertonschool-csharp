using System;

    /// <summary> Public class Obj </summary>
    class Obj
    {
        /// <summary> Public Function for get Type of obj </summary>
        public static bool IsOfTypeInt(object obj)
        {
            return (obj.GetType() == typeof(int));
        }
    }
