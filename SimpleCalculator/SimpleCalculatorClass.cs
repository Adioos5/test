using System;

namespace SimpleCalculator
{
    public class SimpleCalculatorClass
    {
        public static void Main(string[] args)
        {
            int result = Calc("-1,2,3,4");
        }

        public static int Calc(string numbers)
        {
            int result = -1;
            char[] separators = { ',', '\n' };

            List<string> wordsList = numbers.Split(separators).ToList();

            if (numbers == "") return 0;
            else if (wordsList.Count == 1) return int.Parse(numbers);
            else if (wordsList.Count > 1) {

                result = 0;

                for (int i = 0; i < wordsList.Count; i++)
                {
                    if (wordsList[i][0] == '-') throw new Exception();
                    if (wordsList[i] == "1000") continue;

                    result += int.Parse(wordsList[i]);
                }
            }

            return result;
        }
    }
}