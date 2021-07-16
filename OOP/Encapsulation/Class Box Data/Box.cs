using System;

namespace Box
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;
        public Box(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }

                height = value;
            }
        }
        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Lenght
        {
            get { return lenght; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Lenght cannot be zero or negative.");
                }
                lenght = value;
            }
        }

        public string SurfaceArea()
        {
            // Surface Area = 2lw + 2lh + 2wh
           double surface = (2 * Lenght * Width) + (2 * Lenght * Height) + (2 * Width * Height);
            return $"Surface Area - {surface:f2}";
        }

        public string LateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            double lateral = (2 * Lenght * Height) + (2 * Width * Height);
            return $"Lateral Surface Area - {lateral:f2}";
        }

        public string Volume()
        {
            //Volume = lwh
            double volume = Lenght * Width * Height;

            return $"Volume - {volume:f2}";
        }
    }
}
