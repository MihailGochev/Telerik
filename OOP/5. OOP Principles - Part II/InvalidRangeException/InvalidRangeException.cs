namespace InvalidRangeException
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public T Start
        {
            get { return start; }
            private set { start = value; }
        }

        public T End
        {
            get { return end; }
            private set { end = value; }
        }

        public InvalidRangeException(string message)
            : base(message)
        {
        }

        public InvalidRangeException(string message, Exception causeException)
            : base(message, causeException)
        {
        }

        public InvalidRangeException(string message, T start, T end)
            : base(message, null)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end, Exception causeException)
            : base(message, causeException)
        {
            this.Start = start;
            this.End = end;
        }

        public override string Message
        {
            get
            {
                if (start != null && end != null)
                {
                    return string.Format("Value not in range: [{0}, {1}]. {2}", this.start, this.end, base.Message);
                }
                else
                {
                    return base.Message;
                }
            }
        }
    }
}
