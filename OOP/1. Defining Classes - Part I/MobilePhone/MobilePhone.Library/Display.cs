//display characteristics 
//(size and number of colors).

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

        public Display()
        {
            this.displayWidth = 320;
            this.displayHeight = 480;
            this.numberOfColors = 16000000;
        }

        public Display(int displayWidth, int displayHeight)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
            this.numberOfColors = 16000000;
        }

        public Display(int displayWidth, int displayHeight, long numberOfColors)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
            this.numberOfColors = numberOfColors;
        }

        public override string ToString()
        {
            return string.Format("Display size:{0}x{1} pixels, {2} colors.", displayWidth, displayHeight, numberOfColors);
        }
    }
}
