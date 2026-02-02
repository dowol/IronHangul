using IronHangul;
using System.Reflection;

namespace IronHangulTest;

[TestClass]
public class CharUtilTest
{
    [TestMethod]
    [DataRow('ㄱ')]
    [DataRow('ㅗ')]
    [DataRow('ㄽ')]
    [DataRow('한')]
    [DataRow('글')]
    [DataRow('\u1106')]
    [DataRow('\u1161')]
    [DataRow('\u11af')]
    [DataRow('A')]
    [DataRow('z')]
    [DataRow('1')]
    [DataRow('0')]
    [DataRow('$')]
    public void TestCtype(char c)
    {
        foreach(MethodInfo method in typeof(HangulCharUtility).GetMethods().Where(m => m.IsStatic && m.Name.StartsWith("IsHangul")))
        {
            if (method.Invoke(null , [c]) is object result)
                Console.WriteLine($"{method.Name}('{c}') => {result}");
        }
    }

    [TestMethod]
    public void TestConversion(char c)
    {

    }
}
