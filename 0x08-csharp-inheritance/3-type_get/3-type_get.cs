using System;
using System.Collections.Generic;
using System.Reflection;

    /// <summary> Public class Obj </summary>
    class Obj
    {
        /// <summary> Public Static Obj </summary>
        public static void Print(object myObj)
        {
            Type new_obj = myObj.GetType().GetTypeInfo(); // Where new_obj is object whose properties and methods you need.
            Console.WriteLine("{0} Properties:", new_obj.Name);

            foreach (PropertyInfo p in new_obj.GetProperties())
            {
                Console.WriteLine("{0}", p.Name);
            }

            Console.WriteLine("{0} Methods:", new_obj.Name);

            foreach (MethodInfo m in new_obj.GetMethods())
            {
                Console.WriteLine("{0}", m.Name);
            }
        }
    }
