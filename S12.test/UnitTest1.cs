using Microsoft.VisualStudio.TestTools.UnitTesting;
using S12.lib;

namespace S12.test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Name a = new Name("Ali", "SheikhAttar");
        string number = "0991919191";
        Address h = new Address("tehran", "tehran", "Zafar");
        string email = "ali.sheikhattar@yahoo.com";
        Person A = new Person(a, number, email, h);
        Assert.AreEqual(A.Person_Number,number);
    }

    [TestMethod]
    public void TestMethod2()
    {
        Name a = new Name("F", "K");
        string number = "0991919191";
        Address h = new Address("tehran", "tehran", "Zafar");
        Person B = new Person(a, number,null,  h);
        Assert.AreEqual(B.Person_Number,number);
        var number2 = "100898789";
        B.Person_Number = number2;
        Assert.AreEqual(B.Person_Number,number2);

    }

    [TestMethod]
    public void TestMethod3()
    {
        Name a = new Name("F", "S");
        string number = "0991919191";
        string email = "F.sheikhattar@outlook.com";
        Person C = new Person(a, number, email, null);
        C.Person_Email = null;
        Assert.AreEqual(C.Person_Email,null);
    }
    [TestMethod]
    public void TestMethod4()
    {
        PhoneBook first = new PhoneBook();
        Name a = new Name("Ali", "SheikhAttar");
        string number = "0991919191";
        Address h = new Address("tehran", "tehran", "Zafar");
        string email = "ali.sheikhattar@yahoo.com";
        Person A = new Person(a, number, email, h);
        first.Add_to_phonebook(A);
        Name b = new Name("F", "S");
        string numberb = "0991919191";
        string emailb = "F.sheikhattar@outlook.com";
        Person C = new Person(b, numberb, emailb, null);
        C.Person_Email = null;
        first.Add_to_phonebook(C);
        first.remove_the_nth_contact_from_phonebook(2);
        Person D = first.get_nth_contact(1);
        Assert.AreEqual(A, D);
        
    }
    [TestMethod]
    public void TestMethod5()
    {
        PhoneBook Last = new PhoneBook();
        Address residence = new Address("new jersey", "princton", "112 Mercer Street");
        Name his_name = new Name("Albert","Einstein");
        Person Last_one = new Person(his_name,"1.800","albert_einstein@princeton.edu",residence);
        Last.Add_to_phonebook(Last_one);
        PhoneBook first = new PhoneBook();
        Name a = new Name("Ali", "SheikhAttar");
        string number = "0991919191";
        Address h = new Address("tehran", "tehran", "Zafar");
        string email = "ali.sheikhattar@yahoo.com";
        Person A = new Person(a, number, email, h);
        Name b = new Name("F", "S");
        string numberb = "0991919191";
        string emailb = "F.sheikhattar@outlook.com";
        Person C = new Person(b, numberb, emailb, null);
        C.Person_Email = null;
        Last.Add_to_phonebook(A);
        Last.Add_to_phonebook(C);
        var contactz = Last._Contacts;
        int test = contactz.Count;
        Assert.IsTrue(test == 3);
        Last.remove_the_nth_contact_from_phonebook(3);
        int test1 = contactz.Count;
        Assert.AreEqual(test1,2);       
        Person D = Last.get_nth_contact(2);
        Assert.AreEqual(D, A);
        A.Person_Name = new Name("AAA","BBB");
        Assert.AreEqual(Last.get_nth_contact(2).Person_Name, A.Person_Name);

    }
}