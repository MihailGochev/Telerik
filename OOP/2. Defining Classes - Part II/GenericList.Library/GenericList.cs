//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
//Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
//clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.

namespace GenericList.Library
{
    using System;
    using System.Text;
    using System.Linq;

    public class GenericList<T>
        where T : IComparable
    {
        private T[] listArray;
        private int maxSize;
        private int lastIndex;

        public GenericList()
            : this(4) //default size 4
        {
        }

        public GenericList(int initialSize)
        {
            if (initialSize < 0)
            {
                throw new ArgumentException("The index cannot be negative");
            }
            listArray = new T[initialSize];
            lastIndex = 0;
            maxSize = initialSize;
        }

        public int Count
        {
            get
            {
                return lastIndex;
            }
        }

        public void Add(T value)
        {
            listArray[lastIndex++] = value;
            if (lastIndex >= maxSize)
            {
                DoubleListSize();
            }
        }

        public void Clear()
        {
            listArray = new T[0];
            maxSize = 0;
            lastIndex = 0;
        }

        public int IndexOf(T value)
        {
            for (int index = 0; index < lastIndex; index++)
            {
                if (listArray[index].CompareTo(value) == 0)
                {
                    return index;
                }
            }

            return -1;
        }

        public void Insert(int index, T value)
        {
            lastIndex++;
            if (lastIndex >= maxSize)
            {
                DoubleListSize();
            }

            for (int startIndex = lastIndex - 1; startIndex >= index + 1; startIndex--)
            {
                listArray[startIndex] = listArray[startIndex - 1];
            }

            listArray[index] = value;
        }

        public void Remove(T element)
        {
            int index = IndexOf(element);
            if (index >= 0)
            {
                RemoveAt(index);
            }
        }

        public void RemoveAt(int index)
        {
            CheckIndex(index); //throws an error if invalid index is given
            for (int startIndex = index; startIndex < lastIndex - 1; startIndex++)
            {
                listArray[startIndex] = listArray[startIndex + 1];
            }
            lastIndex--;
        }

        public T this[int index]
        {
            get
            {
                CheckIndex(index);//throws an error if invalid index is given
                return listArray[index];
            }
            set
            {
                CheckIndex(index);//throws an error if invalid index is given
                listArray[index] = value;
            }
        }

        public override string ToString()
        {
            if (lastIndex == 0)
            {
                return "[Empty list!]";
            }
            StringBuilder output = new StringBuilder();

            for (int index = 0; index < lastIndex; index++)
            {
                output.Append(string.Format(index < (lastIndex - 1) ? "{0}, " : "{0}", listArray[index], Environment.NewLine));
            }
            return output.ToString();
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index > lastIndex)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the array.");
            }
        }

        private void DoubleListSize()
        {
            if (maxSize != 0)
            {
                maxSize *= 2;
            }
            else
            {
                maxSize = 4;
            }
            T[] biggerArray = new T[maxSize];
            for (int index = 0; index < listArray.Length; index++)
            {
                biggerArray[index] = listArray[index];
            }
            listArray = biggerArray;
        }

        public T Min()
        {
            return listArray.Min();
        }

        public T Max()
        {
            return listArray.Max();
        }
    }
}
