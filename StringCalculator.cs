using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Calculator
{
    class StringCalculator
    {
        int calledCount = 0;

        public int Add(string numbers)
        {
            calledCount++;

            numbers = numbers.Replace("[^0-9]", "");

            if (numbers == "")
            {
                return 0;
            }
            else
            {
                char delimiter = ',';

                List<int> numList = numbers.Split(delimiter).Select(int.Parse).ToList();

                int numListCount = numList.Count;

                if (numListCount == 1)
                {
                    return numList[0];
                }
                else
                {
                    int numbersSum = 0;
                    List<int> negativeNumbersList = new List<int>();

                    for (int i = 0; i < numListCount; i++)
                    {
                        if (numList[i] <= 1000)
                        {
                            if (numList[i] < 0)
                            {
                                negativeNumbersList.Add(numList[i]);
                            }

                            numbersSum += numList[i];
                        }
                    }

                    int negativeNumbersListCount = negativeNumbersList.Count;

                    if (negativeNumbersListCount > 0)
                    {
                        throw new ArgumentOutOfRangeException(negativeNumbersList.ToString(), "negatives not allowed");
                    }

                    return numbersSum;
                }
            }
        }

        public int GetCalledCount()
        {
            return calledCount;
        }

        public event Action<string, int> AddOccured;
    }
}
