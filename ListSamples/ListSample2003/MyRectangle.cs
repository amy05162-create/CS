using System;
using System.Collections.Generic;
using System.Text;

namespace ListSample2003
{
    internal class MyRectangle
    {
       public string Name{ get; set; }
       public int Width { get; set; }
       public int Height { get; set; }

       public int Area => Width * Height;

    }
}
