namespace Grid.Util.Collections.Generics;

public class UnorderedRefListTests
{
    record struct Foo(int A, int B);
    
    [Fact]
    void ResizeTest() {
        UnorderedRefList<Foo> list = new();
        list.Capacity = 50;
    }
}