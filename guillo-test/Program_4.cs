namespace guillo_test
{
    internal class Program_4
    {
        public static int GetMinimumOperations(string bin)
        {
            var binList = bin.ToList();
            var counter = 0;
            var index = 0;
            while (true)
            {
                if (binList[index] == '1' && binList[index + 1] == '1')
                {
                    binList[index] = '0';
                    binList[index + 1] = '0';
                    counter++;
                }
                else if (binList[index] == '0' && binList[index + 1] == '1')
                {
                    binList[index] = '1';
                    counter++;
                }
                else if (binList[index] == '1' && binList[index + 1] == '0')
                {
                    binList[index + 1] = '1';
                    counter++;
                }
                else
                {
                    if (binList.Count - 1 > index + 2) index += 2;
                    else index++;
                    if (index + 1 >= binList.Count) break;
                }
            }
            return counter;
        }
    }
}
