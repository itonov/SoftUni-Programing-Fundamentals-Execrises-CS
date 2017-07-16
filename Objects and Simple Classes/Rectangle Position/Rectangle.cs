using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Position
{
    public class Rectangle
    {
        public int top { get; set; }

        public int left { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public int right
        {
            get
            {
                return left + width;
            }
        }

        public int bottom
        {
            get
            {
                return top + height;
            }
        }

        public bool isInside (Rectangle rectToCheck)
        {
            bool leftCheck = left >= rectToCheck.left;
            bool rightCheck = right <= rectToCheck.right;
            bool topCheck = top <= rectToCheck.top;
            bool bottomCheck = bottom <= rectToCheck.bottom;

            return (leftCheck && rightCheck && topCheck && bottomCheck);
        }

    }
}
