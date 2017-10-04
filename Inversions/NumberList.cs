using System;
using System.Collections.Generic;
using System.Text;

namespace Inversions
{
    public class NumberList
    {
        List<int> numberList = new List<int>();

        private struct PartialResult
        {
            public List<int> sortedList { get; set; }
            public Int64 inversions { get; set; }
        }

        public void Add(int numberToAdd)
        {
            numberList.Add(numberToAdd);
        }

        private PartialResult SortAndCount(List<int> subList)
        {
            int length = subList.Count;

            if (length == 1)
            {
                return new PartialResult { sortedList = subList, inversions = 0 };
            }
            else
            {
                int divideAt = length / 2;
                List<int> left = subList.GetRange(0, divideAt);
                List<int> right = subList.GetRange(divideAt, length-divideAt);
                PartialResult partialLeft = SortAndCount(left);
                PartialResult partialRight = SortAndCount(right);
                PartialResult result = new PartialResult();
                result.sortedList = new List<int>();
                result.inversions = partialLeft.inversions + partialRight.inversions;
                int i = 0;
                int j = 0;
                for (int k=0; k<length; k+=1)
                {
                    if ((i < partialLeft.sortedList.Count) && (j ==partialRight.sortedList.Count || partialLeft.sortedList[i] <= partialRight.sortedList[j]))
                    {
                        result.sortedList.Add(partialLeft.sortedList[i]);
                        i += 1;
                    }
                    else
                    {
                        result.sortedList.Add(partialRight.sortedList[j]);
                        j += 1;
                        result.inversions += partialLeft.sortedList.Count - i;
                    }
                }
                return (result);
            }

        }

        public Int64 Inversions()
        {
            return SortAndCount(numberList).inversions;
        }
    }
}
