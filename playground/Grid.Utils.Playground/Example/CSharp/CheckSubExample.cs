namespace Grid.Utils.Playground.Example.CSharp;

public static class CheckSubExample
{
    public static void Test() {
        uint a = 5;
        uint b = 10;

        try
        {
            uint result = checked(a - b); // 使用 checked 关键字进行带检查的减法操作
            Console.WriteLine("Subtraction result: " + result);
        }
        catch (OverflowException)
        {
            // 当减法结果超出 uint 范围时执行的分支
            Console.WriteLine("Subtraction resulted in overflow");
            // 可以在这里执行适当的处理逻辑
        }
    } 
}