using guillo_test;

int GetStringValue(char value)
{
    var charCode = Convert.ToInt16(value) - 96;
    if (charCode >= 1 && charCode <= 2) return 1;
    else if (charCode >= 3 && charCode <= 5) return 2;
    else if (charCode >= 6 && charCode <= 8) return 3;
    else if (charCode >= 9 && charCode <= 11) return 4;
    else if (charCode >= 12 && charCode <= 14) return 5;
    else if (charCode >= 15 && charCode <= 17) return 6;
    else if (charCode >= 18 && charCode <= 20) return 7;
    else if (charCode >= 21 && charCode <= 23) return 8;
    else if (charCode >= 24 && charCode <= 26) return 9;
    return 0;
}

int CountSubstrings(string value)
{
    var mapedString = new List<int>();
    var counter = 0;
    foreach (var element in value) mapedString.Add(GetStringValue(element));
    for (var i = 0; i < mapedString.Count; i++)
    {
        for (var j = 0; j < mapedString.Count; j++)
        {
            if (j + i + 1 > mapedString.Count) break;
            var data = mapedString.Slice(j, i + 1);
            if (data.Sum() % data.Count == 0) counter++;
        }
    }
    return counter;
}

//Console.WriteLine(CountSubstrings("asdfghijklmnopqrstuvwxyz"));
//Console.WriteLine(Program_2.MaxIndex(4, 6));
//Console.WriteLine(Program_3.CountMinimumOperations("abcd"));
//Console.WriteLine(Program_4.GetMinimumOperations("1111"));
Console.WriteLine(Program_5.GetMinFlips("1110011000"));