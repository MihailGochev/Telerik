//display characteristics 
//(size and number of colors).
using System;

namespace MobilePhone.Library
{
    public class Display
    {
        private int displayWidth;
        private int displayHeight;
        private long numberOfColors;
        public int DisplayWidth
        {
            get { return displayWidth; }
            set { displayWidth = value; }
        }

        public int DisplayHeight
        {
            get { return displayHeight; }
            set { displayHeight = value; }
        }

        public long NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }

    }
}
