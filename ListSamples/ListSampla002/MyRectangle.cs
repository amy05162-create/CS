using System;
using System.Collections.Generic;
using System.Text;

namespace ListSampla002
{
    internal class MyRectangle
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area
        {
            get { return Width * Height; }
        }


    }
}
