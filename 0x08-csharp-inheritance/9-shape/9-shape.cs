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

    /// <summary> Public Area with Exception </summary>
    class Rectangle: Shape
    {
        private int width;
        private int height;

        /// <summary> Public Area with Exception </summary>
        public int Width
        {
            get {return width;}

            set {
                if (value < 0)
                {
                    throw new ArgumentException("Width must be greater than or equal to 0");
                }
                width  = value;
            }

        }

        /// <summary> Public Area with Exception </summary>
        public int Height
        {
            get {return height;}

            set {
                if (value < 0)
                {
                    throw new ArgumentException("Height must be greater than or equal to 0");
                }
                height = value;
            }
        }

        // <summary> Public Area for rectangle </summary>
        public new int Area()
        {
            return (width * height);
        }

        // <summary> Public Override </summary>
        public override string ToString()
        {
            return string.Format("[Rectangle] {0} / {1}", width, height);
        }
    }

    // <summary> Class Square that inherits from Rectangle </summary>
    class Square: Rectangle
    {
        private int size;

        public int Size
        {
            get {return size;}

            set {
                if (value < 0)
                {
                    throw new ArgumentException("Size must be greater than or equal to 0");
                }
                size = value;
                Height = value;
                Width = value;
            }
        }
        // <summary> Public override to string format </summary>
        public override string ToString()
        {
            return (string.Format("[Square] {0} / {1}", Width, Height));
        }
    }

