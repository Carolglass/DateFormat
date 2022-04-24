//Tests para la fecha con la funcion en la clase Format1

using NUnit.Framework;

namespace DateFormat.Test;

public class Tests1
{
    [SetUp]
    public void Setup()
    {
    }

    //Test para el método agregado por Carol Glass
    [Test]
    public void TestDateFormat1()
    {
        const string expected = "10-11-1977";
        Format1 date = new Format1("10/11/1977");
        Assert.AreEqual(expected, date.ChangeFormat1());
    }

    //Test para el método agregado por Carol Glass
    [Test]
    public void TestDateFormat2()
    {
        const string expected = "2-9-1999";
        Format1 date = new Format1("2/9/1999");
        Assert.AreEqual(expected, date.ChangeFormat1());
    }

    //Test para ver que funcione cuando no se ingresa ninguna fecha
    [Test]
    public void TestDateFormat3()
    {
        const string expected = "-";
        Format1 date = new Format1("");
        Assert.AreEqual(expected, date.ChangeFormat1());
    }

}