namespace Lesson_7
{
    public static class MyStringExtentions
    {
        public static int StringLength(this string input)
        {
            int count = 0;
            for(int i =0; i< input.Length; i++)
                count++;
            return count;
        }
        public static int CharCount(this string input, char sample)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
                if (input[i] == sample) count++;
            return count;
        }
    }
}