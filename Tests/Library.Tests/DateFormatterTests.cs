namespace Library.Tests;
using TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    ///Una fecha en formato correcto
    [Test]
    public void TestDateOk()
    {
        string expectedDate="1997-11-10";
        string result= DateFormatter.ChangeFormat("10/11/1997");
        Assert.AreEqual(expectedDate,result);
    }
    
    
    ///Una fecha que no tenga el formato correcto 
    
    [Test]
    public void TestDateFalse()
    {
        string expectedDate="1997-11-10";
        string result= DateFormatter.ChangeFormat(expectedDate);
        Assert.AreEqual(expectedDate,result);
    }

    
    ///Una fecha en blanco
    

    [Test]
    public void TestDateNull()
    {
        string expectedDate="";
        string result= DateFormatter.ChangeFormat(expectedDate);
        Assert.AreEqual(expectedDate,result);
    }
}