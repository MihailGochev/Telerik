//Define a class BitArray64 to hold 64 bit values inside an ulong value. 
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
namespace BitArray.Library
{
    using System;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private const int BitCount = 64;
        private ulong int64Value;

        public ulong Int64Value
        {
            get
            {
                return int64Value;
            }
            private set
            {
                int64Value = value;
            }
        }

        public BitArray64()
            : this(0)
        {
        }

        public BitArray64(ulong int64Value)
        {
            this.Int64Value = int64Value;
        }

        public int this[int index]
        {
            get
            {
                if ((index < 0) || (index > BitCount))
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} was out of range [{1}, {2}]", index));
                }

                return (int64Value & (1UL << index)) > 0 ? 1 : 0;

            }

            set
            {
                if ((index < 0) || (index > BitCount))
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} was out of range [0, 64]", index));
                }
                if (value != 0 && value != 1)
                {
                    throw new ArgumentException(String.Format("Value:{0} must be 1 or 0.", value));
                }

                if (value == 0)
                {
                    int64Value &= ~(1UL << index);
                }
                else
                {
                    int64Value |= ((ulong)value << index);
                }
            }
        }

        public override int GetHashCode()
        {
            return this.int64Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is BitArray64)
            {
                return this.Int64Value.Equals(((BitArray64)obj).Int64Value);
            }
            else
            {
                throw new ArgumentException(String.Format("The object is of type {0}, not BitArray64.", obj.GetType().Name));
            }
        }

        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return !a.Equals(b);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("[");

            for (int index = BitCount - 1; index >= 0; index--)
            {
                output.Append(this[index]);
            }

            output.Append("]");
            return output.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int index = BitCount - 1; index >= 0; index--)
            {
                yield return this[index];
            }
        }
    }
}