namespace ConsoleApp3;

public static class Solver
{
    public static int Solve(string s)
    {
        if (s.Length == 2)
        {
            return s[0] == s[1] ? 1 : 0;
        }
        
        var goodStringCount = 0;
        var counterLeft = new int[s.Length];
        counterLeft[0] = 1;
        var uniqueCharsLeft = new HashSet<char> { s[0] };
        var uniqueCharsRight = new Dictionary<char, int>();

        foreach (var t in s)
        {
            if (!uniqueCharsRight.TryAdd(t, 1))
            {
                uniqueCharsRight[t]++;
            }
        }

        uniqueCharsRight[s[0]]--;

        for (var i = 1; i < s.Length; i++)
        {
            // left
            var currentChar = s[i];
            uniqueCharsLeft.Add(currentChar);
            counterLeft[i] = uniqueCharsLeft.Count;
            
            // right
            uniqueCharsRight[currentChar]--;
            if (uniqueCharsRight[currentChar] == 0)
            {
                uniqueCharsRight.Remove(currentChar);
            }

            if (counterLeft[i] == uniqueCharsRight.Keys.Count)
            {
                goodStringCount++;
            }
        }
        
        return goodStringCount;
    }
}