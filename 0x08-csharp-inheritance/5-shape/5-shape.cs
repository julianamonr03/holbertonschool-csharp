using System;

    /// <summary> New class Shape </summary>
    class Shape
    {
        /// <summary> Public Area with Exception </summary>
        public virtual int Area()
        {
            throw new NotImplementedException("Area() is not implemented");
        }
    }
