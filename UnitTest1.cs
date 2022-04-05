using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest;

[TestClass]
public class UnitTest1
{
    /*    Arithmetic Methods    */
    [TestMethod]
    public void TestAritmeticAdd()
    {
        double result = Calculator.Arithmetic.Add(5, 10);
        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void TestAritmeticSub()
    {
        double result = Calculator.Arithmetic.Sub(5, 10);
        Assert.AreEqual(-5, result);
    }

    [TestMethod]
    public void TestAritmeticMultiplication()
    {
        double result = Calculator.Arithmetic.Multiplication(5, 10);
        Assert.AreEqual(50, result);
    }

    [TestMethod]
    public void TestAritmeticDiv()
    {
        double result = Calculator.Arithmetic.Div(5, 10);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestAritmeticModulus()
    {
        double result = Calculator.Arithmetic.Modulus(5, 10);
        Assert.AreEqual(5, result);
    }

    /*    Algebra Methods    */
    [TestMethod]
    public void TestAlgebraFormula1()
    {
        double result = Calculator.Algebra.Formula1(5, 10);
        Assert.AreEqual(225, result);
    }

    [TestMethod]
    // ( a - b )^2
    public void TestAlgebraFormula2()
    {
        double result = Calculator.Algebra.Formula2(5, 10);
        Assert.AreEqual(25, result);
    }
    
    [TestMethod]
    // a^2 - b^2
    public void TestAlgebraFormula3()
    {
        double result = Calculator.Algebra.Formula3(5, 10);
        Assert.AreEqual(-75, result);
    }

    [TestMethod]
    // a^2 + b^2
    public void TestAlgebraFormula4()
    {
        double result = Calculator.Algebra.Formula4(5, 10);
        Assert.AreEqual(125, result);
    }

    [TestMethod]
    // (a + b)^3
    public void TestAlgebraFormula5()
    {
        double result = Calculator.Algebra.Formula5(5, 10);
        Assert.AreEqual(3375, result);
    }
    
    [TestMethod]
    // (a - b)^3
    public void TestAlgebraFormula6()
    {
        double result = Calculator.Algebra.Formula6(5, 10);
        Assert.AreEqual(-125, result);
    }

    [TestMethod]
    // a^3 + b^3
    public void TestAlgebraFormula()
    {
        double result = Calculator.Algebra.Formula7(5, 10);
        Assert.AreEqual(1125, result);
    }
}