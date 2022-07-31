using FSharpAndCSharp;
using Hedgehog.Linq;
using Hedgehog.Xunit;
using Range = Hedgehog.Linq.Range;
using static Hedgehog.Linq.Property;

namespace CSharpTests;

public class UnitTest1
{
    [Property]
    public void Test1(int x, int y)
    {
        var result = FSModule.add(x, y);
        Assert.Equal(x + y, result);
    }

    [Xunit.Fact]
    public void Test2()
    {
        var prop =
            from x in ForAll(Gen.Int32(Range.LinearBoundedInt32()))
            from y in ForAll(Gen.Int32(Range.LinearBoundedInt32()))
            select FSModule.add(x, y) == x + y;
        prop.Recheck("2_2739805263657200078_4836735881065597067_0101010101010101010101010101010101010111011110");
    }
}