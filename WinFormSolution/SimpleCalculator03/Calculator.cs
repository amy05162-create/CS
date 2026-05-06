using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SimpleCalculator03
{
    internal class Calculator
    {
        private int _x;
        private int _y;
        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public int Add()
        {
            return X + Y;
        }

        public int Subtract()
        {
            return X - Y;
        }

    }

   


}
