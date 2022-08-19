using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array=new int[] {1,2,3,4,5,6,7,8,9,10};
            float[] array2 = new float[] { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f, 7.7f};
            Console.WriteLine(Search(array2, 2.2f));
            Console.WriteLine(GetIndexByBinarySearh(array, 1));
            Console.ReadKey();
        }

        private static int Search<T>(T[] data, T value) where T : IComparable
        {
            int leftBound = 0;
            int rightBound = data.Length-1;
            int middle=0;
            if (leftBound == rightBound)
                return leftBound;
            while (true)
            {
                if (rightBound - 1 == leftBound)
                {
                    if (data[leftBound].CompareTo(value)==0)
                        return leftBound;
                    if (data[rightBound].CompareTo(value) == 0)
                        return rightBound;
                    return -1;
                }
                else
                {
                    middle= leftBound + (rightBound - leftBound) / 2;
                    if (data[middle].CompareTo(value) <0)
                        leftBound = middle;
                    if(data[middle].CompareTo(value) > 0)
                        rightBound = middle;
                    if (data[middle].CompareTo(value) == 0)
                        return middle;

                }
            }            
        }

        private static int GetIndexByBinarySearh(int[] array, int value)
        {
            int leftBound = 0;
            int rightBound = array.Length - 1;
            int middle = 0;
            if (leftBound == rightBound)
                return leftBound;
            while (true)
            {
                if (rightBound - 1 == leftBound)
                {
                    if (array[leftBound].CompareTo(value) == 0)
                        return leftBound;
                    if (array[rightBound].CompareTo(value) == 0)
                        return rightBound;
                    return -1;
                }
                else
                {
                    middle = leftBound + (rightBound - leftBound) / 2;
                    if (array[middle].CompareTo(value) < 0)
                        leftBound = middle;
                    if (array[middle].CompareTo(value) > 0)
                        rightBound = middle;
                    if (array[middle].CompareTo(value) == 0)
                        return middle;

                }
            }
           
        }
    }
}
