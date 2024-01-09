using NUnit.Framework;
using static Fakultet_ClassLibrary.Fakultet;
using FluentAssertions;

namespace FakultetTest;
public class Tests
{
    [Test]
    public void Return1For0()
    {
        GetSumRecursively(0).Should().Be(1);
    }
    [Test]
    public void Return1For0_loop()
    {
        GetSumUsingLoop(0).Should().Be(1);
    }

    [Test]
    public void Return1For1()
    {
        GetSumRecursively(1).Should().Be(1);
    }
    [Test]
    public void Return1For1_loop()
    {
        GetSumUsingLoop(1).Should().Be(1);
    }

    [Test]
    public void Return2For2()
    {
        GetSumRecursively(2).Should().Be(2);
    }
    [Test]
    public void Return2For2_loop()
    {
        GetSumUsingLoop(2).Should().Be(2);
    }

    [Test]
    public void Return6For3()
    {
        GetSumRecursively(3).Should().Be(6);
    }
    [Test]
    public void Return6For3_loop()
    {
        GetSumUsingLoop(3).Should().Be(6);
    }

    [Test]
    public void Return24For4()
    {
        GetSumRecursively(4).Should().Be(24);
    }
    [Test]
    public void Return24For4_loop()
    {
        GetSumUsingLoop(4).Should().Be(24);
    }

    [Test]
    public void Return3628800For9()
    {
        GetSumRecursively(9).Should().Be(362880);
    }
    [Test]
    public void Return3628800For9_loop()
    {
        GetSumUsingLoop(9).Should().Be(362880);
    }
}
