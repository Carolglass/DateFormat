//Tests para la fecha con la funcion en la clase Format2

using NUnit.Framework;

namespace DateFormat.Test;

public class Tests2
{
    [SetUp]
    public void Setup()
    {
    }
    //Test para el código ejemplo modificado en caso que no se ponga ninguna fecha
    [Test]
    public void TestDateFormat1()
    {
        const string expected = "-";
        Format2 date = new Format2("");
        Assert.AreEqual(expected, date.ChangeFormat2());
    }

    //Test para el código ejemplo modificado
    [Test]
    public void TestDateFormat2()
    {
        const string expected = "1999-09-02";
        Format2 date = new Format2("02/09/1999");
        Assert.AreEqual(expected, date.ChangeFormat2());
    }

    //Test para el codigo ejemplo modificado
    [Test]
    public void TestDateFormat3()
    {
        const string expected = "1977-11-10";
        Format2 date = new Format2("10/11/1977");
        Assert.AreEqual(expected, date.ChangeFormat2());
    }


}