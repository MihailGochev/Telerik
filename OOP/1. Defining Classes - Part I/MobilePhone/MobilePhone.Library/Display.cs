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
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Display size cannot be null!");
                }

                if (value <= 1)
                {
                    throw new ArgumentException("Display size cannot be negative or zero!");
                }

                displayWidth = value;
            }
        }

        public int? DisplayHeight
        {
            get { return displayHeight; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Display size cannot be null!");
                }

                if (value <= 1)
                {
                    throw new ArgumentException("Display size cannot be negative or zero!");
                }

                displayHeight = value;
            }
        }

        public long? NumberOfColors
        {
            get { return numberOfColors; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Number of colors cannot null!");
                }

                if (value <= 0)
                {
                    throw new ArgumentException("Number of colors cannot be negative or zero!");
                }

                numberOfColors = value;
            }
        }

        public Display()
        {
            this.displayWidth = null;    //setting the field
            this.displayHeight = null;   //setting the field
            this.numberOfColors = null;  //setting the field
        }

        public Display(int displayWidth, int displayHeight)
        {
            this.DisplayWidth = displayWidth;    //setting the property
            this.DisplayHeight = displayHeight;  //setting the property  
            this.numberOfColors = null;          //setting the field
        }

        public Display(int displayWidth, int displayHeight, long numberOfColors)
            : this(displayWidth, displayHeight)
        {
            this.NumberOfColors = numberOfColors; //setting the property
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
