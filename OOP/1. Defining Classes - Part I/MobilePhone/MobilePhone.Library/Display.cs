//display characteristics 
//(size and number of colors).

namespace MobilePhone.Library
{
    using System;
    using System.Text;

    public class Display
    {
        private int? displayWidth;
        private int? displayHeight;
        private long? numberOfColors;

        public int? DisplayWidth
        {
            get { return displayWidth; }
            set { displayWidth = value; }
        }

        public int? DisplayHeight
        {
            get { return displayHeight; }
            set { displayHeight = value; }
        }

        public long? NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }

        public Display()
        {
            this.displayWidth = null;
            this.displayHeight = null;
            this.numberOfColors = null;
        }

        public Display(int displayWidth, int displayHeight)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
            this.numberOfColors = null;
        }

        public Display(int displayWidth, int displayHeight, long numberOfColors)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
            this.numberOfColors = numberOfColors;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            if (displayWidth != null)
            {
                output.Append(string.Format("   Width: {0}{1}", displayWidth, Environment.NewLine));
            }
            if (displayHeight != null)
            {
                output.Append(string.Format("   Height: {0}{1}", displayHeight, Environment.NewLine));
            }
            if (numberOfColors != null)
            {
                output.Append(string.Format("   Colors: {0}{1}", numberOfColors, Environment.NewLine));
            }

            return output.ToString();
        }
    }
}
