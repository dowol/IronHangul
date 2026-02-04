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
    [DataRow('ㅎ')]
    [DataRow('ㅏ')]
    [DataRow('ㄴ')]
    [DataRow('글')]
    [DataRow('\u1106')]
    [DataRow('\u1161')]
    [DataRow('\u11af')]
    public void TestConversion(char c)
    {
        try
        {
            Console.WriteLine("조합형-호환자모_변환({0}) => {1}" , c , c.ToCompatibilityJamo());
        }
        catch(ArgumentException)
        {
            Console.WriteLine("'{0}' 은/는 한글 조합형 자모가 아닙니다", c);
        }
    }
}
