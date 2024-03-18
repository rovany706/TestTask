using ConsoleApp3;

namespace TestProject;

public class SolverTest
{
    public static object[] TestCases =
    {
        new object[] { "aacaba", 2 },
        new object[] { "ab", 0 },
        new object[] { "aa", 1 },
        new object[] { "aba", 0 },
        new object[] { "aaaccc", 1 },
        new object[] { "aaabcc", 0 },
        new object[] { "abcacabcabca", 7 }
    };
    
    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void Solve_ReturnExpected(string s, int expected)
    {
        var actual = Solver.Solve(s);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
}