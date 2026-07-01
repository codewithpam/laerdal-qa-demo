using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calc;

    [SetUp]
    public void Setup() => _calc = new Calculator();

    [Test]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        var result = _calc.Add(3, 4);
        Assert.That(result, Is.EqualTo(7));  // ✅ passes
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));  // ✅ passes
    }

    [Test]
    public void Subtract_ReturnsCorrectResult()
    {
        var result = _calc.Subtract(10, 3);
        Assert.That(result, Is.EqualTo(7));  // ✅ passes
    }
}
