namespace guillo_test
{
    class Program_2
    {
        static public int MaxIndex(int steps, int badIndex)
        {
            int j = 1;
            int counter = 0;
            for (int i = 0; i < steps; i++)
            {
                if (counter + j != badIndex) counter += j;
                j++;
            }

            int j_2 = 2;
            int counter_2 = 0;
            for (int i = 1; i < steps; i++)
            {
                if (counter_2 + j_2 != badIndex) counter_2 += j_2;
                j_2++;
            }
            return int.Max(counter, counter_2);
        }
    }
}
