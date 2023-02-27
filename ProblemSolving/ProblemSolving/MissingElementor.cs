namespace ProblemSolving
{
    public static class MissingElementor
    {
        private static List<int> answer;

        public static IEnumerable<int> MissingElements(int[] arr)
        {
            answer = new List<int>();

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i] - 1)
                    continue;
                else
                    AddElements(arr[i - 1], arr[i]);
            }

            return answer;
        }

        private static void AddElements(int current, int last)
        {
            for (int i = current+1; i < last; i++)
                answer.Add(i);
        }
    }
}